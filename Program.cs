using System;
using cse210_batter_csharp.Services;
using cse210_batter_csharp.Casting;
using cse210_batter_csharp.Scripting;
using System.Collections.Generic;

namespace cse210_batter_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the cast
            Dictionary<string, List<Actor>> cast = new Dictionary<string, List<Actor>>();

            // Bricks
            cast["bricks"] = new List<Actor>();

            // TODO: Add your bricks here
       
                    Brick b = new Brick();
                    b.SetPosition(new Point(250, 5));
                    cast["bricks"].Add(b);

            // The Ball (or balls if desired)
            cast["balls"] = new List<Actor>();

            // TODO: Add your ball here
            Ball orb = new Ball();
            orb.SetPosition(new Point(385, 320));
            cast["balls"].Add(orb);
            
            

            // // The paddle
            // cast["gkeeper"] = new List<Actor>();
            // // TODO: Add your paddle here
            // GKeeper gKeeper = new GKeeper();
            // gKeeper.SetPosition(new Point(295, 150));
            // cast["gKeeper"].Add(gKeeper);

            // The paddle
            cast["gkeeper"] = new List<Actor>();
            // TODO: Add your paddle here
            GKeeper paddle1 = new GKeeper();
            paddle1.SetPosition(new Point(355, 50));
            cast["gkeeper"].Add(paddle1);

            // The paddle
            cast["paddle"] = new List<Actor>();
            // TODO: Add your paddle here
            Paddle paddle = new Paddle();
            paddle.SetPosition(new Point(355, 400));
            cast["paddle"].Add(paddle);

            // Create the script
            Dictionary<string, List<Action>> script = new Dictionary<string, List<Action>>();

            OutputService outputService = new OutputService();
            InputService inputService = new InputService();
            PhysicsService physicsService = new PhysicsService();
            AudioService audioService = new AudioService();

            script["output"] = new List<Action>();
            script["input"] = new List<Action>();
            script["update"] = new List<Action>();
            
            ControlActorsAction controlActorsAction = new ControlActorsAction(inputService);
            script["input"].Add(controlActorsAction);
            
            // TODO: Add additional actions here to handle the input, move the actors, handle collisions, etc.
            MoveActorsActions moveActorsActions = new MoveActorsActions();
            script["update"].Add(moveActorsActions);

            HandleOffScreenAction handleOffScreenAction = new HandleOffScreenAction();
            script["update"].Add(handleOffScreenAction);

            HandleCollisionsActions handleCollisionsActions = new HandleCollisionsActions();
            script["update"].Add(handleCollisionsActions);

            DrawActorsAction drawActorsAction = new DrawActorsAction(outputService);
            script["output"].Add(drawActorsAction);

            // Start up the game
            outputService.OpenWindow(Constants.MAX_X, Constants.MAX_Y, "Penaltykick", Constants.FRAME_RATE);
            audioService.StartAudio();
            audioService.PlaySound(Constants.SOUND_START);

            Director theDirector = new Director(cast, script);
            theDirector.Direct();

            audioService.StopAudio();
        }
    }
}