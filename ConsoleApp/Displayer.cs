using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    interface IDisplay
    {
        void Display();
    }

    class Displayer : IDisplay
    {
        public void Display()
        {
            GlobalVariable vari = new GlobalVariable();
            vari.GetAllEventData();
        }
    }
}
