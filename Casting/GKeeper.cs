using System;
using System.Collections.Generic;

namespace cse210_batter_csharp.Casting
{
    public class GKeeper : Actor
    {
        public GKeeper()
        {
            SetWidth(Constants.GOALKEEPER_WIDTH);
            SetHeight(Constants.GOALKEEPER_HEIGHT);
            SetImage(Constants.IMAGE_GOALKEEPER);
        }
    }
}