using Microsoft.EntityFrameworkCore;
using tutibody.DAL.Entities;

namespace tutibody.DAL.Context
{
    public class TutibodyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-L3BQSPA\\SQLEXPRESS;initial Catalog=TutibodyDb;integrated Security=true;");

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sponsor> Sponsors { get; set; }
        public DbSet<Login> Logins { get; set; }
    }
}
