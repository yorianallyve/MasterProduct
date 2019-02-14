using System;
using System.Collections.Generic;

namespace MasterProduct.DataAccess.SQL.Model
{
    public partial class Product
    {
        public int IdProduct { get; set; }
        public string NameProduct { get; set; }
        public string Properties { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ManufacturerEmail { get; set; }
        public string IdCountry { get; set; }
        public string Cost { get; set; }
        public string UnitsAvailable { get; set; }
        public string SoldUnits { get; set; }
        public bool StateProduct { get; set; }
        public string ImageProduct { get; set; }
    }
}
