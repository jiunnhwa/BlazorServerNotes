using System.ComponentModel.DataAnnotations;
namespace BlazorServerNoteApp.Model
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


		//public string GetCategoryFromPath()
		//{
			
		//	//if (string.IsNullOrEmpty(Category))
		//	//{
		//	//	if (string.IsNullOrEmpty(CategoryPath))
		//	//	{
		//	//		item.Category = item.CategoryPath.Split(' ')[0];
		//	//	}
		//	//}
		//}

		public static List<Note> LoadSampleData()
		{
			return new() { 
				new Note { RID = -1, Title = "Blazor WebAssembly on Azure Static Web Apps - Scott Hanselman's Blog", URL = "https://www.hanselman.com/blog/blazor-webassembly-on-azure-static-web-apps", Description = "Many apps today are just static files on the front end - HTML and JavaScript" }, 
				new Note { RID = -2, Title = "The Polestar Precept is a cypher for the EV automaker", URL = "https://techcrunch.com/2021/12/04/the-polestar-precept-is-a-cypher-for-the-ev-automakers-future/", Description = "Polestar will spend the next three years executing a lofty electric vehicle launch schedule that will culminate with the Precept concept." } , 
				new Note { RID = -3, Title = "美CPI創40年新高？週四聯準會FED升不升息？聯準會的三不一沒有 20211213《楊世光在金錢爆》第2769集", URL = "https://www.youtube.com/watch?v=lfVMCJ-H3hE", Description = " 聯準會不加息？三不，一沒有" }  };


		}

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
