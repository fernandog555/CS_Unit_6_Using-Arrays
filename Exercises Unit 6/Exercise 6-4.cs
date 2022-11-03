/*
Write a program named CheckZips that is used by a package delivery service to check delivery areas.

The program contains an array that holds the 10 zip codes of areas to which the company makes deliveries. (Note that this array is created for you and does not need to be changed.)

Prompt a user to enter a zip code, and display a message indicating whether the zip code is in the company’s delivery area.

For example if the user enters a zip code in the array, such as 60007, the output should be Delivery to 60007 ok.

If the user enters a zip code not in the array, such as 60008, the output should be Sorry - no delivery to 60008.
*/

using System;
using static System.Console;
class CheckZips
{
   static void Main()
   {
      string[] zips = {"12789", "54012", "54481", "54982", "60007",
         "60103", "60187", "60188", "71244", "90210"};
      
      WriteLine("Enter a Zip Code >>");
      string user = ReadLine();

      int x = Array.BinarySearch(zips, user);

      if (x < 0)
        {
          WriteLine($"Sorry - no delivery to {user}");
        }
      else
        {
          WriteLine($"Delivery to {user} ok");
        }
   }
}
