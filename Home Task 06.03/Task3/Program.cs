
using Task3;

var user1 = new BankAccount(1000.0m);
user1.Owner = "Salohidin";
user1.AccountNumber = 112233;
System.Console.WriteLine(user1.PrintStatement());
System.Console.Write("Vvedite Summu kotoruyu xotite dobavit: ");
user1.TopUp(Convert.ToDecimal(Console.ReadLine()));
System.Console.WriteLine(user1.PrintStatement());
System.Console.WriteLine("Snatiye so scheta: ");
user1.WithDraw(Convert.ToDecimal(Console.ReadLine()));
System.Console.WriteLine(user1.PrintStatement());
