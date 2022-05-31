using System.ComponentModel.DataAnnotations;
namespace BlazorServerNoteApp_MarketNotes.Model
{
    public class MarketNote
    {
		[Key]
		public int RID { get; set; }

		public DateTime EventDate { get; set; } //Date of Event

		public DateTime CreatedAt { get; set; } //Timestamp
		public string CreatedBy { get; set; } = string.Empty;
		public string UserName { get; set; } = string.Empty;

		[Required]
		[MaxLength(200)]
		public string Title { get; set; } = string.Empty;

		public string Author { get; set; } = string.Empty;
		public DateTime PubDate { get; set; }


		[MaxLength(5000)]
		public string Content { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;// Desc or Summary
		public string Remark { get; set; } = string.Empty;// User remark, comment or note
		public string Tags { get; set; } = string.Empty;//list of tags
		public string URL { get; set; } = string.Empty;

		public string Category { get; set; } = string.Empty;
		public string CategoryPath { get; set; } = string.Empty; //golang/architecture/clean

		public string Topic { get; set; } = string.Empty;
		public string Channel { get; set; } = string.Empty;


		public static List<MarketNote> LoadSampleData()
		{
			return new()
			{
				new MarketNote { RID = -1, EventDate = DateTime.Today, Title = "Blazor WebAssembly on Azure Static Web Apps - Scott Hanselman's Blog", URL = "https://www.hanselman.com/blog/blazor-webassembly-on-azure-static-web-apps", Description = "Many apps today are just static files on the front end - HTML and JavaScript" },
				new MarketNote { RID = -2, EventDate = DateTime.Today, Title = "The Polestar Precept is a cypher for the EV automaker", URL = "https://techcrunch.com/2021/12/04/the-polestar-precept-is-a-cypher-for-the-ev-automakers-future/", Description = "Polestar will spend the next three years executing a lofty electric vehicle launch schedule that will culminate with the Precept concept." },
				new MarketNote { RID = -3, EventDate = DateTime.Today, Title = "美CPI創40年新高？週四聯準會FED升不升息？聯準會的三不一沒有 20211213《楊世光在金錢爆》第2769集", URL = "https://www.youtube.com/watch?v=lfVMCJ-H3hE", Description = " 聯準會不加息？三不，一沒有" }
			};


		}


	}
}
