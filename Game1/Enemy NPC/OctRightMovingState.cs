namespace Game1
{
    internal class OctRightMovingState : ILinkState
    {
        private Oct oct;
        private MainStage game;

        public OctRightMovingState(Oct oct, MainStage game)
        {
            this.oct = oct;
            this.game = game;
        }
    }
}