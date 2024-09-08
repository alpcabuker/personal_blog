using System.Data.Entity;

namespace KisiselWebProjesi.Models.Classes
{
    public class Context:DbContext
    {
        public DbSet<Admin> Admins { get; set; } 
        public DbSet<HomePage> HomePages { get; set; }
        public DbSet<icons> icons { get; set; }
        
    }
}