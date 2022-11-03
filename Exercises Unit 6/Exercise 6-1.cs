/*
Write a program named ArrayDemo that stores an array of 10 integers. (Note that the array is created for you and does not need to be changed.)

Until the user enters a sentinel value, allow the user four options:

(1) to view the list in order from the first to last position in the stored array

(2) to view the list in order from the last to first position

(3) to choose a specific position to view

(4) to quit the application.
*/

using System;
using static System.Console;
class ArrayDemo
{
   static void Main()
   {
       int userC;
       int[] nums = {7, 6, 3, 2, 10, 8, 4, 5, 9, 1};
       int QUIT = 4;
       Write("Choose an option 1, 2, or 3 >> ");
       userC = Convert.ToInt32(ReadLine());

       while(userC != QUIT)
        {
          if(userC == 1)
            {
              WriteLine("---------------------");
              for(int x = 0; x < nums.Length; ++x)
                {
                  Write(nums[x]+" ");
                }
              WriteLine("\n---------------------");
            }
          if(userC == 2)
            {
              WriteLine("---------------------");
              Array.Reverse(nums);
              for(int x = 0; x < nums.Length; ++x)
                {
                  Write(nums[x]+" ");
                }
                WriteLine("\n---------------------");
            }
          if(userC == 3)
            {
              Write("Choose Position to View (0-9) >>");
              userC = Convert.ToInt32(ReadLine());
              
              WriteLine("---------------------");
              WriteLine(nums[userC]);
              WriteLine("---------------------");
            }
        Write("Choose an option 1, 2, 3 OR 4 to Quit >> ");
        userC = Convert.ToInt32(ReadLine());
        }


       
   }  
}
