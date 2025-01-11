char ESCAPE = '\e';

string redText = $"{ESCAPE}[31m";
string greenText = $"{ESCAPE}[32m";
string resetText = $"{ESCAPE}[0m";

Console.WriteLine($"{redText}Este texto es rojo{resetText}");
Console.WriteLine($"{greenText}Este texto es verde{resetText}");