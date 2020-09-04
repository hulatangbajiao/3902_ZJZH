namespace Game1
{
    public static class GlobalDefinitions
    {
        public const int GraphicsWidth = 800;
        public const int GraphicsHeight = 500;

        public enum SpriteModes
        {
            StaticFixed = 1,
            AnimatedFixed = 2,
            StaticVerticalMoving = 3,
            AnimatedHorizontalMoving = 4,
            Invalid = 5
        }
    }
}
