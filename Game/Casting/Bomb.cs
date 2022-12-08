using Byui.Games.Casting;

namespace Diffuse {
    public class Bomb : Image
    {
        public Bomb ()
        {
            this.Display("assets/bomb.png");
            this.SizeTo(32f, 32f);
            this.ScaleTo(2.0f);
            this.MoveTo(10f, 10f);

            this.Display("assets/explosion.png");
            this.SizeTo(840f, 523f);
            this.ScaleTo(1.0f);
            this.MoveTo(10f, 10f);            
        }
    }
}