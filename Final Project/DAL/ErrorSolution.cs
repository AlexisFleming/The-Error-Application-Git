using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class ErrorSolution
    { 
        public int ErrorSolutionID {get;set;}
        public int ErrorID { get; set; }
        public int SolutionID { get; set; }
        public int SolutionDate { get; set; }
    }
}
