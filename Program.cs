using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowledgeCheck2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many sport teams do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());
          

            var recordList = new List<SportsTeam>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var entry = new SportsTeam();

                Console.WriteLine("Enter the type of sport.");
                entry.TypeOfSport = Console.ReadLine().ToUpper();

                Console.WriteLine("Enter the name of the team.");
                entry.TeamName = Console.ReadLine().ToUpper();

                Console.WriteLine("Enter the city the team is based in.");
                entry.TeamCity = Console.ReadLine().ToUpper();

                Console.WriteLine("Enter the state the team is based in.");
                entry.TeamState = Console.ReadLine().ToUpper();


                recordList.Add(new SportsTeam() { TypeOfSport = entry.TypeOfSport, TeamName = entry.TeamName, TeamCity = entry.TeamCity, TeamState = entry.TeamState });
            }

            // Print out the list of records using Console.WriteLine()

            foreach (var entry in recordList)
                Console.WriteLine("\nType of Sport: " + entry.TypeOfSport + "\nTeam Name: "+ entry.TeamName + "\nCity: " + entry.TeamCity + "\nState: " + entry.TeamState);

           
        }
    }
}
