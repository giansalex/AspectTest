using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArxOne.MrAdvice.Advice;

namespace AspectTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MyProudMethod();
            Console.ReadKey();
        }

        [MyProudAdvice]
        public static void MyProudMethod()
        {
            Console.WriteLine("Running Method");
        }
    }

    public class MyProudAdvice : Attribute, IMethodAdvice
    {
        public void Advise(MethodAdviceContext context)
        {
            Console.WriteLine("Before Run Method");
            // do things you want here
            context.Proceed(); // this calls the original method
            // do other things here
        }
    }


}
