using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class error
    {
        public int ErrorID { get; set; }
        public string ErrorDescription { get; set; }
        public int StudentID { get; set; }
        public string ProgLanguageID { get; set; }
        public string ModuleTopicID { get; set; }
        public string ErrorStatus { get; set; }
    }
}
