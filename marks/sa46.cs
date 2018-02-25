using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marks
{
    class Sa46
    {
        string name;
        string rollnumber;
        double m1;
        double m2;
        double m3;
        double total;
        double avg;

        public Sa46()
        {

        }

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }

        }

        public string Roll
        {
            set
            {
                rollnumber = value;
            }
            get
            {
                return rollnumber;
            }
        }

        public double M1
        {
            set
            {
                m1 = value;
            }
            get
            {
                return m1;
            }
        }
        public double M2
        {
            set
            {
                m2 = value;
            }
            get
            {
                return m2;
            }
        }
        public double M3
        {
            set
            {
                m3 = value;
            }
            get
            {
                return m3;
            }
        }

        public virtual double ToatalCal()
        {
            total = m1 + m2 + m3;
            return total;

        }

        public virtual double AvgMark()
        {
            avg = total / 3;
            return avg;
        }

        public virtual string Show()
        {
            string s = string.Format("NAME={0}\nTOTALMARK={1}\nAVERAGE={2:0.00}", Name, total, avg);
            return s;
        }
    }
        class StudentMark : Sa46
        {

           public StudentMark(string name,string roll,double m1,double m2,double m3) : base()
        {
            base.Name = name;
            base.Roll = roll;
            base.M1 = m1;
            base.M2 = m2;
            base.M3 = m3;
        }

        public override double AvgMark()
        {
            return base.AvgMark();
        }

        public override double ToatalCal()
        {
            return base.ToatalCal();
        }

        public override string Show()
        {
            return base.Show();
        }
    }

    class S2 : Sa46
    {
        public S2(string name, string roll, double m1, double m2, double m3) : base()
        {
            base.Name = name;
            base.Roll = roll;
            base.M1 = m1;
            base.M2 = m2;
            base.M3 = m3;
        }

        public override double AvgMark()
        {
            return base.AvgMark();
        }

        public override double ToatalCal()
        {
            return base.ToatalCal();
        }

        public override string Show()
        {
            return base.Show();
        }
    }
    
}