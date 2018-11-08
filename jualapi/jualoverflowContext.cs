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
    {
      modelBuilder.Entity<Questions>().HasData(
      new Questions { Id = -1, Title = "How does code work?", Content = "Code works with pure and simple magic, there is no rhyme or reason, it is literally generated from thin air", AvgQueVotes = 0 },
      new Questions { Id = -2, Title = "How does code work?", Content = "Code works with pure and simple magic, there is no rhyme or reason, it is literally generated from thin air", AvgQueVotes = 10 },
      new Questions { Id = -3, Title = "How does code work?", Content = "Code works with pure and simple magic, there is no rhyme or reason, it is literally generated from thin air", AvgQueVotes = 110 },
      new Questions { Id = -4, Title = "How does code work?", Content = "Code works with pure and simple magic, there is no rhyme or reason, it is literally generated from thin air", AvgQueVotes = 10 },
      new Questions { Id = -5, Title = "How does code work?", Content = "Code works with pure and simple magic, there is no rhyme or reason, it is literally generated from thin air", AvgQueVotes = 11 },
      new Questions { Id = -6, Title = "How does code work?", Content = "Code works with pure and simple magic, there is no rhyme or reason, it is literally generated from thin air", AvgQueVotes = 9 },
      new Questions { Id = -7, Title = "How does code work?", Content = "Code works with pure and simple magic, there is no rhyme or reason, it is literally generated from thin air", AvgQueVotes = 10 },
      new Questions { Id = -8, Title = "How does code work?", Content = "Code works with pure and simple magic, there is no rhyme or reason, it is literally generated from thin air", AvgQueVotes = 0 },
      new Questions { Id = -9, Title = "How does code work?", Content = "Code works with pure and simple magic, there is no rhyme or reason, it is literally generated from thin air", AvgQueVotes = 0 },
      new Questions { Id = -10, Title = "How does code work?", Content = "Code works with pure and simple magic, there is no rhyme or reason, it is literally generated from thin air", AvgQueVotes = 0 }
      );
    }
    public DbSet<Questions> Questions { get; set; }
    public DbSet<Answers> Answers { get; set; }
  }
}
