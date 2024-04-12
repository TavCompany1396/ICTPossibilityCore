using System;
using System.Collections.Generic;

namespace ICTPossibilityDomainCore.Model
{
    public class QADTO 
    {

        public string Question { get; set; }
        public string Answer { get; set; }
        public bool IsActive { get; set; }
        public int Id { get; set; }

        public DateTime? ExpireDate { get; set; }

    }
}
