using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Task.Week4
{
    class XMLFileWorker
    {
        private XmlSerializer serializer;   //Standart XML serializer
        private string fileName;    //The name of xml file

        public XMLFileWorker(string fileName)
        {
            serializer = new XmlSerializer(typeof(TestClassesColection));
            this.fileName = fileName;
        }

        //Serializing collection of test classes to xml
        public void SerializeObjectToXML(TestClassesColection collection)
        {
            TextWriter writer = new StreamWriter(fileName);
            serializer.Serialize(writer, collection);
            writer.Close();
        }

        //Serializing collection of test classes from xml
        public TestClassesColection DeserializeObjectToXML()
        {
            TextReader reader = new StreamReader(fileName);
            TestClassesColection readedCollection = (TestClassesColection)serializer.Deserialize(reader);
            reader.Close();
            return readedCollection;
        }

    }
}
