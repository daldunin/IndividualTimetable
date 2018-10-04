using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class TimeTable
    {
        List<ScheduledCourse> scheduledCourses;

        public TimeTable()
        {
            this.scheduledCourses = new List<ScheduledCourse>();
        }

        public TimeTable(List<ScheduledCourse> scheduledCourses)
        {
            this.scheduledCourses = scheduledCourses;
        }

        public void ScheduleCourse(Course course, DateTime start)
        {
            ScheduledCourse sc = new ScheduledCourse(course, start);
            this.scheduledCourses.Add(sc);
        }
    }

    class ScheduledCourse
    {
        private Course course;
        private DateTime start;

        public DateTime Start { get => start; set => start = value; }
        internal Course Course { get => course; set => course = value; }

        public ScheduledCourse(Course course, DateTime start)
        {
            this.Course = course;
            this.Start = start;
        }
    }
}
