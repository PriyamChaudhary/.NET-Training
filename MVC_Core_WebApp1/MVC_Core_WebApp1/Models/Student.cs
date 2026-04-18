using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MVC_Core_WebApp1.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Roll No can't be left blank.")]
        public int RollNo { get; set; }

        [Required(ErrorMessage = "Name can't be left blank.")]
        [StringLength(15,MinimumLength =2,ErrorMessage ="Name min length is 2 and max length is 15")]
        public string Name { get; set; }

        [Range(18,60,ErrorMessage ="Age is invalid")]
        public int Age { get; set; }
        public string Address { get; set; }
    }
}
