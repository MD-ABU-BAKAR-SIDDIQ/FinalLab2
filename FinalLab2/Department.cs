using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab2
{
    class Department
    {
        public string DName { get; set; }
        public string DNumber { get; set; }

        public Faculty[] listOfFaculty;
        private int fCount;
        public int FacultyCount
        {
            get { return fCount; }
            set { fCount = value; }
        }

        public Department()
        {
            listOfFaculty = new Faculty[100];
            fCount = 0;
        }
        public Department(string name, string number)
        {
            DName = name;
            DNumber = number;
            listOfFaculty = new Faculty[100];
            fCount = 0;

        }
        public void display()
        {
            Console.WriteLine("Name Of The Department: " + DName);
            Console.WriteLine("ID Number Of The Department: " + DNumber);

        }
        public void AddFaculty(params Faculty[] faculties)
        {
            foreach (var faculty in faculties)
            {
                if (fCount < 100)
                    listOfFaculty[fCount++] = faculty;

            }
        }
        public Faculty SearchFaculty(string fid)
        {
            Faculty f = null;
            for (int i = 0; i < fCount; i++)
            {
                if (listOfFaculty[i].FacultyId.Equals(fid))
                {
                    f = listOfFaculty[i];
                    break;
                }
            }
            return f;
        }
        public void RemoveFaculty(Faculty faculty)
        {
            for (int i = 0; i < fCount; i++)
            {
                if (faculty.FacultyId.Equals(listOfFaculty[i].FacultyId))
                {
                    for (int j = i; j < fCount - 1; j++)
                    {
                        listOfFaculty[j] = listOfFaculty[j + 1];
                    }
                    fCount--;
                    break;
                }

            }
        }
        public void DisplayAllFaculty()
        {
            for (int i = 0; i < fCount; i++)
            {
                listOfFaculty[i].Display();

            }
        }


    }
}