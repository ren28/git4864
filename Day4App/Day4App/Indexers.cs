using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day4App
{
    class Indexers
    {
        private string[] words = new string[3];

        public string this[int x] //position for indexer
        {
            get
            {
                string temp = words[x]; //to identify position
                return temp;
            }
            set
            {
                words[x] = value;
            }
        }

        public string this[float x] //overload 
        {
            get
            {
                string temp = words[1]; //consists float values
                return temp;
            }
            set
            {
                words[1] = value;
            }
        }

        static void Main()
        {
            Indexers ie = new Indexers();
            ie[0] = "Hello";
            ie[1] = "World";
            ie[2] = "Of Indexers";
            Console.WriteLine(ie[0] + ie[1] + ie[2]);
            Console.Read();

        }
    }
}
