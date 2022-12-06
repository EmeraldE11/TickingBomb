using Byui.Games.Casting;
using Byui.Games.Services;
using Byui.Games.Directing;
using Byui.Games.Scripting;


namespace Diffuse
{
    class Program
    {
        static void Main(string[] args)
        {
            Scene scene = new Scene();
            Bomb bomb = new Bomb();
            Manual manual = new Manual();

            scene.AddActor("bomb", bomb);
            scene.AddActor("manual", manual);
            IServiceFactory serviceFactory = new RaylibServiceFactory();
            DrawActorsAction drawActorsAction = new DrawActorsAction(serviceFactory);
            GetInputAction getInputAction = new GetInputAction(serviceFactory);
            scene.AddAction(Phase.Input, getInputAction);
            scene.AddAction(Phase.Output, drawActorsAction);
            Director director = new Director(serviceFactory);
            director.Direct(scene);
        }
    }
}