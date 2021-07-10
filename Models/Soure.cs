using Bigschool.ViewModel;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Bigschool.Models
{
    public class Soure
    {
        public int Id { get; set; }
        public ApplicationUser Lecturer { get; set; }
        [Required]
        public string LiecturerId { get; set; }
        [Required]
        [StringLength(255)]

        public string Place { get; set; }
        
        public DateTime DateTime { get; set; }
        public Category catagory { get; set; }
        [Required]
        public byte catacoryId { get; set; }
    }
   
}