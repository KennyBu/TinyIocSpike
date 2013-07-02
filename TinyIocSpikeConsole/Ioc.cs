using Models;

namespace TinyIocSpikeConsole
{
    public static class Ioc
    {
         public static void Register()
         {
             var container = TinyIoC.TinyIoCContainer.Current;
             container.Register<IPerson, Hero>("theHero").AsMultiInstance();
             container.Register<IPerson, Villan>("theVillan").AsMultiInstance();

             container.Register<IGloat, KingGloat>().AsMultiInstance();
             //container.Register<IGloat, HumbleGloat>().AsMultiInstance();

             container.Register<IPerson, King>("theKing").AsMultiInstance();

             

         }
    }
}