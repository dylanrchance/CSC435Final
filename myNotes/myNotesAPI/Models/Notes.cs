using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myNotesAPI.Models
{
    public class Notes
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public string IsDeleted { get; set; }
        public string CreatedOn { get; set; }
        public string UserID { get; set; }
        public string CategoryID { get; set; }
    }
}
