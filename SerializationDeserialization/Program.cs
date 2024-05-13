using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDeserialization
{
    [Serializable]
    internal class Program
    {
        public int ID;
        public String Name;
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.ID = 1;
            obj.Name = ".Net";

            //Serialization
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\Myfolders\ExampleNew.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, obj);
            stream.Close();

            //Deserialization
            stream = new FileStream(@"C:\Myfolders\ExampleNew.txt", FileMode.Open, FileAccess.Read);
            Program objnew = (Program)formatter.Deserialize(stream);

            Console.WriteLine("Id : "+objnew.ID);
            Console.WriteLine("Name : "+objnew.Name);

            Console.ReadKey();
        }
    }
}
