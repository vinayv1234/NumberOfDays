using System;
using System.Globalization;

namespace NumberOfDays
{
    class Program {
        static void Main(string[] args) {
            try {
                Console.WriteLine("Please enter your date of bith in dd-mm-yyyy format");
                string dateTime = Console.ReadLine();

                // Replace - with /
                string convertedDateTime = dateTime.Replace("-", "/");

                // Parse date from the string
                DateTime dob = DateTime.ParseExact(convertedDateTime, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                // Current date
                DateTime currentDate = DateTime.Now;

                // Difference in days
                double numberOfDays = (currentDate - dob).TotalDays;

                if (numberOfDays <= 0) {
                    Console.WriteLine("Please enter your correct date of birth. It cannot be in future.");
                    Console.WriteLine("Please restart the program and enter the date in dd-mm-yyyy format");
                }
                else {
                    // Print the age in days
                    Console.WriteLine("Age = {0}", numberOfDays);
                }
                
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please restart the program and enter the date in dd-mm-yyyy format");
            }
            finally {
                Console.Read();
            }
        }
    }
}
