using System.ComponentModel.DataAnnotations;
namespace BlazorServerNotes.Model
{
    public class Note
    {
        [Key]
        public int RID { get; set; }
		public DateTime CreatedAt { get; set; } //Timestamp
		public string CreatedBy { get; set; } = string.Empty;
		public string UserName{ get; set; } = string.Empty;

		[Required]
        [MaxLength(200)]
        public string Title { get; set; } = string.Empty;
		
		public string Author{ get; set; } = string.Empty;
		public DateTime PubDate{ get; set; } 

		[Required]
        [MaxLength(5000)]
        public string Content { get; set; } = string.Empty;

		public string Description{ get; set; } = string.Empty;// Desc or Summary
		public string Remark { get; set; } = string.Empty;// User remark, comment or note
		public string Tags { get; set; } = string.Empty;//list of tags

		public string URL{ get; set; } = string.Empty;

		public string Category{ get; set; } = string.Empty;
		public string CategoryPath { get; set; } = string.Empty; //golang/architecture/clean

		public string Topic { get; set; } = string.Empty;
		public string Channel{ get; set; } = string.Empty;


		//pinned

	}
}


/*
 
type Feed struct {
	Title string
	URL   string

	Description  string
	Note         string
	CategoryPath string //Golang/CheatSheet/...
	Tags         []string

	RID         int //RecordID:LastID
	CreatedDate time.Time
	CreatedBy   string //owner of the collection
}

func NewFeed(title, url string) *Feed {
	return &Feed{Title: title, URL: url}
}

type Note struct {
Category
Channel/Topic
Tags
	Title string
	URL   string
	Note  string
}


 
 */
