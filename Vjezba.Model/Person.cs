using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Radionica.Model
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "First name must have atleast 3 charachters")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Last name must have atleast 3 charachters")]
        public string LastName { get; set; }

    }
}
