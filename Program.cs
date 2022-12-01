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

            cast.Add("bomb", bomb);
            cast.Add("manual", manual);

            ISettingsService settingService = new ISettingsService();
            RaylibKeyboardService keyboardService = new RaylibKeyboardService();
            RaylibVideoService videoService = new RaylibVideoService(settingService);
            
            Script script = new Script();
            script.Add("input", new ControlActorsAction(keyboardService));
            script.Add("output", new DrawActorsAction(videoService));
            Director director = new Director(videoService);
            director.StartGame(cast, script);
        }
    }
}