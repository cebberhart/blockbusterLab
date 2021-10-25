using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class BlockbusterDb
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();
        public List<string> Category { get; set; } = new List<string>();
        
        public BlockbusterDb()
        {
            Movies.Add(new Movie("Star Wars: the good one", ""));
            Movies.Add(new Movie("Duck Tales"));
            Movies.Add(new Movie("Whatever Marvel Nonsense"));
            Movies.Add(new Movie("Saving Private Ryan"));
            Movies.Add(new Movie("Duck Tales 2: Zack Quack has a bad day"));
            Movies.Add(new Movie("Dora The Explora: Swiper, yes Swiping"));
            Category.Add("Drama");
            Category.Add("Comedy");
            Category.Add("Horror");
            Category.Add("Romance");
            Category.Add("Action");
        }
        
        public List<Movie> GetMoviesCategory(string category)
        {
            List<Movie> output = new List<Movie>();
        }
        
        public void PrintScenes()
        {

        }
    }
}
