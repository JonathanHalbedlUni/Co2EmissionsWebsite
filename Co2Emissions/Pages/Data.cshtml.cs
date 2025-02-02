using Microsoft.AspNetCore.Mvc.RazorPages;
using Co2Emissions.Models;
using System.Collections.Generic;

namespace Co2Emissions.Pages
{
    public class DataModel : PageModel
    {
        public List<Co2DataModel> CO2Data { get; set; }

        public void OnGet()
        {
            CO2Data = Co2DataModel.GetSampleData();
        }
    }
}