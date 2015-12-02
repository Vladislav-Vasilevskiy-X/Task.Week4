using System;
using System.Xml.Serialization;

namespace Task.Week4
{
    [Serializable]
    public class TestClass
    {
        //Some fileds
        [XmlElement("Number")]
        public int Number { get; set; }

        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Color")]
        public string Color { get; set; }

        public TestClass() { }

        //Construcor for every class
        public TestClass(int number, string name, string color)
        {
            this.Number = number;
            this.Name = name;
            this.Color = color;
        }
    }

    [Serializable]
    [XmlRoot("TestClassesColection")]
    public class TestClassesColection
    {
        [XmlArray("TestClasses")]
        [XmlArrayItem("TestClass", typeof(TestClass))]
        public TestClass[] testClasses { get; set; }
    }
}
