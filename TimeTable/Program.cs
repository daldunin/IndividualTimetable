using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Knowledge> knowledges = new List<Knowledge>();
            knowledges = DemoTools.GenerateKnowledges(4);

            Console.WriteLine("All knowledges");
            foreach (Knowledge knowledge in knowledges)
                Console.WriteLine(knowledge.Name);

            List<KnowledgeByCourse> initialKnowledges = new List<KnowledgeByCourse>();
            initialKnowledges = DemoTools.GenerateInitialKnowledge(knowledges, 50);

            Console.WriteLine("Initial knowledges");
            foreach (KnowledgeByCourse initialKnowledge in initialKnowledges)
                Console.WriteLine(initialKnowledge.Knowledge.Name);

            List<Course> courses = new List<Course>();
            courses = DemoTools.GenerateCourses(knowledges, 2);

            Console.WriteLine("Courses");
            foreach (Course course in courses)
                Console.WriteLine(course.Name + " " + course.Prerequisites + " " + course.Postrequisites);

            Console.ReadKey();
        }
    }
}
