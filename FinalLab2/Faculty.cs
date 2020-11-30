using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab2
{
    class Faculty
    {

        private string fName;
        public string FacultyName
        {
            get { return fName; }
            set { fName = value; }
        }

        private string fId;

        public string FacultyId { get; set; }
        
        public Faculty()
        {

        }
        public Faculty(string fName, string fId)
        {
            this.fName = fName;
            this.fId = fId;

        }
        public void Display()
        {
            Console.WriteLine("Name: " + fName);
            Console.WriteLine("Id: " + fId);
        }
    }
}
