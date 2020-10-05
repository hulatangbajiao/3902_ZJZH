namespace Game1
{
    internal class OctDownMovingState : ILinkState
    {
        private Oct oct;
        private MainStage game;

        public OctDownMovingState(Oct oct, MainStage game)
        {
            this.oct = oct;
            this.game = game;
        }
    }
}