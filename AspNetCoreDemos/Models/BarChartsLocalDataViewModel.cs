using System;
using System.Linq;

namespace AspNetCoreDemos.Models
{
    public class BarChartsLocalDataViewModel : BlogComments
    {
        public BarChartsLocalDataViewModel()
        {
        }

        public BarChartsLocalDataViewModel(BlogComments blogComments)
            : base(blogComments.Blog, blogComments.Day, blogComments.Value)
        {
        }

        public string UserColor { get; set; }
    }
}