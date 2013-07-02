using System;
using Models;

namespace TinyIocSpikeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = TinyIoC.TinyIoCContainer.Current;
            Ioc.Register();

            var hero = container.Resolve<IPerson>("theHero");
            var villan = container.Resolve<IPerson>("theVillan");
            
            Console.WriteLine(hero.Gloat());
            Console.WriteLine(villan.Gloat());

            Console.ReadKey();
        }
    }
}
