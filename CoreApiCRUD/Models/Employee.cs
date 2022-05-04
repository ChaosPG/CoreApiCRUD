using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiCRUD.Models
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot be longer than 50 characters long")]
        public string Name { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Position cannot be longer than 50 characters long")]
        public string Position { get; set; }

        [Required]
        public int Salary { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Address cannot be longer than 200 characters long")]
        public string Address { get; set; }

        [Required]
        [MaxLength(11, ErrorMessage = "PhoneNumber cannot be longer than 11 characters long")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
    }
}
