using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = [];
        _score = 0;
    }

    public void Start()
    {
        Console.Clear();
        int IntMenu = 0;
        while (IntMenu != 6)
        {
            Console.Clear();
            DisplayPlayerInfo();
            Menu.DisplayMenu();
            string menu = Console.ReadLine();

            if (!int.TryParse(menu, out IntMenu))
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
                continue;
            }

            switch (IntMenu)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid menu option. Please enter a number between 1 and 6.");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        string message = $"\nYou have {_score} points.\n";
        Console.WriteLine(message);
    }

    public void ListGoalNames()
    {
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetShortName()}");
            index++;
        }
    }

    public void ListGoalDetails()
    {
        int index = 1;
        Console.WriteLine("\nThe goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
        }
    }

    public void CreateGoal()
    {
        while (true)
        {
            Menu.GoalMenu();
            string choice = Console.ReadLine();
            if (!int.TryParse(choice, out int IntChoice))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                continue;
            }

            switch (IntChoice)
            {
                case 1:
                    CreateSimpleGoal();
                    return;
                case 2:
                    CreateEternalGoal();
                    return;
                case 3:
                    CreateCheckListGoal();
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid goal type.");
                    break;
            }
        }
    }

    private void CreateSimpleGoal()
    {
        string name = GetInput("What is the name of your goal? ");
        string description = GetInput("What is a short description of it? ");
        int points = GetIntInput("What is the amount of points associated with this goal? ");
        SimpleGoal simpleGoal = new(name, description, points, false);
        AddGoal(simpleGoal);
    }

    private void CreateEternalGoal()
    {
        string name = GetInput("What is the name of your goal? ");
        string description = GetInput("What is a short description of it? ");
        int points = GetIntInput("What is the amount of points associated with this goal? ");
        EternalGoal eternalGoal = new(name, description, points);
        AddGoal(eternalGoal);
    }

    private void CreateCheckListGoal()
    {
        string name = GetInput("What is the name of your goal? ");
        string description = GetInput("What is a short description of it? ");
        int points = GetIntInput("What is the amount of points associated with this goal? ");
        int target = GetIntInput("How many times does this goal need to be accomplished for a bonus? ");
        int bonus = GetIntInput("What is the bonus for accomplishing it that many times? ");
        CheckListGoal checkListGoal = new(name, description, points, 0, target, bonus);
        AddGoal(checkListGoal);
    }

    private string GetInput(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    private int GetIntInput(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (int.TryParse(input, out int value))
                return value;
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nNo goals registered.");
            return;
        }

        var uncompletedGoals = _goals.Where(goal => !goal.IsCompleted()).ToList();

        if (uncompletedGoals.Count == 0)
        {
            Console.WriteLine("\nAll goals have been completed.");
            return;
        }

        Console.WriteLine("\nThe uncompleted goals are:");
        for (int i = 0; i < uncompletedGoals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {uncompletedGoals[i].GetShortName()}");
        }

        Console.Write("\nWhich goal did you accomplish? ");
        string answer = Console.ReadLine();

        if (!int.TryParse(answer, out int choice) || choice < 1 || choice > uncompletedGoals.Count)
        {
            Console.WriteLine("Invalid input. Please enter a valid number corresponding to an uncompleted goal.");
            return;
        }

        Goal selectedGoal = uncompletedGoals[choice - 1];
        selectedGoal.RecordEvent();
        int earnedPoints = selectedGoal.GetPoint();
        string successMessage = $"Congratulations! You have earned {earnedPoints} points.";

        _score += earnedPoints;

        Console.WriteLine(successMessage);
        Console.WriteLine($"You now have {_score} points.");
        Thread.Sleep(1000);
    }


    private void ListUncompletedGoals()
    {
        int index = 1;
        Console.WriteLine("\nThe goals are:");
        foreach (Goal goal in _goals)
        {
            if (!goal.IsCompleted())
            {
                Console.WriteLine($"{index}. {goal.GetShortName()}");
                index++;
            }
        }
    }

    public void SaveGoals()
    {
        string fileName = GetInput("What is the filename for the goal file? ");
        string goalDirectory = Path.Combine(Directory.GetCurrentDirectory(), "GoalFiles");

        if (!Directory.Exists(goalDirectory))
        {
            Directory.CreateDirectory(goalDirectory);
        }

        string filePath = Path.Combine(goalDirectory, fileName);

        try
        {
            using StreamWriter streamWriter = new StreamWriter(filePath);
            streamWriter.WriteLine(GetScore().ToString());
            foreach (Goal goal in _goals)
            {
                streamWriter.WriteLine(goal.GetStringRepresentation());
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving goals: {ex.Message}");
        }
    }

    public async void LoadGoals()
    {
        string fileName = GetInput("What is the filename for the goal? ");
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "GoalFiles", fileName);

        try
        {
            using StreamReader streamReader = new StreamReader(filePath);
            string scoreLine = await streamReader.ReadLineAsync();
            int score = int.Parse(scoreLine);
            SetScore(score);

            string line;
            while ((line = await streamReader.ReadLineAsync()) != null)
            {
                try
                {
                    Goal goal = GoalFactory.CreateGoalFromString(line);
                    if (goal != null)
                    {
                        AddGoal(goal);
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error loading goal: {ex.Message}");
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. Please check the filename and try again.");
        }
        catch (FormatException)
        {
            Console.WriteLine("File format is incorrect. Please ensure the file is not corrupted.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading goals: {ex.Message}");
        }
    }


    private void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public int GetScore()
    {
        return _score;
    }

    public void SetScore(int score)
    {
        _score = score;
    }
}
