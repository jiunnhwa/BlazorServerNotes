using BlazorServerNoteApp_MarketNotes.Model;
using Microsoft.EntityFrameworkCore;


namespace BlazorServerNoteApp_MarketNotes.Data
{
    public class DBContext : DbContext
    {
        public DbSet<MarketNote>? Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) => dbContextOptionsBuilder.UseSqlite("Data Source=MarketNote.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MarketNote>().HasData(BlazorServerNoteApp_MarketNotes.Model.MarketNote.LoadSampleData().ToArray());
        }
    }
}
