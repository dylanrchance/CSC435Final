﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myAPI.Models
{
    public class Notes
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public string CreatedOn { get; set; }
        public int CategoryID { get; set; }
        public int UserID { get; set; }
        public string IsDeleted { get; set; }
    }
}
