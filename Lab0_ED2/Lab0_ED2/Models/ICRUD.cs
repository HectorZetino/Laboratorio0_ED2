using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab0_ED2.Models
{
    interface ICRUD
    {
        public void add(Movie movie);
        public List<Movie> ReturnList();
    }
}
