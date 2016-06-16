using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DonNetCore.Models
{
    public class Person
    {
        [Required]
        public string Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [DataType(dataType:DataType.Password)]
        public string Password { get; set; }

        public Sex Sex { get; set; }
    }

    public enum Sex
    {
        Male,
        Female
    }
}
