using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class Course
    {
        private int id;
        private string name;
        private int durationInDays;
        private List<Knowledge> prerequisites;
        private List<Knowledge> postrequisites;
        private List<Availability> availabilities;

        public string Name { get => name; set => name = value; }
        internal List<Knowledge> Prerequisites { get => prerequisites; set => prerequisites = value; }
        internal List<Knowledge> Postrequisites { get => postrequisites; set => postrequisites = value; }

        public Course(int id, string name, int durationInDays, List<Knowledge> prerequisites, List<Knowledge> postrequisites, List<Availability> availabilities)
        {
            this.id = id;
            this.Name = name;
            this.durationInDays = durationInDays;
            this.prerequisites = prerequisites;
            this.postrequisites = postrequisites;
            this.availabilities = availabilities;
        }

        public renameCourse(string newName)
        {
            this.Name = newName;
        }

        public bool checkIfAvailableByKnowledge(List<KnowledgeByCourse> knowledges)
        {
            bool allFound = true;
            foreach (Knowledge prerequisite in this.prerequisites)
            {
                bool found = false;
                foreach (KnowledgeByCourse kbc in knowledges)
                {
                    if (kbc.Knowledge == prerequisite)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    allFound = false;
                    break;
                }
            }
            return allFound;
        }

        public bool checkIfAvailableByDate(DateTime date)
        {
            bool available = false;
            foreach(Availability availability in this.availabilities)
            {
                if ((availability.Start <= date) && (availability.End >= date))
                {
                    available = true;
                    break;
                }
            }
            return available;
        }
    }

    class Availability
    {
        private DateTime start;
        private DateTime end;

        public DateTime Start { get => start; set => start = value; }
        public DateTime End { get => end; set => end = value; }

        public Availability(DateTime start, DateTime end)
        {
            this.Start = start;
            this.End = end;
        }
    }

}
