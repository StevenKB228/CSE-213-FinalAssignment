using System;
using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;


namespace cse210_batter_csharp.Scripting
{
        public class HandleOffScreenAction : Action
    

    {
        public HandleOffScreenAction()
        {

        }

        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            if (cast["balls"].Count > 0){
                Actor orb = cast["balls"][0];
            
            

            Actor HandleOffScreenAction = cast ["balls"] [0];

            int x = HandleOffScreenAction.GetX();
            int y = HandleOffScreenAction.GetY();

            int dx = HandleOffScreenAction.GetVelocity().GetX();
            int dy = HandleOffScreenAction.GetVelocity().GetY();

            if (x > Constants.MAX_X-50|| x < 5)
            {
                dx = -dx;
                Console.WriteLine("brick");
            }
            if (y > Constants.MAX_Y-50 || y < 5)
            {
                dy = -dy;
            }

            HandleOffScreenAction.SetVelocity(new Point(dx, dy));
        }
        }
         
    }
}