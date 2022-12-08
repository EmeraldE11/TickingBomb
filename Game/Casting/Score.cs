using Byui.Games.Casting;

namespace Diffuse {
    public class Score : Image 
    {
        public Score () 
        {
            this.Display("assets/checkmark.png");
            this.SizeTo(840f, 859f);
            this.ScaleTo(0.7f);
            this.MoveTo(10f, 10f);  

            this.Display("assets/x-mark.png");
            this.SizeTo(225f, 225f);
            this.ScaleTo(1.3f);
            this.MoveTo(10f, 10f);
        }            
    }
}