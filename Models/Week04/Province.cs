using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week04Lab.Models.Week04
{
    public class Province
    {
        public String ProvinceId { get; set; }
        public String ProvinceName { get; set; }
        public List<City> Cities { get; set; }
    }
}