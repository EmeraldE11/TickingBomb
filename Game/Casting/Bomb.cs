using Byui.Games.Casting;

namespace Diffuse {
    public class Bomb : Image
    {
        public Bomb ()
        {
            this.Display("assets/bomb.png");
            this.ScaleTo(3.0f);
        }
    }
}