using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;  

namespace MVCCRUD.Models
{
    public class Food
    {
        [Required(ErrorMessage = "Please Provide id")]
       
         public int id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide name")]
        public string name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide category")]   
        public string category { get; set; }
        [Required(ErrorMessage = "Please Provide Last Name")]
        public int price { get; set; }


    }
}