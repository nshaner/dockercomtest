using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCOMPlus
{
    public class HelloWorld: ServicedComponent, IHelloWorld
    {
        public string Display()
        {
            try
            {
                return "I wrote a complus component on xbox Chandra!";
            }
            catch
            {
                return "Oh no! You hit an error!";
            }
            finally
            {
                Dispose();
            }
        }
        public int Addition(int a, int b)
        {
            try
            {
                return a + b;
            }
            catch
            {
                return 0;
            }
            finally
            {
                Dispose();
            }
        }
        public int Subtraction(int a, int b)
        {
            try
            {
                return a - b;
            }
            catch
            {
                return 0;
            }
            finally
            {
                Dispose();
            }
        }

    }
}
