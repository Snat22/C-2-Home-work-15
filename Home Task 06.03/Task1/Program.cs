
using Task1;

var rec1 = new Rectangle(3.2,2.1);
rec1.Description = "Rectangle";
System.Console.WriteLine(rec1.PrintDescription());
System.Console.WriteLine(rec1.Calculate());


var circl1 = new Rectangle(35,2);
circl1.Description = "Cicrcle";
System.Console.WriteLine(circl1.PrintDescription());
System.Console.WriteLine(circl1.Calculate());