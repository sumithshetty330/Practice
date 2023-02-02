using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WepCRUDOperation.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public String Category { get; set; }
        public int IsActive { get; set; }
    }
}