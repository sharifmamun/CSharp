using System;
using System.Collections.Generic;

namespace Module5
{
    class Course
    {
        public string courseName;
        public string courseID;

        public List<Teacher> teachers = new List<Teacher>();
        public List<Student> students = new List<Student>();

        public Course(string courseName, string courseID)
        {
            this.courseName = courseName;
            this.courseID = courseID;
        }

        public void addTeacher(Teacher t)
        {
            this.teachers.Add(t);
        }

        public void addStudent(Student s)
        {
            this.students.Add(s);
        }
    }
}
