using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class Knowledge
    {
        private int id;
        private string name;

        public string Name { get => name; set => name = value; }

        public Knowledge(int id, string name)
        {
            this.id = id;
            this.Name = name;
        }
    }
}
