using System;

//classes for q1 from line 4 to 80
public class Department
{

    public const string ComputerScience = "Computer Science";
    public const string ElectricalEngineering = "Electrical Engineering";
    public const string BusinessAdministration = "Business Administration";
    public const string MechanicalEngineering = "Mechanical Engineering";
}

public class Person
{

    private string name;


    public string Name
    {
        get { return name; }
        set { name = value; }
    }

 
    public Person()
    {
        name = null; 
    }


    public Person(string name)
    {
        this.name = name;
    }
}

public class Student : Person
{

    private string regNo;
    private int age;
    private string program;

    public string RegNo
    {
        get { return regNo; }
        set { regNo = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Program
    {
        get { return program; }
        set { program = value; }
    }

  
    public Student() 
    {
        Name = null;   
        regNo = null;  
        age = 0;       
        program = null; 
    }


    public Student(string name, string regNo, int age, string program)
    {
        Name = name;    
        this.regNo = regNo;
        this.age = age;
        this.program = program;
    }
}
//classes for q1 ends here
//classes for q2 ....
public class Customer
{

    public int CustomerId { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

public class RetailCustomer : Customer
{
    public string CreditCardType { get; set; }
    public string CreditCardNo { get; set; }
}

public class CorporateCustomer : Customer
{
    // Additional properties for CorporateCustomer
    public string CompanyName { get; set; }
    public int FrequentFlyerPts { get; set; }
    public string BillingAccountNo { get; set; }
}

public class Reservation
{
    public int ReservationNo { get; set; }
    public DateTime Date { get; set; }
    public List<Seat> ReservedSeats { get; set; } = new List<Seat>();
}

public class Flight
{
  
    public int FlightId { get; set; }
    public DateTime Date { get; set; }
    public string Origin { get; set; }
    public string Destination { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public int SeatingCapacity { get; set; }

    public List<Seat> Seats { get; set; } = new List<Seat>();
}

public class Seat
{

    public int RowNo { get; set; }
    public int SeatNo { get; set; }
    public decimal Price { get; set; }
    public string Status { get; set; }  
}
///////////////////////////////////////
class Program
{
    static void Main(string[] args)
    {
        q1();
        q2();
    }
    static void q1()
    {
        Console.WriteLine("Q1");
        Student student1 = new Student();
        student1.Name = "Ali";
        student1.RegNo = "CS123";
        student1.Age = 19;
        student1.Program = Department.ComputerScience;

        Console.WriteLine($"Student1: {student1.Name}, {student1.RegNo}, {student1.Age}, {student1.Program}");
        Student student2 = new Student("Zain", "EE456", 21, Department.ElectricalEngineering);
        Console.WriteLine($"Student2: {student2.Name}, {student2.RegNo}, {student2.Age}, {student2.Program}");

    }
    static void q2()
    {
        Console.WriteLine("\n\nQ2");
        RetailCustomer retailCustomer = new RetailCustomer
        {
            CustomerId = 1,
            FirstName = "Zain",
            LastName = "Ali",
            CreditCardType = "Visa",
            CreditCardNo = "1234-5678-9012-3456"
        };

     
        Flight flight = new Flight
        {
            FlightId = 101,
            Origin = "Multan",
            Destination = "Lahore",
            Date = DateTime.Now,
            DepartureTime = DateTime.Now.AddHours(2),
            ArrivalTime = DateTime.Now.AddHours(5),
            SeatingCapacity = 200
        };

        flight.Seats.Add(new Seat { RowNo = 1, SeatNo = 1, Price = 100.50m, Status = "Available" });
        flight.Seats.Add(new Seat { RowNo = 1, SeatNo = 2, Price = 100.50m, Status = "Available" });

        Reservation reservation = new Reservation
        {
            ReservationNo = 5001,
            Date = DateTime.Now
        };
        reservation.ReservedSeats.Add(flight.Seats[0]); 

        Console.WriteLine($"Customer {retailCustomer.FirstName} {retailCustomer.LastName} made a reservation.");
        Console.WriteLine($"Flight from {flight.Origin} to {flight.Destination} on {flight.Date.ToShortDateString()}.");
        Console.WriteLine($"Reserved seat: Row {reservation.ReservedSeats[0].RowNo}, Seat {reservation.ReservedSeats[0].SeatNo}.");

    }
}

