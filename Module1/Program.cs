using System;

namespace Module5
{
    class Program
    {        
        static void Main(string[] args)
        {
            // Step 1: Instantiating three student objects
            Student student1 = new Student("John", "Dave", "1985");
            Student student2 = new Student("John", "Deve", "1986");
            Student student3 = new Student("John", "Dove", "1987");

            // Step 2: Instantiate Course object
            Course course = new Course("Programming with C#", "CS200");
            
            // Step 3: Add students to the course object
            course.addStudent(student1);
            course.addStudent(student2);
            course.addStudent(student3);
            
            // Step 4: Instantiate Teacher object
            Teacher teacher = new Teacher("Gerry", "O'Brien", "1970");

            // Step 5: Add teacher to the course object
            course.addTeacher(teacher);

            // Step 6: Instantiate a degree object
            Degree degree = new Degree("Bachelor of Science");

            // Step 7: Add course object to the degree object
            degree.addCourse(course);

            // Step 8: Instantiate a UProgram object called Information Technology
            UProgram program = new UProgram("Information Technology");

            // Step 9: Add the Degree object to the UProgram object
            program.addDegree(degree);

            /*
             * Step 10: 
             * Using Console.WriteLine statements, output the following information to the console window:
             * The name of the program and the degree it contains
             * The name of the course in the degree
             * The count of the number of students in the course.
             */
            Console.WriteLine("The {0} program contains {1} degree", program.programName, degree.degreeName);
            Console.WriteLine("The {0} degree contains {1} course", degree.degreeName, course.courseName);
            Console.WriteLine("The {0} course contains {1} students", course.courseName, Student.numberOfStudents);
        }
    }
}
