public class Resume{
    public string _name;
    //create a new list class jobs
    public List<Job> _jobs = new List<Job>(); //ask the group about this.

    public void Display(){
         Console.WriteLine($"Name: {_name}");
         Console.WriteLine("Jobs:");
       
          foreach (Job job in _jobs)
         {
            job.Display();
         }

    }

}
