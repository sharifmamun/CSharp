using System;
using System.Collections.Generic;

namespace Module5
{
    class UProgram
    {
        public string programName;

        public List<Degree> degreeList = new List<Degree>();

        public UProgram(string programName)
        {
            this.programName = programName;                
        }

        public void addDegree(Degree d)
        {
            this.degreeList.Add(d);
        }
    }
}
