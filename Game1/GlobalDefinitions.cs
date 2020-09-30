using Microsoft.Xna.Framework.Input;

namespace Game1
{
    public static class GlobalDefinitions
    {
        public const int GraphicsWidth = 800;
        public const int GraphicsHeight = 500;

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
