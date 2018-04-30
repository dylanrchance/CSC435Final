

namespace myNotesAPI.Models
{
    public class Notes
    {
        public long ID { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public string IsDeleted { get; set; }
        public string CreatedOn { get; set; }
        public string UserID { get; set; }
        public string CategoryID { get; set; }
    }
}
