using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab0_ED2.Models
{
    public interface ICRUD
    {
        public void Add(Movie movie);
        public List<Movie> ReturnList();
    }
}
