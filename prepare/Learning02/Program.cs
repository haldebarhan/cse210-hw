using System;


class Program
{
    static void Main(string[] args)
    {
        Job job1 = new()
        {
            _jobTitle = "MySQL Database Administrator",
            _startYear = 2021,
            _endYear = 2022,
            _company = "Fiverr"
        };
        
        Job job2 = new()
        {
            _jobTitle = "Peer Mentor",
            _startYear = 2023,
            _endYear = 2024,
            _company = "Indépendant",
        };

         Job job3 = new()
        {
            _jobTitle = "Data Entry Specialist",
            _startYear = 2023,
            _endYear = 2024,
            _company = "Randstad",
        };

        Resume myResume = new()
        {
            _firstNmae = "ENO-OBONG",
            _lastName = "BASSEY"
        };
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.Display();

    }
}