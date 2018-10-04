using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class KnowledgeByCourse
    {
        private Knowledge knowledge;
        internal Knowledge Knowledge { get => knowledge; set => knowledge = value; }
        private List<Course> providedBy;

        public KnowledgeByCourse(Knowledge knowledge, List<Course>providedBy)
        {
            this.Knowledge = knowledge;
            this.providedBy = providedBy;
        }

        public KnowledgeByCourse(Knowledge knowledge, Course providedBy)
        {
            this.Knowledge = knowledge;
            this.providedBy.Add(providedBy);
        }

        public void AddCourse(Course course)
        {
            this.providedBy.Add(course);
        }
    }
}
