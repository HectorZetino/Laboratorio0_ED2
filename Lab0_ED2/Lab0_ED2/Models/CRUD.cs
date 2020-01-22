using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab0_ED2.Models
{
    public class CRUD : ICRUD
    {
        public List<Movie> Movies = new List<Movie>();
        public List<Movie> MoviesComodin = new List<Movie>();
        
        public void Add(Movie New_Movie) {
            if (Movies.Count <=9)
            {
                Movies.Add(New_Movie);
            }
            else
            {
                MoviesComodin.Add(New_Movie);
            }
        
        }

        public List<Movie> ReturnList() {
            Movies.Reverse();
            return Movies;

        }


    }
}
