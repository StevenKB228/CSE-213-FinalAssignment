using System;

namespace cse210_batter_csharp.Casting
    
{ 
     public class GameOverText : Actor
    {
         public GameOverText()
   {
            SetWidth(Constants.BALL_WIDTH);
            SetHeight(Constants.BALL_HEIGHT);
            SetVelocity(new Point(4, 4));
            SetText("Game Over");
        
        }
        }
    }

