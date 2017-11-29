﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.IO;

namespace AspNetCoreDemos.Controllers
{
	public partial class UploadController : Controller
	{
        public IHostingEnvironment HostingEnvironment { get; set; }

        public UploadController(IHostingEnvironment hostingEnvironment)
        {
            HostingEnvironment = hostingEnvironment;
        }

        public ActionResult Async()
		{
			return View();
		}

		public ActionResult Save(IEnumerable<IFormFile> files)
		{
			// The Name of the Upload component is "files"
			if (files != null)
			{
				foreach (var file in files)
				{
					var fileContent = ContentDispositionHeaderValue.Parse(file.ContentDisposition);
					
					// Some browsers send file names with full path.
					// We are only interested in the file name.
					var fileName = Path.GetFileName(fileContent.FileName.Value.Trim('"'));
					var physicalPath = Path.Combine(HostingEnvironment.WebRootPath, "App_Data", fileName);
					
					// The files are not actually saved in this demo
					//file.SaveAs(physicalPath);
				}
			}

			// Return an empty string to signify success
			return Content("");
		}

		public ActionResult Remove(string[] fileNames)
		{
			// The parameter of the Remove action must be called "fileNames"
			
			if (fileNames != null)
			{
				foreach (var fullName in fileNames)
				{
					var fileName = Path.GetFileName(fullName);
					var physicalPath = Path.Combine(HostingEnvironment.WebRootPath, "App_Data", fileName);

					// TODO: Verify user permissions

					if (System.IO.File.Exists(physicalPath))
					{
						// The files are not actually removed in this demo
						// System.IO.File.Delete(physicalPath);
					}
				}
			}

			// Return an empty string to signify success
			return Content("");
		}
	}
}