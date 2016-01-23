using System;
using System.Collections.Generic;

namespace Module5
{
    class Degree
    {                
        public string degreeName;

        public List<Course> crsList = new List<Course>();

        public Degree(string degreeName)
        {
            this.degreeName = degreeName;
        }

        public void addCourse(Course c)
        {
            this.crsList.Add(c);
        }

    }
}
