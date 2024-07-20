using System;
using System.Collections.Generic;
using System.Linq;

namespace GoalApp
{
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;


        public GoalManager()
        {
            _goals = new List<Goal>();

        }

        public void Start()
        {
            bool quit = false;
            while (!quit)
            {
                Console.Clear();
                Console.WriteLine("Menu Options: ");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");
                Console.Write("Select a choice from the menu");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        CreateGoal();
                        break;
                    case "2":
                        ListGoalNames();
                        break;
                    case "3":
                        SaveGoals();
                        break;
                    case "4":
                        LoadGoals();
                        break;
                    case "5":    
                        RecordEvent();
                        break;
                    case "6":
                        quit = true;
                        Console.WriteLine("Quitting the program...");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        Console.WriteLine("Press any key to return to the main menu");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public void DisplayPlayerInfo()
        {
            Console.WriteLine($"You have {_score} points");


        }

        public void ListGoalNames()
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                ListSimpleGoals();
                break;
                case "2":
                ListEternalGoals();
                break;
                case "3":
                ListChecklistGoals();
                break;
                default:
                Console.WriteLine("Invalid option. Please try again");
                break;
            }

        }

        private void ListSimpleGoals()
        {
            foreach (var goal in _goals.Where(g => g is SimpleGoal))
            {
                Console.WriteLine(goal.Name);
            }
        }

        private void ListEternalGoals()
        {
            foreach (var goal in _goals.Where(g => g is EternalGoal))
            {
                Console.WriteLine(goal.Name);
            }
        }

        private void ListChecklistGoals()
        {
            foreach (var goal in _goals.Where(g => g is ChecklistGoal))
            {
                Console.WriteLine(goal.Name);
            }
        }

        public void CreateGoal()
        {
            Console.WriteLine("Which type of goal would you like to create? ");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                CreateSimpleGoal();
                break;
                case "2":
                CreateEternalGoal();
                break;
                case "3":
                CreateChecklistGoal();
                break;
                default:
                Console.WriteLine("Invalid option. Please try again");
                break;
            }
        }    

        private void CreateSimpleGoal()
        {
            Console.Write("What is the name of your goal? ");  
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal? "); 
            int points = int.Parse(Console.ReadLine()); 
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new SimpleGoal(name, description, points, target, bonus));
        }
    
        private void CreateEternalGoal()
        {
           Console.Write("What is the name of your goal? ");  
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal? "); 
            int points = int.Parse(Console.ReadLine()); 
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new EternalGoal(name, description, points, target, bonus)); 
        }  

        private void CreateChecklistGoal()
        {
            Console.Write("What is the name of your goal? ");  
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description of it? ");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal? "); 
            int points = int.Parse(Console.ReadLine()); 
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        } 
        public void RecordEvent()
        {
            Console.WriteLine();

        }

        public void SaveGoals()
        {

        }

        public void LoadGoals()
        {

        }
    }
}        






