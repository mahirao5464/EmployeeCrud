using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCrud.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Employee Code required and should be unique.")]
        [Remote("IsEmployeeCodeExists", "Employees", HttpMethod = "POST", ErrorMessage = "code already exists in database."
            )]
        public string? EmployeeCode { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? EmailId { get; set; }
        [Required]
        public IList<Phone>? PhoneNumbers { get; set; }
    }
    public class Phone
    {
        [Key]
        public int PhoneId { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }

        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
