using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MasterProduct.BussinessEntities
{
    public class ProductBE
    {
        public int IdProduct { get; set; }
        [Required]
        public string NameProduct { get; set; }
        public string Properties { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ManufacturerEmail { get; set; }
        public string IdCountry { get; set; }
        public string Cost { get; set; }
        public string UnitsAvailable { get; set; }
        public string SoldUnits { get; set; }
        public Boolean StateProduct { get; set; }
        public string ImageProduct { get; set; }
    }
}
