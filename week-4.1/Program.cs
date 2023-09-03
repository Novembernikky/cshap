// plus+
/*
int plus1 = 2;
int plus2 = 3;
int total;

total = plus1+plus2;

Console.Write(total);
*/


//plus-
/*
int minus1 = 4;
int minus2 = 2;
int total = minus1-minus2;

Console.Write(total);
*/

//modulus
/*
int modul1 = 10;
int modul2 = 4;
int total = modul1 % modul2;

Console.Write(total);
*/

//plus++
/*
int plus = 0;
int total = 0;

plus++;
total = plus;

Console.Write(total);
*/

//minus--
/*
int minus_down = 10;
int total = 0;

minus_down--;
total = minus_down;

Console.Write(total);
*/

//math ฟังก์ชันทางคณิตศาสตร์

/*
int min = Math.min(4,4);
Console.WriteLine(min);

int max = Math.Max(7,8);
Console.Write(max);
*/

//
/*
string hello = "Hello"; 
string world = "World";

Console.WriteLine(hello+" "+world);
*/

/*
bool val = false;
bool check = false;

Console.WriteLine(val==check);
*/



//if else
/*
int input = 3;

Console.Write("input value");
input = Int32.Parse(Console.ReadLine());

if(input == 2){
Console.WriteLine("true success");
}
else if(input == 3){
Console.WriteLine("Yes this is 3 value success");   
}

else if(input == 4){
Console.WriteLine("Yes this is 4 value success"); 
}

else if(input == 5){
Console.WriteLine("Yes this is 5 value success"); 
}

else if(input == 6 || input == 12){
Console.WriteLine("Yes this is 6 or 12 value success"); 
}

else{
Console.WriteLine("False Value Check"); 
}
*/


//switch
/*
int day = 10;
switch (day) 
{
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  case 7:
    Console.WriteLine("Sunday");
    break;

    default:
    Console.WriteLine("Cannot found");
    break;
}
// Outputs "Thursday" (day 4)
*/

//
/*
string[] cars = {
        "Volvo", "BMW", "Ford", "Mazda",  
        "Honda", "Toyota", "Misubishi", "Nissan"
};

string[] colors = {
        "Red", "Green", "Blue", "Black",  
        "White", "Cyan", "Yellow", "Dark"
};

int i = 0;
int seq = 1;
while (i < 8) 
{
   
  seq++;
  Console.WriteLine(seq+"."+cars[i]+"colors is "+colors[i]);
  i++;

}
*/
string[] prefix = {
    "Mr.", "Mrs.", "Mr.", "Mr.", "Mrs.","Mr.","Mr","Mr"
};
string[] fname = {
    "Kittipong" , "Kannikar", "Intat" , "Pongsakon",
    "Thanaporn", "Kitisak", "Watcharapong","Tanakorn"
};
    
string[] lname = {
    "Chaimon" , "Patposri" , "Kanalaksombat", "Kongnoi",
    "Hongngam" , "Srisuk", "Maneengam","Suphaphut"
};

string[] id = {
    "663245001" , "663245006","663245005", 
    "664245025" , "663245003", "663245009","663245004","663245002"
};

int i = 0;
int seq = 1;
while (i < 8) 
{
Console.WriteLine((seq++)+" "+prefix[i]+" "+fname[i]+" "+lname[i]+" id."+id[i]);
//Console.WriteLine(seq+"."+prefix[i]+fname+lname+id);
i++;
};
//seq++



