using System;

namespace Module5
{
    class Program
    {        
        static void Main(string[] args)
        {
            // Creating an array to hold 5 student structs
            Student[] arr = new Student[5];

            // Student/Teacher Info
            string firstName;
            string lastName;
            string birthDate;

            // Looping through to get all students data
            for (int i = 0; i < arr.Length; i++)
            {
                // Get Student Info
                // Instead of making the code repeatative, I am using out
                // so that the same variables can be used both for Student and Teacher
                GetStudentInformation(out firstName, out lastName, out birthDate);
                arr[i].firstName = firstName;
                arr[i].lastName = lastName;
                arr[i].birthDate = birthDate;

                // Console output
                Console.WriteLine("{0} {1} was born on {2}", arr[i].firstName, arr[i].lastName, arr[i].birthDate);
            }
        }

        static void GetStudentInformation(out string firstName, out string lastName, out string birthDate)
        {
            // Name
            Console.WriteLine("Enter Student's first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter Student's last name: ");
            lastName = Console.ReadLine();

            // DOB
            Console.WriteLine("Enter Student's Date Of Birth (YYYY-MM-DD): ");
            birthDate = Console.ReadLine();

            //System.DateTime(birthDate);

            // Address
            Console.WriteLine("Enter Student's adress line1 (Street Number): ");
            string addressLine1 = Console.ReadLine();
            Console.WriteLine("Enter Student's adress line2 (Street Name): ");
            string addressLine2 = Console.ReadLine();
            Console.WriteLine("Enter Student's City Name: ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter Student's State/Province Name: ");
            string stateOrProvince = Console.ReadLine();
            Console.WriteLine("Enter Student's Zip/Postal Code: ");
            string zipOrPostalCode = Console.ReadLine();
            Console.WriteLine("Enter Student's Country Name: ");
            string country = Console.ReadLine();            
        }
    }
}
