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
