using Microsoft.EntityFrameworkCore;
using PucarsServices.Models;
using System;

namespace AKD.AKDTrading.Services.Finance.API.DomainModels
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // base.OnModelCreating(modelBuilder);
           // modelBuilder.Entity<WatchListScripMarket>()
           //.HasKey(x => new { x.WatchListScripId, x.MarketId });


           
          
        }

        public DbSet<GetAllBoardMeetings> boardMeetings { get; set; }
    }
}
