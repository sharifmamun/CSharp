using System;

namespace Module1
{
    class Program
    {
        // Declaring a struct
        private struct Coffee
        {
            private int strength;
            public string Bean;
            public int CountryOfOrigin;

            // ......
            public int Strength
            {
                get { return strength; }
                set { strength = value; }
            }
        }

        // Creating a struct that includes an array
        public struct Menu
        {
            public string[] beverages;

            public Menu(string bev1, string bev2)
            {
                beverages = new string[] {"Americano", "Cafe au Lait", "Cafe Macchiato", "Cappuccino", "Espresso"};
            }
        }
         
        public struct Student
        {
            public string firstName;
            public string lastName;
            public string birthDate;

            public Student(string firstName, string lastName, string birthDate)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.birthDate = birthDate;
            }
        }

        public struct Teacher
        {
            private string firstName;
            private string lastName;
            private string birthDate;

            public Teacher(string firstName, string lastName, string birthDate)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.birthDate = birthDate;
            }
        }

        public struct SchoolProgram
        {
            private string programName;

            public SchoolProgram(string programName)
            {
                this.programName = programName;                
            }
        }

        public struct Course
        {
            private string courseName;
            private string courseID;

            public Course(string courseName, string courseID)
            {
                this.courseName = courseName;
                this.courseID = courseID;
            }
        }

        static void Main(string[] args)
        {
            // Creating an array to hold 5 student structs
            Student[] arr = new Student[5];

            // Student/Teacher Info
            string firstName;
            string lastName;
            string birthDate;

            for (int i = 0; i < arr.Length; i++)
            {
                // Get Student Info
                // Instead of making the code repeatative, I am using out
                // so that the same variables can be used both for Student and Teacher
                GetStudentInformation(out firstName, out lastName, out birthDate);
                arr[i].firstName = firstName;
                arr[i].lastName = lastName;
                arr[i].birthDate = birthDate;
                PrintDetails(firstName, lastName, birthDate);
            }

            // Get Teacher Info
            GetTeacherInformation(out firstName, out lastName, out birthDate);
            
            #region Try/Catch
            //try
            //{
            //    IsValidDate(birthDate);
            //}
            //catch (NotImplementedException notImp)
            //{

            //    Console.WriteLine(notImp.Message);
            //}
            #endregion

            // Console Output
            PrintDetails(firstName, lastName, birthDate);
        }

        private static void IsValidDate(string birthDate)
        {
            throw new NotImplementedException();
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

        static void GetTeacherInformation(out string firstName, out string lastName, out string birthDate)
        {
            // Name
            Console.WriteLine("Enter Teacher's first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter Teacher's last name: ");
            lastName = Console.ReadLine();

            // DOB
            Console.WriteLine("Enter Teacher's Date Of Birth (YYYY-MM-DD): ");
            birthDate = Console.ReadLine();

            // Address
            Console.WriteLine("Enter Teacher's adress line1 (Street Number): ");
            string addressLine1 = Console.ReadLine();
            Console.WriteLine("Enter Teacher's adress line2 (Street Name): ");
            string addressLine2 = Console.ReadLine();
            Console.WriteLine("Enter Teacher's City Name: ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter Teacher's State/Province Name: ");
            string stateOrProvince = Console.ReadLine();
            Console.WriteLine("Enter Teacher's Zip/Postal Code: ");
            string zipOrPostalCode = Console.ReadLine();
            Console.WriteLine("Enter Teacher's Country Name: ");
            string country = Console.ReadLine();
        }

        static void PrintDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on {2}", first, last, birthday);
        }

    }
}
