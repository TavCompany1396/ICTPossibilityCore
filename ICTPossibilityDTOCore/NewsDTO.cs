using System;
using System.Collections.Generic;

namespace ICTPossibilityDTOCore.Model
{
    public class NewsDTO 
    {
        public  IEnumerable<NewsFileDTO> NewsFiles { set; get; }


        public int  Id { get; set; }

        public string DisplayName { get; set; }

        public string GroupName { get; set; }
        public string TotalTime { get; set; }

        public DateTime CreatedOn { get; set; }
        public string CreatedOnPersian { get; set; }



        public string Title { get; set; }
        public string Summary { get; set; }
        public string Text { get; set; }
        public bool Publish { get; set; }
        public string StartDate { get; set; }
        public string StartClock { get; set; }
        public string EndDate { get; set; }
        public string EndClock { get; set; }
        public bool IsActive { get; set; }
        public DateTime ExpireDate { get; set; }




    }
}
