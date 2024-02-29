using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogTracker.DAL.Entity
{
   public  class EmpInfo
    {
        public int EmpInfoId { get; set; }
        public string EmailId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfJoining { get; set; }
        public int PassCode { get; set; }
        

    }
}
