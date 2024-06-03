using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Lecture lectureActivity = new("Think-pair-repair", "In this twist on think-pair-share, pose an open-ended question to your class and ask students to come up with their best answer.",
         "06/06/2024", "10:30 AM", "4 Pennsylvania Plaza, New York, NY 10001, United States", "Tony Robbins", 500);

        Reception receptionActivity = new("Fundraising for the Homeless", "fundraising organized for the construction of a shelter for the homeless", "22/06/2024",
         "07:30 PM", "101 E Viking St, Rexburg, ID 83460, United States", "booking@lds.org");

        OutdoorGathering outdoorGatheringActivity = new("Bicycle Relaxation", "The aim of this activity is to help cycling enthusiasts", "23/07/2024", "8H00 AM", "New York, NY, USA", "Clear with periodic clouds");

        
        lectureActivity.FullDetails();
        receptionActivity.FullDetails();
        outdoorGatheringActivity.FullDetails();
    }
}