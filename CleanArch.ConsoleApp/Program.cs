using CleanArch.Domain.Shared;

var money1 = Money.FromRial(1000);
var money2 = Money.FromTooman(100);  

Console.WriteLine(money1 == money2);
Console.WriteLine((money1 + money2).ToString());