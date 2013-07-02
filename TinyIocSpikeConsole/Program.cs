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
            var king = container.Resolve<IPerson>("theKing");
            
            Console.WriteLine(hero.Gloat());
            Console.WriteLine(villan.Gloat());
            Console.WriteLine(king.Gloat());

            Console.ReadKey();
        }
    }
}
