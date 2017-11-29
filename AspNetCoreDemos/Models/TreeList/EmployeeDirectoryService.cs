﻿using Kendo.Mvc;
using Kendo.Mvc.Extensions;

namespace AspNetCoreDemos.Models.TreeList
{
    using System.Linq;
    using Kendo.Mvc.UI;
    using Microsoft.AspNetCore.Mvc.ModelBinding;
    using Microsoft.EntityFrameworkCore;

    public static class EmployeeDirectoryIEnumerableExtensions
    {
        public static EmployeeDirectoryModel ToEmployeeDirectoryModel(this EmployeeDirectory employee)
        {
            return new EmployeeDirectoryModel
            {
                EmployeeId = employee.EmployeeID,
                ReportsTo = employee.ReportsTo,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Address = employee.Address,
                City = employee.City,
                Country = employee.Country,
                BirthDate = employee.BirthDate,
                HireDate = employee.HireDate,
                Phone = employee.Phone,
                Position = employee.Position,
                Extension = employee.Extension,
                hasChildren = employee.InverseReportsToNavigation.Any()
            };
        }

        public static EmployeeDirectoryModel ToEmployeeDirectoryModel(this EmployeeDirectory employee, DataSourceRequest request)
        {
            var filters = request.Filters;
            if (!filters.Any()) {
                return employee.ToEmployeeDirectoryModel();
            }

            var predicate = ExpressionBuilder.Expression<EmployeeDirectory>(filters, false).Compile();

            return new EmployeeDirectoryModel
            {
                EmployeeId = employee.EmployeeID,
                ReportsTo = employee.ReportsTo,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Address = employee.Address,
                City = employee.City,
                Country = employee.Country,
                BirthDate = employee.BirthDate,
                HireDate = employee.HireDate,
                Phone = employee.Phone,
                Position = employee.Position,
                Extension = employee.Extension,
                hasChildren = employee.InverseReportsToNavigation.Any(predicate)
            };
        }
    }

    public class EmployeeDirectoryService
    {
        private SampleEntitiesDataContext db;

        public EmployeeDirectoryService(SampleEntitiesDataContext context)
        {
            db = context;
        }

        public EmployeeDirectoryService()
            : this(new SampleEntitiesDataContext())
        {
        }       

        public virtual IQueryable<EmployeeDirectory> GetAll()
        {
            var employees = db.EmployeeDirectories.ToList();
            employees.Each(e => {
                e.InverseReportsToNavigation = employees.Where(ee => ee.ReportsTo == e.EmployeeID).ToList();                
            });

            return employees.AsQueryable();
        }

        public virtual void Insert(EmployeeDirectoryModel employee, ModelStateDictionary modelState)
        {
            if (ValidateModel(employee, modelState))
            {
                var entity = employee.ToEntity();

                db.EmployeeDirectories.Add(entity);
                db.SaveChanges();

                employee.EmployeeId = entity.EmployeeID;
            }
        }

        public virtual void Update(EmployeeDirectoryModel employee, ModelStateDictionary modelState)
        {
            if (ValidateModel(employee, modelState))
            {
                var entity = employee.ToEntity();
                db.EmployeeDirectories.Attach(entity);				
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public virtual void Delete(EmployeeDirectoryModel employee, ModelStateDictionary modelState)
        {
            var entity = employee.ToEntity();

            db.EmployeeDirectories.Attach(entity);

            Delete(entity);

            db.SaveChanges();
        }

        private void Delete(EmployeeDirectory employee)
        {
            var children = db.EmployeeDirectories.Where(e => e.ReportsTo == employee.EmployeeID);            

            foreach (var subordinate in children)
            {
                Delete(subordinate);
            }           

            db.EmployeeDirectories.Remove(employee);            
        }

        private bool ValidateModel(EmployeeDirectoryModel employee, ModelStateDictionary modelState)
        {
            if (employee.HireDate < employee.BirthDate)
            {
                modelState.AddModelError("errors", "Employee cannot be hired before birth.");
                return false;
            }
            
            return true;
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}