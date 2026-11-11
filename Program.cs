using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleOnly
{
    public enum MenuOption
    {
        AddCharacter = 1,
        DisplayCharacters,
        AddMission,
        DisplayMissions,
        AddThreat,
        StartOperations,
        Exit
    }
    internal class Program
    {
        static List<Character> characters = new List<Character>();
        static List<Mission> missions = new List<Mission>();
        static List<Threat> threats = new List<Threat>();


        static void Main(string[] args)
        {
            LoadInitialData();

            MenuOption choice;

            do
            {
                Console.WriteLine("\n================================");
                Console.WriteLine("    MIDDLE-EARTH OPERATIONS");
                Console.WriteLine("================================");
                Console.WriteLine("1. Add Character");
                Console.WriteLine("2. Display Characters");
                Console.WriteLine("3. Add Mission");
                Console.WriteLine("4. Display Missions");
                Console.WriteLine("5. Add Threat");
                Console.WriteLine("6. Start Operations");
                Console.WriteLine("7. Exit");
                Console.Write("\nSelect an option: ");

                choice = (MenuOption)Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case MenuOption.AddCharacter:
                        AddCharacter();
                        break;

                    case MenuOption.DisplayCharacters:
                        DisplayCharacters();
                        break;

                    case MenuOption.AddMission:
                        AddMission();
                        break;

                    case MenuOption.DisplayMissions:
                        DisplayMissions();
                        break;

                    case MenuOption.AddThreat:
                        AddThreat();
                        break;

                    case MenuOption.StartOperations:
                        StartOperations();
                        break;
                }

            } while (choice != MenuOption.Exit);
        }

        static void LoadInitialData()
        {
            characters.Add(
                new Aragorn(1, "Aragorn", 87, 95, "Anduril"));

            characters.Add(
                new Gandalf(2, "Gandalf", 2019, 100, "White Staff"));

            characters.Add(
                new Legolas(3, "Legolas", 2931, 90, "Elven Bow"));

            characters.Add(
                new Gollum(4, "Gollum", 589, 50, "Misty Mountains"));

            SearchMission searchMission = new SearchMission();
            searchMission.MissionID = 1;
            searchMission.Name = "Find Gollum";
            searchMission.Location = "Mordor";
            searchMission.DangerLevel = 9;

            missions.Add(searchMission);
        }

        static void AddCharacter()
        {
            characters.Add(
                new Aragorn(5, "Boromir", 41, 85, "Sword"));

            Console.WriteLine("Character added.");
        }

        static void DisplayCharacters()
        {
            foreach (Character character in characters)
            {
                Console.WriteLine(
                    $"ID:{character.CharacterID} Name:{character.Name}");

                character.PerformAction();
            }
        }

        static void AddMission()
        {
            RescueMission mission = new RescueMission();

            mission.MissionID = missions.Count + 1;
            mission.Name = "Rescue Merry";
            mission.Location = "Isengard";
            mission.DangerLevel = 7;

            missions.Add(mission);

            Console.WriteLine("Mission added.");
        }

        static void DisplayMissions()
        {
            foreach (Mission mission in missions)
            {
                Console.WriteLine(
                    $"{mission.MissionID} - {mission.Name} - {mission.Location}");
            }
        }

        static void AddThreat()
        {
            try
            {
                threats.Add(
                    new Threat(
                        threats.Count + 1,
                        "Nazgul",
                        "Mordor",
                        10));

                Console.WriteLine("Threat added.");
            }
            catch (InvalidThreatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void StartOperations()
        {
            Thread t1 = new Thread(() =>
                Operations.RunOperation(
                    "Aragorn",
                    "Searching the forest"));

            Thread t2 = new Thread(() =>
                Operations.RunOperation(
                    "Legolas",
                    "Scouting the mountains"));

            Thread t3 = new Thread(() =>
                Operations.RunOperation(
                    "Gandalf",
                    "Investigating an ancient ruin"));

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();
        }
    }
}
