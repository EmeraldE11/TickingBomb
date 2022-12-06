using Byui.Games.Casting;

namespace Diffuse {
    public class Manual : Image
    {
     public Manual ()
     {
        //replace with manual files and logic as created
        this.Display("assets/bomb.png");
        this.ScaleTo(3.0f);
     }
    }
}

// Pull input
// display raylib
// pull from data (module steps)


// 5 wires
// 5 colors - red, green, blue, yellow, purple


// Follow the rules sequentially:
// If there is at least one red and at least one purple, cut the third wire
// If there is one of all five colors, cut the first wire
// If there is no red and more than one purple, cut the last wire
// If there is one blue and one green wire, cut the third wire
// If there are two or more yellow, cut the fourth wire
// Otherwise, cut the second wire


// Step 1:
// Bi-Step:
// Step 21/7:
// Use weird step names, scramble them in the text file or pull them in a more random order
// to display for confusion.