using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    class DemoTools
    {
        public List<Knowledge> GenerateKnowledges(int qty)
        {
            List<Knowledge> knowledges = new List<Knowledge>();
            for (int i = 1; i<= qty; i++)
            {
                Knowledge k = new Knowledge(i, "Knowledge " + i);
                knowledges.Add(k);
            }
            return knowledges;
        }

        public List<KnowledgeByCourse> generateInitialKnowledge(List<Knowledge> knowledges, int pct)
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
    }
}
