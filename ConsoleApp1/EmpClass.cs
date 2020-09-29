using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EmpClass
    {
        public EmpClass() {
            Console.WriteLine("Thanks use EmpClass");
        }
        public EmpClass(string name) {
            Console.WriteLine($"Hello {name} ! Welcome to EmpClass.");
        }

        public int X;
        public int Y;
        public EmpClass(int x, int y) => (X, Y) = (x, y);
        public EmpClass(Base s) => X = int.Parse(s.Nobr);

        public void GetPoint()
        {
            Console.WriteLine(X.ToString() +","+ Y.ToString());
        }

        public Base GetBase()
        {
            Base b = new Base() {
                Nobr = "",
                Name = "",
                state = false,
                msg = "2"
            };
            return b;
        }
    }
}

public class Base : DataLists,ErrMsg
{
   public string Nobr { get; set; }
   public string Name { get; set; }
   public bool state { get; set; }
   public string msg { get; set; }
}

interface DataLists
{
   string Nobr { get; set; }
   string Name { get; set; }
}

interface ErrMsg
{
   bool state { get; set; }
   string msg { get; set; }
}

public class Pair<TFirst, TSecond>
{
    public TFirst First { get; }
    public TSecond Second { get; }

    public Pair(TFirst first, TSecond second) =>
        (First, Second) = (first, second);
}