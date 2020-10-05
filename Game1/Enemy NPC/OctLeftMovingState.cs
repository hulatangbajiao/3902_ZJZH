namespace Game1
{
    internal class OctLeftMovingState : ILinkState
    {
        private Oct oct;
        private MainStage game;

        public OctLeftMovingState(Oct oct, MainStage game)
        {
            this.oct = oct;
            this.game = game;
        }
    }
}