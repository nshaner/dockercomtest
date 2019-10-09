using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCOMPlus
{
    public interface IHelloWorld
    {
        string Display();

        int Addition(int a, int b);

        int Subtraction(int a, int b);

    }
}