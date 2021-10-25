using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class Movie
    {
        //Properties
        public string Title { get; set; }
        public string Category { get; set; }
        public int Runtime { get; set; }

        
        //Comstructor
        public Movie(string Title, string Category, int Runtime)
        {
            this.Title = Title;
            this.Category = Category;
            this.Runtime = Runtime;
            
        }
        public virtual void PrintInfo()
        {
            Console.Write($"Title: {Title}");
            Console.Write($"Category: {Category}");
            Console.Write($"Runtime: {Runtime}");
        }

    }
}
