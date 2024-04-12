using System;
using System.Collections.Generic;
using ICTPossibilityDomainCore.Model;
namespace ICTPossibilityDTOCore.Model
{
    public class LinkGroupDTO
    {
        public  List<LinkDTO> Links { set; get; }

        public int  Id { get; set; }

        public string Title { get; set; }



    }
}
