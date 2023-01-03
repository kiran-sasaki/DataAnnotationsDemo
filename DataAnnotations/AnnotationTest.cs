using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotations
{
    public static class AnnotationTest
    {
        public static void Display()
        {
            Console.WriteLine("Employee validation");
            Console.WriteLine("--------------------------");
            Employee employee = new Employee();
            employee.Name = "Kiran";
            employee.Age = 10;
            employee.PhoneNumber = "5678334565";

            ValidationContext context = new ValidationContext(employee, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(employee,context,validationResults,true);
            if(!valid)
            {
                foreach(ValidationResult validationResult in validationResults)
                {
                    Console.Write("Member Name: {0}",validationResult.MemberNames.First(),Environment.NewLine);
                    Console.Write("Error message: {0}{1}",validationResult.ErrorMessage,Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Name: "+employee.Name+"Age: "+employee.Age+"PhnNo: "+employee.PhoneNumber);

            }
            Console.WriteLine("Exit");

        }
    }
}
