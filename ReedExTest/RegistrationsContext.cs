using Microsoft.EntityFrameworkCore;

// <snippet_PragmaWarningDisable>
namespace ReedExTest.Model;

#pragma warning disable CS1591

public class RegistrationContext : DbContext
{
    public RegistrationContext(DbContextOptions<RegistrationContext> options) : base(options) { }

    public DbSet<Registration> Registrations => Set<Registration>();
    public DbSet<Person> Persons => Set<Person>();
    public DbSet<Organisation> Organisations => Set<Organisation>();
    public DbSet<Address> Addresses => Set<Address>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
}

#pragma warning restore CS1591
// </snippet_PragmaWarningDisable>