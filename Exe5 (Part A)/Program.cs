
double wageBeforeTax = 0;
double wage = 0;
double hours = 0;
double totalHours = 0;
double totalOT = 0;
double finalAmount = 0;

Console.WriteLine("This program will calculate the amount of money made in one week.");
Console.WriteLine("Enter hourly wage : ");
wageBeforeTax = Convert.ToDouble(Console.ReadLine());
wage = wageBeforeTax * 0.82;

Console.WriteLine("Monday hours: ");
double monHours = Convert.ToDouble(Console.ReadLine());
if (monHours > 8)
{
     double monOT = monHours - 8;
     monHours = 8;
     totalOT = totalOT + monOT;
}
Console.WriteLine("Tuesday hours: ");
double tuesHours = Convert.ToDouble(Console.ReadLine());
if (tuesHours > 8)
{
     double tuesOT = tuesHours - 8;
     tuesHours = 8;
     totalOT = totalOT + tuesOT;
}
Console.WriteLine("Wednesday hours: ");
double wedHours = Convert.ToDouble(Console.ReadLine());
if (wedHours > 8)
{
     double wedOT = wedHours - 8;
     wedHours = 8;
     totalOT = totalOT + wedOT;
}
Console.WriteLine("Thursday hours: ");
double thursHours = Convert.ToDouble(Console.ReadLine());
if (thursHours > 8)
{
    double thursOT = thursHours - 8;
    thursHours = 8;
    totalOT = totalOT + thursOT;
}
Console.WriteLine("Friday hours: ");
double friHours = Convert.ToDouble(Console.ReadLine());
if (friHours > 8)
{
     double friOT = friHours - 8;
     friHours = 8;
     totalOT = totalOT + friOT;
}
Console.WriteLine("Saturday?");
double satHours = Convert.ToDouble(Console.ReadLine());
if (satHours > 8)
{
     double satOT = satHours - 8;
     satHours = 8;
     totalOT = totalOT + satOT;
}
Console.WriteLine("Sunday");
double sunHours = Convert.ToDouble(Console.ReadLine());
if (sunHours > 8)
{
     double sunOT = sunHours - 8;
     sunHours = 8;
     totalOT = totalOT + sunOT;
}
totalHours = monHours + tuesHours + wedHours + thursHours + friHours + satHours + sunHours;
Console.WriteLine("Total hours worked for this week was: " + totalHours + "\nTotal overtime hourly wage for this week was: " + totalOT);

double wageOT = (wage / 2) + wage;
finalAmount = (totalHours * wage) + (totalOT * wageOT);
Console.WriteLine("The amount of money you should receive this week is: " + finalAmount);
Console.ReadLine();
