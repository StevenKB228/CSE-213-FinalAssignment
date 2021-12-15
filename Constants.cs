using System;

namespace cse210_batter_csharp
{
    /// <summary>
    /// This is a set of program wide constants to be used in other classes.
    /// </summary>
    public static class Constants
    {
        public const int MAX_X = 900;
        public const int MAX_Y = 600;
        public const int FRAME_RATE = 40;

        public const int DEFAULT_SQUARE_SIZE = 40;
        public const int DEFAULT_FONT_SIZE = 20;
        public const int DEFAULT_TEXT_OFFSET = 4;

        public const string IMAGE_BRICK = "./Assets/goal image 5.png";
        public const string IMAGE_PADDLE = "./Assets/Player 04.png";
        public const string IMAGE_GOALKEEPER = "./Assets/Goal 42.png";
        public const string IMAGE_BALL = "./Assets/ball 2.png";

        public const string SOUND_START = "./Assets/start.wav";
        public const string SOUND_BOUNCE = "./Assets/boing.wav";
        public const string SOUND_OVER = "./Assets/over.wav";

        public const int BALL_X = MAX_X / 125;
        public const int BALL_Y = MAX_Y - 10;

        public const int BALL_DX = 0;
        public const int BALL_DY = BALL_DX * 0;

        public const int PADDLE_X = MAX_X / 2;
        public const int PADDLE_Y = MAX_Y;

        public const int BRICK_WIDTH = 300;
        public const int BRICK_HEIGHT = 100;

        public const int BRICK_SPACE = 10;

        public const int PADDLE_SPEED = 15;

        public const int PADDLE_WIDTH = 100;
        public const int PADDLE_HEIGHT = 24;

        public const int GOALKEEPER_SPEED = 15;

        public const int GOALKEEPER_WIDTH = 96;
        public const int GOALKEEPER_HEIGHT = 24;

        public const int BALL_WIDTH = 14;
        public const int BALL_HEIGHT = 14;
    }

}