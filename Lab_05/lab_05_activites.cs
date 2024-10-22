using System;

public class WorkItem
{//----activity 3 ---
    private static int currentId;
    protected int id { get; set; }
    protected string Title { get; set; }
    protected String Description { get; set; }

    protected TimeSpan jobLength { get; set; }

    public WorkItem() 
    {
        id = 0;
        Title = "Default Title";
        Description = "Default description";
        jobLength = new TimeSpan(1);
    }
    public WorkItem(string title, string desc, TimeSpan joblen)
    {
        this.id = GetNextId();
        this.Title = title;
        this.Description = desc;
        this.jobLength = joblen;
    }
    static WorkItem()
    {
        currentId = 0;
    }
    protected int GetNextId()
    {
        return ++currentId;
    }

    public void Update(string Title, TimeSpan joblen)
    {
        this.Title = Title;
        this.jobLength = joblen;
    }
    public override string ToString()
    {
        return string.Format("{0}-{1}", this.id, this.Title);
    }

}
public class ChangeRequest : WorkItem
{
    protected int originalItemId { get; set; }
    public ChangeRequest() { }

    public ChangeRequest(string Title, string Desc, TimeSpan joblen, int originalId)
    {
        this.id = GetNextId();
        this.Title = Title;
        this.Description = Desc;
        this.jobLength = joblen;

    }
    public ChangeRequest(int originalItemId)
    {
        this.originalItemId = originalItemId;
    }
}
//-----classes ends here of activity 3---//
    class Program
{
    static void Main(string[] args)
    {
        activity1();
        activity2();
        activity3();    
    }
    static void activity1()
    {
        Console.WriteLine("Activity 1: ");
        double a = 9.8, b = 0;
        double result = 0;
        try
        {
            result = safeDivision(a, b);
            Console.WriteLine($"{a}/{b} ={result}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Attempted divided by zero");
        }

    }
    static double safeDivision(double a, double b)
    {
        if (b == 0)
        {
            throw new System.DivideByZeroException();
            
        }
        else
        {
            return a / b;   
        }
    }
    static void activity2()
    {
        Console.WriteLine("Activity 2");
        System.IO.StreamWriter sw = null;
        try
        {
            sw = new System.IO.StreamWriter("C:\\Users\\zain\\Desktop\\visualProgramming\\Lab 05\\test.txt");
            sw.WriteLine("Hellow");

        }
        catch (System.IO.FileNotFoundException ex)
        {
            Console.WriteLine(ex.ToString());
        }
        catch (System.IO.IOException ex)
        {
            Console.WriteLine(ex.ToString());

        }
        finally
        {
            sw.Close();
        }
        Console.WriteLine("Done");

    }
    static void activity3()
    {
        Console.WriteLine("Activity 3 : ");
        WorkItem item = new WorkItem("Fix bugs","Fix all codes bugs in my branch ",new TimeSpan(4,0,0));
        
        ChangeRequest change =new ChangeRequest("change base class design ","Add member to class",new TimeSpan(4,0,0),1);
        Console.WriteLine(item.ToString());
        change.Update("change the design of base class ",new TimeSpan(4,0,0));
        Console.WriteLine(item.ToString());
        change.Update("Change the design to base class",new TimeSpan(4,0,0));
        Console.WriteLine(item.ToString());


    }

   

}

