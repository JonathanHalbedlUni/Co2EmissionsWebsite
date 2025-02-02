using System.Collections.Generic;

namespace Co2Emissions.Models
{
    public class Co2DataModel
    {
        public string Country { get; set; }
        public string Company { get; set; }
        public int Emissions { get; set; }

        public static List<Co2DataModel> GetSampleData()
        {
            return
            [
                new Co2DataModel { Country = "Germany", Company = "Bier GmbH", Emissions = 1000000 },
                new Co2DataModel { Country = "Germany", Company = "Eco Power AG", Emissions = 2500000 },
                new Co2DataModel { Country = "USA", Company = "Sample Corp.", Emissions = 5000000 },
                new Co2DataModel { Country = "USA", Company = "GreenTech Ltd.", Emissions = 3200000 },
                new Co2DataModel { Country = "USA", Company = "Tesla Inc.", Emissions = 1800000 },
                new Co2DataModel { Country = "China", Company = "LingChang Ltd.", Emissions = 5000000 },
                new Co2DataModel { Country = "China", Company = "Solar Future Co.", Emissions = 4800000 },
                new Co2DataModel { Country = "Austria", Company = "Servus GmbH", Emissions = 5000000 },
                new Co2DataModel { Country = "Austria", Company = "Vienna Renewables", Emissions = 2300000 },
                new Co2DataModel { Country = "Australia", Company = "Sydney Solar", Emissions = 2100000 },
                new Co2DataModel { Country = "France", Company = "Paris Energy", Emissions = 2750000 },
                new Co2DataModel { Country = "France", Company = "EcoFriendly SAS", Emissions = 3400000 },
                new Co2DataModel { Country = "Canada", Company = "Green Maple Inc.", Emissions = 2800000 },
                new Co2DataModel { Country = "Canada", Company = "EcoSolutions Canada", Emissions = 1900000 },
                new Co2DataModel { Country = "Japan", Company = "Nippon Solar", Emissions = 3100000 },
                new Co2DataModel { Country = "Japan", Company = "Tokyo GreenTech", Emissions = 2700000 },
                new Co2DataModel { Country = "Brazil", Company = "Amazonas Energy", Emissions = 4500000 },
                new Co2DataModel { Country = "Brazil", Company = "EcoBrasil Ltda.", Emissions = 2900000 },
                new Co2DataModel { Country = "India", Company = "Green India Ltd.", Emissions = 4300000 },
                new Co2DataModel { Country = "India", Company = "Solar Bharat", Emissions = 3900000 },
                new Co2DataModel { Country = "South Africa", Company = "Johannesburg Renewables", Emissions = 3700000 },
                new Co2DataModel { Country = "South Africa", Company = "Capetown Energy", Emissions = 2800000 },
                new Co2DataModel { Country = "Mexico", Company = "EcoMexico SA", Emissions = 2600000 },
                new Co2DataModel { Country = "Mexico", Company = "Solar Azteca", Emissions = 3100000 },
                new Co2DataModel { Country = "Italy", Company = "Rome Energy Group", Emissions = 2900000 },
                new Co2DataModel { Country = "Italy", Company = "Milan Renewables", Emissions = 2600000 },
                new Co2DataModel { Country = "Russia", Company = "Moscow GreenPower", Emissions = 4100000 },
                new Co2DataModel { Country = "Russia", Company = "Siberian Energy Corp.", Emissions = 3500000 },
                new Co2DataModel { Country = "South Korea", Company = "Seoul Tech Energy", Emissions = 3300000 },
                new Co2DataModel { Country = "South Korea", Company = "Korea Solar Ltd.", Emissions = 3100000 }
            ];
        }
    }
}
