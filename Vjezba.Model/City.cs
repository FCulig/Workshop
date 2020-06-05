using Radionica.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Vjezba.Model
{
    public class City
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "City name must have atleast 3 charachters")]
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
