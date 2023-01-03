using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotations
{
    public class Employee
    {
        [Required(ErrorMessage ="Employee {0} is requried")]
        [StringLength(100,MinimumLength =3,ErrorMessage ="Name should be minimum 3 characters and max of 100")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Range(18,99,ErrorMessage ="Age should be above 18")]
        public int Age { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }

    }
}
