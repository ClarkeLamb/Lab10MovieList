using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10MovieList
{
    class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }

        public Movie()
        {

        }

        public Movie(string title, string category)
        {
            Category = category;
            Title = title;
        }

        
    }
}
