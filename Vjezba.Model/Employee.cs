using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Vjezba.Model;

namespace Radionica.Model
{
    public class Employee : Person
    {
        [Required]
        public DateTime BirthDate { get; set; }
        public virtual ICollection<Breakdown> Breakdowns { get; set; }

        [ForeignKey("City")]
        public int CityID { get; set; }
        public virtual City City { get; set; }
    }
}
