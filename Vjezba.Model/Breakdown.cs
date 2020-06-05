using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Radionica.Model
{
    public class Breakdown
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0.5, 1000, ErrorMessage = "Fixing time must be between 0.5h and 1000h")]
        public float FixingTime { get; set; }

        [ForeignKey("Client")]
        [Required]
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }

        [ForeignKey("Employee")]
        [Required]
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
