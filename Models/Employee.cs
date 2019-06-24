using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDSample.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public int Salary {get;set;}
    }
}