﻿using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json;
using System.Collections.Generic;
using IOFile = System.IO.File;

namespace AspNetCoreDemos.Models
{
    public static class NavigationProvider
    {
        public static IEnumerable<NavigationWidget> SuiteWidgets(IFileProvider fileProvider)
        {
            var file = fileProvider.GetFileInfo("/shared/nav.json");
            var navigationJson = IOFile.ReadAllText(file.PhysicalPath);
            return JsonConvert.DeserializeObject<IEnumerable<NavigationWidget>>(navigationJson);
        }
    }
}