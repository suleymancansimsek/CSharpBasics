using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Movie
    {
        public string title;
        public string director;
        public string[] rateTypes = new string[] {"G", "PG" , "PG-13", "R", "NR"};
        private string rating;
        public static int movieCount = 0;
        public Movie(string aTitle, string aDirector, string aRating)
        {
            title= aTitle;
            director= aDirector;    
            Rating= aRating;
            movieCount++;
        }

        public string Rating
        {
            get { return rating; }
            set
            {
                if (rateTypes.Contains(value))
                {
                    rating= value;
                } else rating = "NR";
            }
        }
    }
}
