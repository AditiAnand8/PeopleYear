using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace PeopleYear
{
    class MainProgram
    {
        
         public static void Main(string[] args)
            {
                
                int yearWithMostalive = 1900;
                int highestAlive = 0;
             
                var listOfPeople = new People().GetPopleFromTextFile();
            
                for (int i = 1900; i <= 2000; i++)
                {
                    int totalAliveinYear = 0;
                    foreach (var person in listOfPeople)
                    {
                        if (i >= person.Birth && i <= person.end)
                            totalAliveinYear = totalAliveinYear + 1;
                    }

                    if (totalAliveinYear > highestAlive)
                    {
                        highestAlive = totalAliveinYear;
                        yearWithMostalive = i;
                    }
                }             
              
                Console.Write("Highest alive is {0} in the year {1}. Enter", highestAlive, yearWithMostalive);

                Application.Run(new chart(highestAlive, yearWithMostalive));
            }
        
    }
}
