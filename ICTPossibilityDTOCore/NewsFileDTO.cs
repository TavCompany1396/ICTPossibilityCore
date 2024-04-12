using System;
using System.Collections.Generic;

namespace ICTPossibilityDTOCore.Model
{
    public class NewsFileDTO 
    {
        public string FileName { get; set; }
        public string TypeMIME { get; set; }
        public int TypeFile { get; set; }
        public int TypeConfirm { get; set; }
        public int EntityId { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string RealFileName { get; set; }

    }
}
