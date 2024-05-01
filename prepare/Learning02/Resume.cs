public class Resume {

    public string _firstNmae;
    public string _lastName;
    public List<Job> _jobs = [];


    public void Display(){
        Console.WriteLine($"{_firstNmae} {_lastName}");
        Console.WriteLine("Jobs:");
        foreach(Job job in _jobs){
            job.DisplayJobDetails();
        }
    }


}