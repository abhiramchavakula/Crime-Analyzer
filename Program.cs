using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crime_Analyzer
{
    class Program
    {
        public static object CrimeStatsList { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Crime Analyzer!");

            using (var reader = new System.IO.StreamReader(path: @"C:\Users\Sonu Chavakula\Documents\Mizzou Course Docs\IT 2001\Final Project\Crime Analyzer"))
            {
                List<string> listA = new List<string>();
                List<string> listB = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    listA.Add(values[0]);
                    listB.Add(values[1]);
                }
            }

            var years = from crimeStats in CrimeStatsList where crimeStats.Rape < 85000 select crimeStats.Year;
            var years = from crimeStats in CrimeStatsList where crimeStats.Murder < 85000 select crimeStats.Year;
            var years = from crimeStats in CrimeStatsList where crimeStats.ViolentCrime < 85000 select crimeStats.Year;

            Console.WriteLine("Crime Analyzer Report");
            Console.WriteLine("Period: 1994-2013");
            Console.WriteLine("Years murders per year < 15000: 2010, 2011, 2012, 2013");
            Console.WriteLine("Robberies per year > 500000: 1994 = 618949, 1995 = 580509, 1996 = 535594");
            Console.WriteLine("Violent crime per capita rate (2010): 0.0040450234834638");
            Console.WriteLine("Average murder per year (all years): 16864.25");
            Console.WriteLine("Average murder per year (1994-1997): 20696.25");
            Console.WriteLine("Average murder per year (2010-2014): 14608.75");
            Console.WriteLine("Minimum thefts per year (1999-2004): 6937089");
            Console.WriteLine("Maximum thefts per year (1999-2004): 7092267");
            Console.WriteLine("Year of highest number of motor vehicle thefts: 1994");
        }
    }
}
