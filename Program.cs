using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace svoistvo_classov_sharp
{

    class Group
    {
        public string Group_Name { get; set; }
    }

    class Student
    {







        // каждое свойство публичное 
        string fname;

        /*private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }*/

        string lname;
        public string Lname
        {
            get { return lname; } // модификаторы доступа к сеттерам и геттерам (если не заданы) будут иметь тот же что заявлено сверху
            set { lname = value; } // value - то значение которое я задам 
        }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {

                if (value >= 16 && value <= 50)
                    age = value;
                else
                    WriteLine($"Error");
            }
        }


        double avg;
        static string group;

        public static string Group
        {
            get { return group; }
            set { group = value; }
        }


        /*static Student() 
        {
            group = "PV221";
            WriteLine($"constructor with static");
        }*/

        public Student()
        {
            fname = " ";
            lname = " ";
            age = 0;
            avg = 0;

        }

        //public Student() : this("not fname", "not lname", 0, 0) { } // в той последовательночти в которой объявили поля

        public Student(string fn, string ln, int a, double av)
        {
            fname = fn;
            lname = ln;
            age = a;
            avg = av;
            WriteLine($"constructor with param");
        }

        public void show()
        {
            WriteLine($"{lname} {fname} {age} {avg} {group}");
        }

        public void setFname()
        {
            WriteLine($"enter the name: ");
            fname = ReadLine();
        }

        public string getFname()
        {
            return fname;
        }



        // автоматические свойства - нужны чтобы инициализировать или читать эти данные
        public string LName { get; set; } = "Last Name";
        public string FName { get; set; } = "First Name";
        public int AGE { get; set; } = ((DateTime.Now.Year) - 2007) >= 16 ? (DateTime.Now.Year) - 2007 : 0;
       // public static string GRoup { get; set; }

        public Group MyGroup { get; set; }

        public DateTime BD { get; set; }
        public override string ToString()
        {
            return $"{LName} {FName} {AGE} {MyGroup} {BD.ToShortDateString()} ";
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            /*Student.Group = "PV221";
            Student st1 = new Student();
            st1.Lname = "cwsb";
          //  WriteLine(st1.Lname);
            st1.Age = 25;
            WriteLine(st1);
            Student st2 = new Student();
            WriteLine(st2);*/

            /*Student s = new Student();
            s.FName = "vyvubj";
            s.LName = "vuscvuc";
            s.AGE = 22;
            Student.GRoup = "PV221";
            WriteLine(s);*/

            // NULL - conditional - operator
            // null - пустой адрес

            double? num = null;
            num = 10;

            bool? b1 = null;
            b1 = true;

            int? number = null;
            number = number ?? 50; // проверяет является ли значение нулевым, если да - присваивает указанное значение
            WriteLine(number);
            number = number ?? 100;
            WriteLine(number);

            Student st5 = null;
            DateTime? d1 = st5?.BD;
            WriteLine(d1);
            WriteLine("********************");
            Student st6 = new Student();
            string gn = st6?.MyGroup?.Group_Name;
            WriteLine(gn);
            WriteLine("********************");
            Student st7 = new Student { MyGroup = new Group { Group_Name = "PV221" } };
            gn = st7?.MyGroup?.Group_Name;
            WriteLine(gn);
            WriteLine("********************");
            Student[] starr = { st5, st6, st7 };
            Student st4 = starr?[0] ?? new Student { MyGroup = new Group { Group_Name = "PV111" } };
            WriteLine(st4);
        }
    }
}



/*class Calc
    {
        public double Plus(double n1, double n2)
        {
            return n1 + n2;
        }

        public double Minus(double n1, double n2)
        {
            return n1 - n2;
        }

        public double Mult(double n1, double n2)
        {
            return n1 * n2;
        }

        public double Division(double n1, double n2)
        {
            if (n2!=0)
            return n1 / n2;
            else
                return 0;
        }
    }*/

/*Calc calc = new Calc();

            string exp;
            WriteLine($"Enter expression: ");
            exp = ReadLine();
            char s = ' ';
            foreach (char item in exp)
            {
                if (item =='+' || item == '*' || item == '/' || item == '-')
                {
                    s = item;
                    break;
                }    
            }

            string[] num = exp.Split(s); // метод разделения строки на до и после символа 
            double res = 0;
            switch (s)
            {
                case '+': res = calc.Plus(double.Parse(num[0]), double.Parse(num[1]));
                    break;
                case '-':
                    res = calc.Minus(double.Parse(num[0]), double.Parse(num[1]));
                    break;
                case '*':
                    res = calc.Mult(double.Parse(num[0]), double.Parse(num[1]));
                    break;
                case '/':
                    res = calc.Division(double.Parse(num[0]), double.Parse(num[1]));
                    break;

            }
            WriteLine($"   {num[0]} {s} {num[1]} = {res}");*/