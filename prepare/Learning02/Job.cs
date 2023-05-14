// create the Job class
public class Job {
    
    public string _jobTitle;
    public string _company;
    public int _Year;
    public int _EndYear;
    
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_Year} - {_EndYear}");
    }
    //public Job(){

}
