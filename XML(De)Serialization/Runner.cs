using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Week4
{
    class Runner
    {
        static void Main(string[] args)
        {
            TestClassesColection srcCollection = new TestClassesColection();
            TestClassesColection recievedCollection = new TestClassesColection();

            TestClass[] array = new TestClass[2];
            array[0] = new TestClass(12, "Vasya", "Blue");
            array[1] = new TestClass(24, "Vladimir", "Green");
            srcCollection.testClasses = array;

            XMLFileWorker worker = new XMLFileWorker(@"C:\Users\Uladzislau_Parkhutsich@epam.com\Documents\Visual Studio 2015\Projects\Task.Week4\Task.Week4\xml_file.xml");

            worker.SerializeObjectToXML(srcCollection);
            recievedCollection = worker.DeserializeObjectToXML();

            foreach(TestClass tclass in recievedCollection.testClasses)
            {
                Console.WriteLine("Testclass");
                Console.WriteLine("Name: " + tclass.Name);
                Console.WriteLine("Number: " + tclass.Number);
                Console.WriteLine("Color: " + tclass.Number);
            }
        }
    }
}
