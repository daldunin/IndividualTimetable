using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    static class DemoTools
    {
        public static List<Knowledge> GenerateKnowledges(int qty)
        {
            List<Knowledge> knowledges = new List<Knowledge>();
            for (int i = 1; i<= qty; i++)
            {
                Knowledge k = new Knowledge(i, "Knowledge " + i);
                knowledges.Add(k);
            }
            return knowledges;
        }

        public static List<KnowledgeByCourse> GenerateInitialKnowledge(List<Knowledge> knowledges, int pct)
        {
            if ((pct > 100) || (pct <= 0))
                Console.Write("Wrong percent of initial knowledge");
            List<KnowledgeByCourse> lkbc = new List<KnowledgeByCourse>();
            for (int i = 1; i <= (int)knowledges.Count * pct / 100; i++)
            {
                Course c = null;
                KnowledgeByCourse kbc = new KnowledgeByCourse(knowledges.ElementAt(i), c);
                lkbc.Add(kbc);
            }
            return lkbc;
        }

        public static List<Course> GenerateCourses(List<Knowledge> knowledges, int qty)
        {
            if (qty > knowledges.Count)
            {
                Console.WriteLine("This method requires qty less then qty of competencies");
                return null;
            }
            List<Course> courses = new List<Course>();
            List<Knowledge> prerequisites = new List<Knowledge>();
            List<Knowledge> postrequisites = new List<Knowledge>();
            for (int i = 1; i <= qty; i++)
            {
                prerequisites.Clear();
                for (int j = 1; j <= i; j++)
                {
                    prerequisites.Add(knowledges.ElementAt(j));
                }
                postrequisites.Clear();
                for (int j = knowledges.Count; j <= knowledges.Count - qty; j++)
                {
                    postrequisites.Add(knowledges.ElementAt(j));
                }
                Availability availability = new Availability(DateTime.Now.AddDays(-10), DateTime.Now.AddDays(-10));
                List<Availability> availabilities = new List<Availability>();
                availabilities.Add(availability);

                Course course = new Course(i, "Course " + i, i * 10, prerequisites, postrequisites, availabilities);
                courses.Add(course);
            }
            return courses;
        }
    }
}
