using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebStoreApp.Models
{
    public class Good
    {
        public float Cost { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public bool InStock { get; set; }

        public int Id { get; set; }
        public int Count { get; set; }
    }
}