using System;
using System.Collections.Generic;
using ICTPossibilityDomainCore.Model;
namespace ICTPossibilityDomainCore.Model
{
    public class QAGroupDTO
    {
        public  List<QADTO> QAs { set; get; }


        public int  Id { get; set; }

        public string Title { get; set; }



    }
}
