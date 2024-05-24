using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExamples
{
    class Demo1 { }
    class Sample { }
    interface If1 { }
    enum WeekDays { }
    interface If2 { }
    class Test { }
    struct Student { }
    struct Employee { }
    enum Months { }

    internal class InfoAboutTypeReflection
    {
        static void Main()
        {
            Assembly a=Assembly.GetExecutingAssembly();
            Type[] t=a.GetTypes();
            foreach(Type t1 in t)
            {
                if(t1.IsClass)
                    Console.WriteLine(t1+"[Class]");
                else
                    if(t1.IsInterface)
                    Console.WriteLine(t1+"[Interface]");
                else
                    if(t1.IsEnum)
                    Console.WriteLine(t1+"[Enum]");
                else
                    Console.WriteLine("[Struct]");
            }
        }
    }
}
