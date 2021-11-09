using System;

struct Record
{
  int rn;
  string name;
  string batch;  
  // We can not declare def const explictly
  // public Record() {}
  // We can only add 1 fully para const
  public Record(int rn, string name, string batch)
  {
    this.rn = rn;
    this.name= name;
    this.batch = batch;
  }
  public void Get() {}
  public void Display() {}
} 
// Inheritance Not Allowed 
// struct Rec1 : Record
// {

// }



struct Address
{
  public string houseNo;
  string city;
  string state;
  public void GetAddress(){
    Console.WriteLine("Enter House No:");
    houseNo = Console.ReadLine();
    Console.WriteLine("Enter City:");
    city = Console.ReadLine();
    Console.WriteLine("Enter State:");
    state = Console.ReadLine();
    

  }
   public void DisplayAddress(){
    Console.WriteLine("House No: " + houseNo);
    
    Console.WriteLine("City: " + city);
     
    Console.WriteLine("State: " + state);
   
    

  }
} 
struct DOB
{
  int dd;
  int mm;
  int yy;
}

class Employee
{
   int id;
   string name;
  //  public static string Department;
   static string department;
   int salary;
   public const string companyName="CTS";
   Address address;
   // Def Const

   public Employee() {
     Console.WriteLine("Inside Def Cons");
   }
   // Para Const
   public Employee(string x)
   {
            name = x;
            Console.WriteLine("Enter ID");
            id= Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Salary");
            salary = Convert.ToInt16(Console.ReadLine());
}
// Para Const
public Employee(int id, string name)
   {
            this.name = name;
            this.id=id;
            Console.WriteLine("Enter Salary");
            salary = Convert.ToInt16(Console.ReadLine());
}
// Para Const
public Employee(int id, string name, int salary)
   {
            this.name = name;
            this.id=id;
            this.salary = salary;
}
// Static const , this will be always invoked first before any other
// const
 static Employee()
{
  Console.WriteLine("Inside Static Cons");
  department ="HR";
  Console.WriteLine("Department is " + department);
}
// Copy Const
public Employee(Employee obj)
{ 
  Console.WriteLine("Enter ID");    
  id= Convert.ToByte(Console.ReadLine());        id= Convert.ToByte(Console.ReadLine());
  this.name = obj.name;
  this.salary = obj.salary;

}
   public  void GetDetails()
        {
            Console.WriteLine("Enter ID");
            id= Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            // Console.WriteLine("Enter Department");
            // department = Console.ReadLine();
            Console.WriteLine("Enter Salary");
            salary = Convert.ToInt16(Console.ReadLine());
            // Console.WriteLine("Enter House No");
            // address.houseNo= Console.ReadLine();
            address.GetAddress();

}
public void DisplayDetails()
 {
Console.WriteLine("ID is " + id);
Console.WriteLine("Name is " + name);
//Console.WriteLine("Department is " + department);
Console.WriteLine("Salary is " + salary);
address.DisplayAddress();
 }
//  public static void DepartmentDetails()
//  {
//    department = "HR";
//    Console.WriteLine("Department is " + department);
//   //  department="Accounts";
//  }
}