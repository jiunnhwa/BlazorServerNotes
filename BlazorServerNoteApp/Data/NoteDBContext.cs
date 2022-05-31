using BlazorServerNoteApp.Model;
using Microsoft.EntityFrameworkCore;


namespace BlazorServerNoteApp.Data
{
    public class NoteDBContext: DbContext
    {
        public DbSet<Note>? Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) => dbContextOptionsBuilder.UseSqlite("Data Source=Note.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Note[] postsToSeed = new Note[6];

            //for (int i = 1; i <= 6; i++)
            //{
            //    postsToSeed[i - 1] = new Note
            //    {
            //        PostId = i,
            //        Title = $"Post {i}",
            //        Content = $"This is post {i}'s content. I have also liked and subscribed."
            //    };
            //}
            //modelBuilder.Entity<Note>().HasData(postsToSeed);

            modelBuilder.Entity<Note>().HasData(BlazorServerNoteApp.Model.Note.LoadSampleData().ToArray());
            
        }
    }
}
