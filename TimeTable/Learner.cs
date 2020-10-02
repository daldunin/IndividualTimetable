using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class Learner
    {
        private int id;
        private string Name;
        private List<KnowledgeByCourse> knowledgeSet;
        private List<Course> courses;
        private int maxQtyOfCourses;

        public Learner(int id, string name, List<KnowledgeByCourse> knowledgeSet, List<Course> courses, int maxQtyOfCourses)
        {
            this.id = id;
            this.Name = name;
            this.knowledgeSet = knowledgeSet;
            this.courses = courses;
            this.maxQtyOfCourses = maxQtyOfCourses;
        }

        public renameLearner(string newName)
        {
            this.Name = newName;
        }

        public void AddKnowledge(Knowledge knowledge, Course course)
        {
            bool found = false;
            foreach (KnowledgeByCourse k in this.knowledgeSet)
            {
                if (k.Knowledge == knowledge)
                {
                    k.AddCourse(course);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                KnowledgeByCourse kbc = new KnowledgeByCourse(knowledge, course);
                this.knowledgeSet.Add(kbc);
            }
        }
    }
}
