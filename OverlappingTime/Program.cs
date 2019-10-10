using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverlappingTime
{
    class Program
    {

        static public bool CanViewAll(Movie[] movies)
        {

            for (int i = 0; i < movies.Count() - 1; i++)
            {
                for (int j = i + 1; j < movies.Count(); j++)
                {
                    if (movies[i].Start < movies[j].End && movies[j].Start < movies[i].End)
                        return false;
                }
            }
            return true;
        }
        
        static void Main(string[] args)
        {

            var format = System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat;

            Movie[] movies = new Movie[]
            {
                //overlapping example:
                new Movie(DateTime.Parse("1/1/2015 20:10", format), DateTime.Parse("1/1/2015 22:30", format)),
                
                //these are not overlapping:
                new Movie(DateTime.Parse("1/1/2015 20:00", format), DateTime.Parse("1/1/2015 21:30", format)),
                new Movie(DateTime.Parse("1/1/2015 23:10", format), DateTime.Parse("1/1/2015 23:30", format)),
                new Movie(DateTime.Parse("1/1/2015 21:30", format), DateTime.Parse("1/1/2015 23:00", format))
            };
            
            Console.WriteLine("Can I view all movies? " + CanViewAll(movies));
            
            Console.ReadKey();
            
        }
    }
}
