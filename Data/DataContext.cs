
using MoviesSiteApi.Models;

namespace MoviesSiteApi.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options)
        {
                
        }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<CastMember> CastMembers { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<MovieCastMember> MoviesCastMembers { get; set;}
        public DbSet<MovieGenre>MovieGenres { get; set; }
        public DbSet<MovieCompany> MoviesCompany { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //MovieGenres
            //key => genreid + movie id
            modelBuilder.Entity<MovieGenre>()
                .HasKey(mg => new {mg.GenreId, mg.MovieId});
            //each genre has many movies
            modelBuilder.Entity<MovieGenre>()
                .HasOne(m => m.Movie)
                .WithMany(mg => mg.MovieGenres)
                .HasForeignKey(g => g.GenreId);
            //each movie has many genres
            modelBuilder.Entity<MovieGenre>()
                .HasOne(v => v.Genre)
                .WithMany(mv => mv.MovieGenres)
                .HasForeignKey(m => m.MovieId);
            //-------------------------------------

            //MovieCastMembers
            //key => memberid + movie id
            modelBuilder.Entity<MovieCastMember>()
                .HasKey(mc => new { mc.MovieId, mc.MemberId });
            //each Movie has many castmembers
            modelBuilder.Entity<MovieCastMember>()
                .HasOne(m => m.Movie)
                .WithMany(mc => mc.MovieCastMembers)
                .HasForeignKey(m => m.MovieId);
            //each castmember csn work at  many Movies
            modelBuilder.Entity<MovieCastMember>()
                .HasOne(c => c.Member)
                .WithMany(mv => mv.MovieCastMembers)
                .HasForeignKey(c => c.MemberId);

            //-------------------------------------------
            //MovieCompany
            //key => company + movie id
            modelBuilder.Entity<MovieCompany>()
                .HasKey(mc => new { mc.CompanyId, mc.MovieId });
            //each genre has many movies
            modelBuilder.Entity<MovieCompany>()
                .HasOne(m => m.Movie)
                .WithMany(mc => mc.MovieCompanies)
                .HasForeignKey(c => c.CompanyId);
            //each movie has many genres
            modelBuilder.Entity<MovieCompany>()
                .HasOne(c => c.Company)
                .WithMany(mc => mc.MovieCompanies)
                .HasForeignKey(m => m.MovieId);
        }
    }
}
