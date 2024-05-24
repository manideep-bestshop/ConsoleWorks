using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExamples
{
    class Demo
    {
        public int a = 19;
        public bool b = true;
        public double d = 7.3;
        public int prop1 { get; set; }
        public int prop2 { get; set; }

        public Demo() { }
        public Demo(byte i) { }
        public void Show() { }
        public void display() { }
        public void Retr(int n, float m) { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo d=new Demo();
            Type t=d.GetType();
            Console.WriteLine(t);
            FieldInfo i = t.GetField("a");
            Console.WriteLine(i);

            FieldInfo[] fi = t.GetFields();

            foreach(FieldInfo f in fi)
                Console.WriteLine(f);

            MethodInfo[] mi=t.GetMethods();

            foreach(MethodInfo m in mi)
            {
                Console.WriteLine(m);
                ParameterInfo[] pi= m.GetParameters();
                foreach(ParameterInfo p in pi)
                    Console.WriteLine(p);
            }
            ConstructorInfo[] ci= t.GetConstructors();
            foreach(ConstructorInfo c in ci)
                Console.WriteLine(c);
            PropertyInfo[] p1 = t.GetProperties();
            foreach(PropertyInfo p in p1)
                Console.WriteLine(p);

            Console.WriteLine("===========");
            TypeInfo ti = t.GetTypeInfo();
            Console.WriteLine(ti);
            Console.WriteLine("===========");
        }
    }
}
