﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebStoreApp.Models
{
    public class news
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}