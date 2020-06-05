using System;
using System.Collections.Generic;
using System.Text;

namespace Radionica.Model
{
    public class Client : Person
    {
        public virtual ICollection<Breakdown> Breakdowns { get; set; }
    }
}
