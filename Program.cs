using Diffuse.Casting;
using Diffuse.Services;
using Diffuse.Directing;
using Diffuse.Scripting;


namespace Defuser
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