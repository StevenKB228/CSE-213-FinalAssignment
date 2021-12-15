using System;
using System.Collections.Generic;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Services;

namespace cse210_batter_csharp.Scripting
{
    public class HandleCollisionsActions : Action
    {
        AudioService audioService = new AudioService();
        PhysicsService physicsService = new PhysicsService();
        public HandleCollisionsActions()
        {

        }
        public override void Execute(Dictionary<string, List<Actor>> cast)
        {
            if (cast["balls"].Count > 0){
            Actor orb = cast["balls"][0];
            Actor paddle = cast["paddle"][0];
            Actor gkeeper = cast["gkeeper"][0];
            //Actor brick = cast["brick"][0];
            List<Actor> bricks = cast["bricks"];
            List<Actor> bricksThatTouchTheBall = new List<Actor>();
            foreach (Actor brick in bricks)
            { 
                bool brickcollision = physicsService.IsCollision(orb, brick);
                if (brickcollision)
                {
                    int x = orb.GetX();
                    int y = orb.GetY();

                    bool comingFromDown = false;

                    int dx = orb.GetVelocity().GetX();
                    int dy = orb.GetVelocity().GetY();

                    if (dy < 0){
                        comingFromDown = true;
                    }

                    dy = -dy;                
                    orb.SetVelocity(new Point(dx, dy));

                    audioService.PlaySound(Constants.SOUND_BOUNCE);

                    // This brick touched the ball
                    if (comingFromDown){
                        cast ["balls"].Remove (orb);
                        cast["gameOverText"] = new List<Actor>();
                        GameOverText gameOverText = new GameOverText();
                        gameOverText.SetPosition(new Point(295, 180));
                        cast["gameOverText"].Add(gameOverText);

                    }
                    // Put this brick in the list

                }
            }
        


            bool collision = physicsService.IsCollision(orb, paddle);
            //bool brickcollision = physicsService.IsCollision(orb, brick);
         
            if (collision)
            {
                int x = orb.GetX();
                int y = orb.GetY();

                int dx = orb.GetVelocity().GetX();
                int dy = orb.GetVelocity().GetY();

                
               //when shooter kicks the ball!
                if (dx == 0 || dy == 0)
                {
                    dx = 1;
                    dy = -4;
                    
                }

                dy = -dy;                
                orb.SetVelocity(new Point(dx, dy));

                audioService.PlaySound(Constants.SOUND_BOUNCE);
            }
               bool keepercollis = physicsService.IsCollision(orb, gkeeper);

               if (keepercollis)
               {
                int x = orb.GetX();
                int y = orb.GetY();

                int dx = orb.GetVelocity().GetX();
                int dy = orb.GetVelocity().GetY();

                dy = -dy;                
                orb.SetVelocity(new Point(dx, dy));

                audioService.PlaySound(Constants.SOUND_BOUNCE);
            }

            

        
        }

       

        }
    }
}