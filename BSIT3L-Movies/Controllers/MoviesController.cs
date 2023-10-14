using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT3L_Movies.Controllers
{
    public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;
        public MoviesController()
        {
            // Sample movie data
            _movies = new List<MovieViewModel>
            {
               new MovieViewModel { Id = "m001", Name = "Harry Potter and the Sorcerer's Stone", Rating = "5",
                                  ReleaseYear = 2001, Genre = "Fantasy/Adventure",
                                  ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSxlN5yVLJnpmTyOp33mZ7PRtTs9KqiKmq2pOczXX0Qu_E4SrTY",
                                  VideoPath = "https://www.youtube.com/embed/VyHV0BRtdxo"
                                },
                new MovieViewModel { Id = "m002", Name = "Harry Potter and the Chamber of Secrets", Rating = "5",
                                  ReleaseYear = 2002, Genre = "Fantasy/Adventure",
                                  ImagePath = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcTpkgj31iRGBdS2yBDvl4-nWmbF7Sc4Z4uFRoP_YZVG7T4GIrLx",
                                  VideoPath = "https://www.youtube.com/embed/jBltxS8HfQ4"
                                },
                new MovieViewModel { Id = "m003", Name = "Harry Potter and the Prisoner of Azkaban", Rating = "5",
                                  ReleaseYear = 2004, Genre = "Fantasy/Adventure",
                                  ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRoVE7MY1WkgVRt7XrpAO2yqeL61jKIlYik55ItE52CPmAC_M-c",
                                  VideoPath = "https://www.youtube.com/embed/cK2WNlj6kR0"
                                },
                new MovieViewModel { Id = "m004", Name = "Harry Potter and the Goblet of Fire", Rating = "5",
                                  ReleaseYear = 2005, Genre = "Fantasy/Adventure",
                                  ImagePath = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSpyPxfXJB-bokcJy1aeK8C32dtl0rkhpxntY4SnP26gKRKISOk",
                                  VideoPath = "https://www.youtube.com/embed/3EGojp4Hh6I"
                                },
                new MovieViewModel { Id = "m005", Name = "Harry Potter and the Order of the Phoenix", Rating = "5",
                                  ReleaseYear = 2007, Genre = "Fantasy/Adventure",
                                  ImagePath = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcTGGk9fT6nQdRi-MwCIC-Pq89heCBopZzKYz3BRZCN-9OqRjHk3",
                                  VideoPath = "https://www.youtube.com/embed/y6ZW7KXaXYk"
                                },
                new MovieViewModel { Id = "m006", Name = "Harry Potter and the Half-Blood Prince", Rating = "5",
                                  ReleaseYear = 2009, Genre = "Fantasy/Adventure",
                                  ImagePath = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcT8rEXSQzO-tAmBOUa8d6mEmVIzjfs9yVk395oWKJIiPqEz3r_d",
                                  VideoPath = "https://www.youtube.com/embed/tAiy66Xrsz4"
                                },
                new MovieViewModel { Id = "m007", Name = "Harry Potter and the Deathly Hallows: Part 1", Rating = "5",
                                  ReleaseYear = 2010, Genre = "Fantasy/Adventure",
                                  ImagePath = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcTiIfZgl_jB63P1PCk-c3zNoQTIzGoiTogKpytW0PwWfm2nrk95",
                                  VideoPath = "https://www.youtube.com/embed/MxqsmsA8y5k"},
                new MovieViewModel { Id = "m008", Name = "Harry Potter and the Deathly Hallows: Part 2", Rating = "5",
                                  ReleaseYear = 2011, Genre = "Fantasy/Adventure",
                                  ImagePath = "https://images.moviesanywhere.com/5f0537520f90b687fc5db7f241affc4c/842c4e03-abee-4260-a170-bff52e63519a.jpg",
                                  VideoPath = "https://www.youtube.com/embed/5NYt1qirBWg"
                                },
                new MovieViewModel { Id = "m009", Name = "Bridge to Terabithia", Rating = "4",
                                  ReleaseYear = 2007, Genre = "Fantasy/Family",
                                  ImagePath = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcRRVCjX7DPs32EEZeGrADLkpTilzhRn901m6Insg-xWOh-5KpTV",
                                  VideoPath = "https://www.youtube.com/embed/Vw24BAojSSg"
                                },
                new MovieViewModel { Id = "m010", Name = "Charlie and the Chocolate Factory", Rating = "4",
                                  ReleaseYear = 2005, Genre = "Fantasy/Family",
                                  ImagePath = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcS54UAnGGhyyPWrueoXbEhOzIS80yBmpGTHfT_aYsaG9MBtfrBZ",
                                  VideoPath = "https://www.youtube.com/embed/OFVGCUIXJls"
                                },
                new MovieViewModel { Id = "m011", Name = "E.T. the Extra Terrestrial", Rating = "4",
                                  ReleaseYear = 1982, Genre = "Sci-fi/Adventure",
                                  ImagePath = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcR_ToPnFwDIkDGsPeTY0KuOVrzBp2Px-iqv-uFkjiGK6HZnXvt9",
                                  VideoPath = "https://www.youtube.com/embed/qYAETtIIClk"
                                },
                new MovieViewModel { Id = "m012", Name = "Elf", Rating = "3",
                                  ReleaseYear = 2003, Genre = "Comedy/Family",
                                  ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTJlfRkUpq8zmLa3gPXe-gUyPE8KXUpGSRgUj3rO4IEAj_Qi70M",
                                  VideoPath = "https://www.youtube.com/embed/a54yC1etmVc"
                                },
                new MovieViewModel { Id = "m013", Name = "Nanny McPhee", Rating = "4",
                                  ReleaseYear = 2005, Genre = "Comedy/Family",
                                  ImagePath = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcQogo5qTI-BydKWU9UBviF3EWN_CHf0CD5LydtDMKReXGgirkdG",
                                  VideoPath = "https://www.youtube.com/embed/4iCRftNMwC4"
                                },
                new MovieViewModel { Id = "m014", Name = "Nanny McPhee Returns", Rating = "4",
                                  ReleaseYear = 2010, Genre = "Comedy/Family",
                                  ImagePath = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcTmnoODRdSUsuYbfmZObwk_ic5AvCLsCT2xjw2BPS-J_OT5rdck",
                                  VideoPath = "https://www.youtube.com/embed/54xMw6eouOM"
                                },
                new MovieViewModel { Id = "m015", Name = "Tomb Raider", Rating = "3",
                                  ReleaseYear = 2018, Genre = "Action",
                                  ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSUJryZypKbxjobGGSdOu86Vg_mRLZ6--8oOjmF3XgrYEywGdVL",
                                  VideoPath = "https://www.youtube.com/embed/3KkhD0MnaJU"
                                },
            };
        }
        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", Rating = "5" };
            return View(movie);
        }
        public ActionResult GetMovie(string id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);

        }

    }
}