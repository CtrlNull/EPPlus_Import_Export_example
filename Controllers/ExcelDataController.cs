using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace EPPlus_Import_Export.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcelDataController : Controller
    {
        [HttpGet]
        public IActionResult Get(string Type, int shopId, string brand, List<string> selectedColumns)
        {
            if (Type == null || shopId <= 0 || brand == null)
                throw new Exception("Select Type");

                switch (Type.ToUpperInvariant())
                {
                    case "XML":
                        return File();
                    case "XLS":
                        return File();
                }
                throw new Exception("Select a valid type");
        }
    }
}