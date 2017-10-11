using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week04Lab.Models.Week04
{
    public class City
    {
        public int CityId { get; set; }
        public String CityName { get; set; }
        public int Population { get; set; }

        public String ProvinceId { get; set; }
        public Province Prov { get; set; }
    }
}