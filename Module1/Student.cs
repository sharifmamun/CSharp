using System;
using System.Collections.Generic;

namespace Module5
{
    class Student
    {
        private string firstName;
        private string lastName;
        private string birthDate;

        public static int numberOfStudents = 0;

        public Student(string firstName, string lastName, string birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;

            numberOfStudents++;
        }
    }
}
