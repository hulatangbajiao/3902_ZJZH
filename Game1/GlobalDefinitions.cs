using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    public static class GlobalDefinitions
    {
        public const int GraphicsWidth = 1600;
        public const int GraphicsHeight = 1000;
        public static Vector2 Position;
        public static Vector2 OctPosition;
        public static int phaseChangingSpeed = 50;


        public enum LinkStates
        {
            UpIdleState = 1,
            LeftIdleState = 2,
            RightIdleState = 3,
            DownIdleState = 4,
            UpMovingState = 5,
            LeftMovingState = 6,
            RightMovingState = 7,
            DownMovingState = 8,
            StandingMagicalRodState = 9,
            StandingWhiteSwordState = 10,
            StandingWoodenSwordState = 11,
            damaged = 12

        }
        
    }
}
