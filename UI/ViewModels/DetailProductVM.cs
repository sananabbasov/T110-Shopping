using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.ViewModels
{
    public class DetailProductVM
    {
        public Product Product { get; set; }
        public List<Product> Products { get; set;}
        public List<Product> SameProduct { get; set; }

    }
}
