using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marks
{
    class Program
    {
        static void Main(string[] args)
        {
            

            StudentMark m1 = new StudentMark("xyz", "0006", 78, 89, 92);
            StudentMark m2 = new StudentMark("qrt", "0007", 87, 98, 77);
            StudentMark m3 = new StudentMark("pok", "0008", 99, 94, 95);
            S2 m4 = new S2("cgr", "0009", 95, 79, 90);
            Drawing d = new Drawing();
            d.Add(m1);
            d.Add(m2);
            d.Add(m3);
            d.Add(m4);
            d.Draw();


        }
    }

    class Drawing
    {
        ArrayList allshapes = new ArrayList();
        public void Add(Sa46 s)
        {
            allshapes.Add(s);
        }
        public void Draw()
        {
            for (int i = 0; i < allshapes.Count; i++)
            {
                Sa46 s = (Sa46)  allshapes[i];
                s.ToatalCal();
                s.AvgMark();
                Console.WriteLine(s.Show());
                Console.WriteLine();
            }
        }
    }
}
