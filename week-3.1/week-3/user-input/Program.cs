/*
string fname = "";
double height = 0;
double weight = 0.0d;
double BMI = 0.0d;


Console.Write("input first name : "); //display
fname = Console.ReadLine();        //input keyboard

Console.Write("input height : "); //display
height = double.Parse(Console.ReadLine());     //input keyboard

Console.Write("input weight : "); //display
weight = double.Parse(Console.ReadLine());    //input keyboard

BMI = height/weight;

BMI = Math.Pow(BMI, 2);


Console.WriteLine("BMI is : "+BMI); //หาค่าดัชนี มวลกาย
*/


string prefix = "";
string fname = "";
string lname = "";
int id = 0;
double height = 0d;
double weight = 0.0d;
double BMI = 0.0d;


Console.Write("prefix : "); //display
prefix = Console.ReadLine();        //input keyboard

Console.Write(" first name : "); //display
fname = Console.ReadLine();        //input keyboard

Console.Write("last name : "); //display
lname = Console.ReadLine();     //input keyboard

Console.Write("student id : "); //display
id = Int32.Parse(Console.ReadLine());     //input keyboard

Console.Write("input height : "); //display
height = double.Parse(Console.ReadLine());     //input keyboard

Console.Write("input weight : "); //display
weight = double.Parse(Console.ReadLine());    //input keyboard

BMI = height/weight;

BMI = Math.Pow(BMI, 2);


Console.WriteLine("******************** "); //display
Console.WriteLine("Student ID is "+id ); //display
Console.WriteLine("fullname : "+prefix+" "+fname+" "+lname ); //display
Console.WriteLine("your height :"+height); //display
Console.WriteLine("your weight :"+weight); //display
Console.WriteLine("BMI is : "+BMI); //display
Console.WriteLine("******************** "); //display









