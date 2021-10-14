using Microsoft.EntityFrameworkCore;
using System;

namespace DotNetCoreUnderstanding
{
  public class MyWorkDbContext: DbContext
  {
    //Data Source=.;Initial Catalog=mywork;Integrated Security=True


    public DbSet<Employee> Employee { get; set; }
    public DbSet<Department> Department { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(@"Server=.;Database=mywork;Integrated Security=True;");
    }

  }
}
