using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using MYAcademy_Portfolio.Entities;

namespace MYAcademy_Portfolio.Context;

public class PortfolioContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server =.\\SQLEXPRESS; Database = PortfolioDbNight; Trusted_Connection = True; TrustServerCertificate = True");
    }

    public DbSet<Education> Educations { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<About> Abouts { get; set; }
    public DbSet<Certificate> Certificates { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<Technology> Technologies { get; set; }
    public DbSet <HeroSection> HeroSections { get; set; }
}
