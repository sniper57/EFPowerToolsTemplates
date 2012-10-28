using System;
using System.Collections.Generic;

namespace EFT.Models
{
    public class Member
    {
        public int ContactID { get; set; }
        public int ProjectID { get; set; }
        public System.DateTime JoinedOn { get; set; }
        public virtual Contact ContactIDContact { get; set; }
        public virtual Project ProjectIDProject { get; set; }
    }
}
