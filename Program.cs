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
            Cast cast = new Cast();
            Bomb bomb = new Bomb();
            Manual manual = new Manual();

            cast.AddActor("bomb", bomb);
            cast.AddActor("manual", manual);
            KeyboardService keyboardService = new KeyboardService();
            VideoService videoService = new VideoService();
            
            Script script = new Script();
            script.AddAction("input", new ControlActorsAction(keyboardService));
            script.AddAction("output", new DrawActorsAction(videoService));
        }
    }
}