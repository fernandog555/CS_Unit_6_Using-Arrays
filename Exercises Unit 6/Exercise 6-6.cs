/*
The Chat-A-While phone company provides service to six area codes and charges the per-minute rates for phone calls shown in Figure 6-25 (below).

Write a program named ChatAWhile that stores the area codes and rates in parallel arrays and allows a user to enter an area code and the length of time for a call in minutes, and then display the total cost of the call.

For example if the area code is in the array, such as 715, and the call length is 22 minutes, the output should be:

Your phone call to area 715 costs $0.16 per minute
For 22 minutes the total is $3.52
If the area code is not in the array, such as 111, the program should not accept a call length, and instead output Sorry - no calls allowed to area 111.
*/

using System;
using static System.Console;
using System.Globalization;
class ChatAWhile
{
   static void Main()
   {
      string [] areaCode =   {"262", "414", "608","715", "815", "920"};
      double [] minuteRate = {0.07, 0.10, 0.05, 0.16, 0.24, 0.14};

      WriteLine("Enter Area Code >>");
      string user = ReadLine();

      WriteLine("Enter Call Length in Minutes >>");
      int minutes = Convert.ToInt32(ReadLine());

      int x = Array.BinarySearch(areaCode, user);

      if (x < 0)
        {
          WriteLine($"Sorry - no calls allowed to area {user}");
        }
      else
        {
          string MINCOST = minuteRate[x].ToString("C", CultureInfo.GetCultureInfo("en-US"));
          double TOTCOST = (double)minutes * minuteRate[x];
          string TOTSTRING = TOTCOST.ToString("C", CultureInfo.GetCultureInfo("en-US"));
          WriteLine($"Your phone call to area {user} costs {MINCOST} per minute");
          WriteLine($"For {minutes} minutes the total is {TOTSTRING}");
        }
   }
}
