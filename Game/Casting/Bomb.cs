using Byui.Games.Casting;

namespace Diffuse {
    public class Bomb : Image
    {
        public Bomb ()
        {
            this.Display("assets/bomb.png");
            this.SizeTo(1280f, 1206f);
            this.ScaleTo(0.37f);
            this.MoveTo(-430f, -370f);
        }
//        public Explosion ()
//        {
//            this.Display("assets/explosion.png");
//            this.SizeTo(840f, 523f);
//            this.ScaleTo(1.0f);
//            this.MoveTo(10f, 10f);
//        }            
    }
}