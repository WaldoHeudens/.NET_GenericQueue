using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericQueue
{
    internal class TestClass
    {
        public int Id {  get; set; }
        // get wordt uitgevoerd bij het ophalen van de waarde
        //  ~  iets = Id ==> { return _Id;}
        // set wordt uitgevoerd bij het toekennen van de waarde
        //  ~  Id = iets ==> { _Id = value;}  dwz. value van iets

        static public int Volgnummer {
            get { 
                _Volgnummer++; 
                return _Volgnummer; }
            set { _Volgnummer = value; } }
        static private int _Volgnummer = 0;

        public string Name {  get; set; }

        public TestClass()
        {
            Id = -1;
            Name = "-";
        }

        public TestClass(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return "Id: " + Id + ", Name: " + Name;
        }

        public void GetContent (ref int id, ref string name)
        {
            id = Id;
            name = Name;
        }
    }

}
