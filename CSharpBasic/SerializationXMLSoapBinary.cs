using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CSharpBasic
{

    

    public partial class SerializationXMLSoapBinary : Form
    {
        public SerializationXMLSoapBinary()
        {
            InitializeComponent();
        }

        // XML Serialzation
        public class Person // 클래스는 public 이어야 한다
        {
            // public 멤버만 저장
            public string Name;
            public int? Height;
            public int Age
            {
                get; set;
            }

            // private 멤버이므로 저장 안함
            private int avgWeight;
            private int _age;

            public Person() { }

            public override string ToString()
            {
                return $"{Name} {Age}";
            }
        }

        private string xmlFilename = @"C:\Users\jjh\Desktop\img\test.xml";

        public void SerializePerson()
        {
            Person objPerson = new Person();
            objPerson.Name = "홍길동";
            objPerson.Age = 26;

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            using (StreamWriter wr = new StreamWriter(xmlFilename))
            {
                xmlSerializer.Serialize(wr, objPerson);
            }
        }

        public Person DeserializePerson()
        {
            Person p;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
            using (StreamReader rdr = new StreamReader(xmlFilename))
            {
                p = (Person)xmlSerializer.Deserialize(rdr);
            }
            return p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerializePerson();
            textBox1.Text = DeserializePerson().ToString(); 
        }

    }
}
