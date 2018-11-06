using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using jualapi.Models;

namespace jualapi
{
  public partial class jualoverflowContext : DbContext
  {
    public jualoverflowContext()
    {
    }

    public jualoverflowContext(DbContextOptions<jualoverflowContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        optionsBuilder.UseNpgsql("server=localhost;database=jual-overflow");
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    { }
    public DbSet<Questions> Questions { get; set; }
    public DbSet<Answers> Answers { get; set; }
  }
}
