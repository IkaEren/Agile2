using Microsoft.EntityFrameworkCore;

namespace AgileData
{
    public class AgileDbContext : DbContext
    {
        public DbSet<Member>      Members      { get; set; }
        public DbSet<Venue>       Venues       { get; set; }
        public DbSet<Facility>    Facilities   { get; set; }
        public DbSet<Booking>     Bookings     { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Activity>    Activities   { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:appd.database.windows.net,1433;Initial Catalog=appd;Persist Security Info=False;User ID=jingyen;Password=AppdNut2016;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*************** Defining Member Entity      ***************/
            modelBuilder.Entity<Member>().HasKey(m => m.Id);
            /*************** Member Entity End           ***************/

            /*************** Defining Venue Entity       ***************/
            modelBuilder.Entity<Venue>().HasKey(v => v.Id);
            /*************** Venue Entity End            ***************/

            /*************** Defining Facility Entity    ***************/
            modelBuilder.Entity<Facility>().HasKey(f => f.Id);
            /*************** Member Facility End         ***************/

            /*************** Defining Booking Entity     ***************/
            modelBuilder.Entity<Booking>().HasKey(b => b.Id);

            modelBuilder.Entity<Booking>()
                .HasOne(t => t.Transaction)
                .WithMany(b => b.Bookings)
                .HasForeignKey(t => t.Id);
            /*************** Member Booking End          ***************/

            /*************** Defining Transaction Entity ***************/
            modelBuilder.Entity<Transaction>().HasKey(t => t.Id);
            /*************** Member Transaction End      ***************/
        }

    } // End of AgileDbContext class
} // End of Data namespace
