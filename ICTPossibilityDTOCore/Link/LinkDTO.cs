using System;
using System.Collections.Generic;

namespace ICTPossibilityDTOCore.Model
{
    public class LinkDTO
    {

        public string Title { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }

        public bool IsActive { get; set; }
        public DateTime? ExpireDate { get; set; }
        public int Id { get; set; }
        public int? GroupId { get; set; }



    }
}
