﻿using Bigschool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bigschool.ViewModel
{
    public class CourseViewModel
    {
        [Required]
        public string Place { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]

        public byte Category { get; set; }
        public IEnumerable<Category> categories { get; set; }
        public DateTime GetDateTime() {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}