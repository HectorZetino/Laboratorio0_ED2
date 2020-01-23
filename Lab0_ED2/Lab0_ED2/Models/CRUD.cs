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
                MoviesComodin.Add(Movies.ElementAt<Movie>(0));//los elementos que salen de Movies se agregan en la MoviesComodin, para no perder el valor.
                Movies.RemoveAt(0);
                Movies.Add(New_Movie);
            }
        
        }

        public List<Movie> ReturnList() {
            Movies.Reverse();//se mostraran primero los datos que se ingresaron de ultimo
            return Movies;

        }


    }
}
