using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Department CS = new Department("CSE", "1234");
            Faculty CSF1 = new Faculty("TANVIR AHMED", "10001");
            Faculty CSF2 = new Faculty("REZAWN AHMED", "10002");
           
            CS.AddFaculty(CSF1,CSF2);
            CS.DisplayAllFaculty();
            CS.RemoveFaculty(CSF1);
          
        }
    }
}