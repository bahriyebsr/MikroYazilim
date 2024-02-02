﻿namespace MikroYazilim.WebUI.Areas.Admin.Models
{
    public class ProductListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ImagePath { get; set; }
        public string İncele { get; set; }
    }
}