using System;
using System.Collections.Generic;
using ICTPossibilityDomainCore.Model;
namespace ICTPossibilityDTOCore.Model
{
    public class LinkHomeIndexDTO
    {
        public  List<LinkDTO> Links { set; get; }
        public List<LinkGroupDTO> Groups { set; get; }
    }
}
