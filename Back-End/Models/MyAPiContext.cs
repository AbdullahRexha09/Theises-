using Microsoft.EntityFrameworkCore;
namespace MyWebAPi.models
{
    public class MyAPiContext : DbContext
    {
        public MyAPiContext(DbContextOptions<MyAPiContext> options):base (options)
        {

        }
        public DbSet<VisualMedia> VisualMedia {get;set;}
        public DbSet<VisualMediaBlob> VisualMediaBlobs{get;set;}
        
    }
}