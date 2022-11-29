using Byui.Games.Casting;
using Byui.Games.Services;
using Byui.Games.Directing;
using Byui.Games.Scripting;


namespace Defuser
{
    class Program
    {
        static void Main(string[] args)
        {
            Cast cast = new Cast();
            Bomb bomb = new Bomb();

            cast.AddActor("bomb", bomb);
            KeyboardService keyboardService = new KeyboardService();
        }
    }
}