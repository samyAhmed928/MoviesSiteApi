using Microsoft.EntityFrameworkCore;
using MoviesSiteApi.Data;
using MoviesSiteApi.Models;

namespace MoviesSiteApi
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            var countries = new List<Country>
            {
                new Country { Name = "United States" },
                new Country { Name = "United Kingdom" },
                new Country { Name = "Canada" },
                new Country { Name = "Australia" },
                new Country { Name = "France" }
            };

            // Add the countries to the model builder
            dataContext.AddRange(countries);
            dataContext.SaveChanges();

            // Create a list of companies
            var companies = new List<Company>
            {
                new Company { Name = "Warner Bros." ,Country=countries[0]},
                new Company { Name = "Universal Pictures",Country=countries[0]},
                new Company { Name = "Walt Disney Studios", Country = countries[0]},
                new Company { Name = "Sony Pictures Entertainment",Country=countries[0] },
                new Company { Name = "Paramount Pictures", Country = countries[0]}
            };

            // Add the companies to the model builder
            dataContext.AddRange(companies);
            dataContext.SaveChanges();

            // Create a list of genres
            var genres = new List<Genre>
            {
                new Genre { Name = "Action" },
                new Genre { Name = "Adventure" },
                new Genre { Name = "Comedy" },
                new Genre { Name = "Drama" },
                new Genre { Name = "Horror" },
                new Genre { Name = "Sci-Fi" },
                new Genre { Name = "Thriller" },
                new Genre { Name = "Fantasy" },
                new Genre { Name = "Epic" },
                new Genre { Name = "War" },
                new Genre { Name = "Crime" },
                new Genre { Name = "Animated" },
                new Genre { Name = "Musical" },
            };

            // Add the genres to the model builder
            dataContext.AddRange(genres);
            dataContext.SaveChanges();

            // Create a list of cast members
            var castMembers = new List<CastMember>
               {
                    new CastMember { Name = "Tom Hanks", BirthDate = new DateTime(1956, 7, 9), Gender = Gender.Male, Nationality = "American", Role = Role.Actor },
                    new CastMember { Name = "Morgan Freeman", BirthDate = new DateTime(1937, 6, 1), Gender = Gender.Male, Nationality = "American", Role = Role.Actor },
                    new CastMember { Name = "Steven Spielberg", BirthDate = new DateTime(1947, 12, 18), Gender = Gender.Male, Nationality = "American", Role = Role.Director },
                    new CastMember { Name = "Frank Darabont", BirthDate = new DateTime(1959, 1, 28), Gender = Gender.Male, Nationality = "American", Role = Role.Writer },

                    new CastMember { Name = "Leonardo DiCaprio", BirthDate = new DateTime(1974, 11, 11), Gender = Gender.Male, Nationality = "American", Role = Role.Actor },
                    new CastMember { Name = "Brad Pitt", BirthDate = new DateTime(1963, 12, 18), Gender = Gender.Male, Nationality = "American", Role = Role.Actor },
                    new CastMember { Name = "Quentin Tarantino", BirthDate = new DateTime(1963, 3, 27), Gender = Gender.Male, Nationality = "American", Role = Role.Director },
                    new CastMember { Name = "Roger Avary", BirthDate = new DateTime(1965, 8, 23), Gender = Gender.Male, Nationality = "American", Role = Role.Writer },

                    new CastMember { Name = "Elijah Wood", BirthDate = new DateTime(1977, 1, 28), Gender = Gender.Male, Nationality = "American", Role = Role.Actor },
                    new CastMember { Name = "Ian McKellen", BirthDate = new DateTime(1939, 5, 25), Gender = Gender.Male, Nationality = "British", Role = Role.Actor },
                    new CastMember { Name = "Peter Jackson", BirthDate = new DateTime(1961, 10, 31), Gender = Gender.Male, Nationality = "New Zealand", Role = Role.Director },
                    new CastMember { Name = "Fran Walsh", BirthDate = new DateTime(1959, 12, 22), Gender = Gender.Female, Nationality = "New Zealand", Role = Role.Writer },
                    new CastMember { Name = "Philippa Boyens", BirthDate = new DateTime(1962, 5, 22), Gender = Gender.Female, Nationality = "New Zealand", Role = Role.Writer },

                    // ... and so on for the other films
            };

            // Add the cast members to the model builder
            dataContext.AddRange(castMembers);
            dataContext.SaveChanges();

            // Create a list of movies
            var movies = new List<Movie>
            {
                new Movie
                {
                    Title = "The Shawshank Redemption",
                    Description = "Two imprisoned men bond over a period of many years, finding solace and friendship in each other's company.",
                    Language = "English",
                    CreatedDate = new DateTime(1994, 9, 23),
                    Rating = 9.2m,
                    Seasons = 1
                },
                 new Movie
                {
                    Title = "Pulp Fiction",
                    Description = "The lives of two mobsters, a boxer, and his wife intertwine in four tales of violence and redemption.",
                    Language = "English",
                    CreatedDate = new DateTime(1994, 10, 14),
                    Rating = 8.9m,
                    Seasons = 1
                },
                new Movie
                {
                    Title = "The Lord of the Rings: The Fellowship of the Ring",
                    Description = "A young hobbit, Frodo Baggins, is entrusted with the Ring of Power, which the Dark Lord Sauron needs to rule Middle-earth. Frodo and eight companions (who form the Fellowship of the Ring) begin their journey to Mount Doom in the land of Mordor, the only place where the Ring can be destroyed.",
                    Language = "English",
                    CreatedDate = new DateTime(2001, 12, 19),
                    Rating = 8.9m,
                    Seasons = 1
                },
                new Movie
                {
                    Title = "Schindler's List",
                    Description = "Oskar Schindler, a German businessman, makes a list of Jews he intends to save from the Holocaust, turning his factory into a refuge for the persecuted.",
                    Language = "English",
                    CreatedDate = new DateTime(1993, 12, 15),
                    Rating = 8.9m,
                    Seasons = 1
                },
                new Movie
                {
                    Title = "The Good, the Bad and the Ugly",
                    Description = "A bounty hunting gunslinger, a mercenary, and an outlaw race across the American Southwest during the Civil War to find a buried treasure while dodging armies, Indians, and bounty hunters.",
                    Language = "Italian",
                    CreatedDate = new DateTime(1966, 12, 29),
                    Rating = 8.8m,
                    Seasons = 1
                },
                new Movie
                {
                    Title = "The Matrix",
                    Description = "A computer hacker learns a shocking truth: the world he lives in is a computer-generated dream world, and that he is living two lives at the same time—one in the real world, and the other in the matrix, as a skilled fighter battling an underground war against powerful computers who have constructed his entire reality with a system called the matrix.",
                    Language = "English",
                    CreatedDate = new DateTime(1999, 3, 24),
                    Rating = 8.8m,
                    Seasons = 4
                },
                new Movie
                {
                    Title = "The Silence of the Lambs",
                    Description = "A young FBI agent is on the case of a serial killer who skins his victims. She must consult with an imprisoned cannibalistic psychiatrist to catch the killer.",
                    Language = "English",
                    CreatedDate = new DateTime(1991, 2, 14),
                    Rating = 8.7m,
                    Seasons = 1
                },
                new Movie
                {
                    Title = "The Godfather",
                    Description = "The Corleone family attempts to maintain its power in the face of opposition from other mob families, as Michael struggles to come to terms with the dark side of his empire.",
                    Language = "English",
                    CreatedDate = new DateTime(1974, 12, 20),
                    Rating = 9.0m,
                    Seasons = 3
                },
                new Movie
                {
                    Title = "The Lion King",
                    Description = "A young lion prince is exiled from his kingdom by his treacherous uncle, but eventually returns to claim his rightful place on the throne.",
                    Language = "English",
                    CreatedDate = new DateTime(1994, 6, 15),
                    Rating = 8.8m,
                    Seasons = 1
                }

            };
            dataContext.AddRange(movies);
            dataContext.SaveChanges();

            var MovieCompines = new List<MovieCompany>
            {
                new MovieCompany
                {
                    MovieId = 1,
                    CompanyId = 1,
                },
                new MovieCompany
                {
                    MovieId = 1,
                    CompanyId = 2,
                },
                new MovieCompany
                {
                    MovieId = 2,
                    CompanyId = 1,
                },
                new MovieCompany
                {
                    MovieId = 3,
                    CompanyId = 1,
                }
            };
            dataContext.AddRange(MovieCompines);
            dataContext.SaveChanges();

            var MovieCastMembers = new List<MovieCastMember>();

            foreach (var movie in movies)
            {
                var castMembersForMovie = new List<CastMember>();

                switch (movie.Title)
                {
                    case "The Shawshank Redemption":
                        castMembersForMovie.Add(castMembers.FirstOrDefault(c => c.Name == "Tom Hanks"));
                        castMembersForMovie.Add(castMembers.FirstOrDefault(c => c.Name == "Morgan Freeman"));
                        break;

                    case "Pulp Fiction":
                        castMembersForMovie.Add(castMembers.FirstOrDefault(c => c.Name == "Leonardo DiCaprio"));
                        castMembersForMovie.Add(castMembers.FirstOrDefault(c => c.Name == "Brad Pitt"));
                        break;

                    case "The Lord of the Rings: The Fellowship of the Ring":
                        castMembersForMovie.Add(castMembers.FirstOrDefault(c => c.Name == "Elijah Wood"));
                        castMembersForMovie.Add(castMembers.FirstOrDefault(c => c.Name == "Ian McKellen"));
                        break;

                    case "Schindler's List":
                        castMembersForMovie.Add(castMembers.FirstOrDefault(c => c.Name == "Liam Neeson"));
                        castMembersForMovie.Add(castMembers.FirstOrDefault(c => c.Name == "Ben Kingsley"));
                        break;

                    case "The Good, the Bad and the Ugly":
                        castMembersForMovie.Add(castMembers.FirstOrDefault(c => c.Name == "Clint Eastwood"));
                        castMembersForMovie.Add(castMembers.FirstOrDefault(c => c.Name == "Lee Van Cleef"));
                        break;

                    case "The Matrix":
                        castMembersForMovie.Add(castMembers.FirstOrDefault(c => c.Name == "Keanu Reeves"));
                        castMembersForMovie.Add(castMembers.FirstOrDefault(c => c.Name == "Laurence Fishburne"));
                        break;

                    case "The Silence of the Lambs":
                        castMembersForMovie.Add(castMembers.FirstOrDefault(c => c.Name == "Jodie Foster"));
                        castMembersForMovie.Add(castMembers.FirstOrDefault(c => c.Name == "Anthony Hopkins"));
                        break;

                    case "The Godfather":
                        castMembersForMovie.Add(castMembers.FirstOrDefault(c => c.Name == "Marlon Brando"));
                        castMembersForMovie.Add(castMembers.FirstOrDefault(c => c.Name == "Al Pacino"));
                        break;

                    case "The Lion King":
                        castMembersForMovie.Add(castMembers.FirstOrDefault(c => c.Name == "Matthew Broderick"));
                        castMembersForMovie.Add(castMembers.FirstOrDefault(c => c.Name == "James Earl Jones"));
                        break;
                }

                foreach (var castMember in castMembersForMovie)
                {
                    MovieCastMembers.Add(new MovieCastMember
                    {
                        MovieId = movie.Id,
                        MemberId = castMember.Id
                    });
                }
                dataContext.SaveChanges();
                dataContext.AddRange(castMembersForMovie);

                var MovieGenres = new List<MovieGenre>();

                foreach (var m in movies)
                {
                    var genresForMovie = new List<Genre>();

                    switch (m.Title)
                    {
                        case "The Shawshank Redemption":
                            genresForMovie.Add(genres.FirstOrDefault(g => g.Name == "Drama"));
                            break;

                        case "Pulp Fiction":
                            genresForMovie.Add(genres.FirstOrDefault(g => g.Name == "Action"));
                            genresForMovie.Add(genres.FirstOrDefault(g => g.Name == "Crime"));
                            break;

                        case "The Lord of the Rings: The Fellowship of the Ring":
                            genresForMovie.Add(genres.FirstOrDefault(g => g.Name == "Adventure"));
                            genresForMovie.Add(genres.FirstOrDefault(g => g.Name == "Fantasy"));
                            genresForMovie.Add(genres.FirstOrDefault(g => g.Name == "Epic"));
                            break;

                        case "Schindler's List":
                            genresForMovie.Add(genres.FirstOrDefault(g => g.Name == "Drama"));
                            genresForMovie.Add(genres.FirstOrDefault(g => g.Name == "War"));
                            genresForMovie.Add(genres.FirstOrDefault(g => g.Name == "Biography"));
                            break;

                        case "The Good, the Bad and the Ugly":
                            genresForMovie.Add(genres.FirstOrDefault(g => g.Name == "Western"));
                            genresForMovie.Add(genres.FirstOrDefault(g => g.Name == "Action"));
                            genresForMovie.Add(genres.FirstOrDefault(g => g.Name == "Spaghetti Western"));
                            break;

                        case "The Matrix":
                            genresForMovie.Add(genres.FirstOrDefault(g => g.Name == "Sci-Fi"));
                            genresForMovie.Add(genres.FirstOrDefault(g => g.Name == "Action"));
                            genresForMovie.Add(genres.FirstOrDefault(g => g.Name == "Thriller"));
                            break;

                        case "The Silence of the Lambs":
                            genresForMovie.Add(genres.FirstOrDefault(g => g.Name == "Thriller"));
                            genresForMovie.Add(genres.FirstOrDefault(g => g.Name == "Crime"));
                            genresForMovie.Add(genres.FirstOrDefault(g => g.Name == "Horror"));
                            break;

                        case "The Godfather":
                            genresForMovie.Add(genres.FirstOrDefault(g => g.Name == "Crime"));
                            genresForMovie.Add(genres.FirstOrDefault(g => g.Name == "Drama"));
                            break;

                        case "The Lion King":
                            genresForMovie.Add(genres.FirstOrDefault(g => g.Name == "Animated"));
                            genresForMovie.Add(genres.FirstOrDefault(g => g.Name == "Musical"));
                            genresForMovie.Add(genres.FirstOrDefault(g => g.Name == "Drama"));
                            break;
                    }

                    foreach (var genre in genresForMovie)
                    {
                        MovieGenres.Add(new MovieGenre
                        {
                            MovieId = m.Id,
                            GenreId = genre.Id
                        });
                    }

                }
                dataContext.AddRange(MovieGenres);
                dataContext.SaveChanges();

            }
        }
    }
}