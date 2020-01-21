using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab0_ED2.Models
{
    public class CRUD : ICRUD
    {
        public List<Movie> Movies = new List<Movie>();
        
        public void Add(Movie New_Movie) {
            
            Movies.Add(New_Movie);
        
        }

        public List<Movie> ReturnList() {
            return Movies;

        }


    }
}
