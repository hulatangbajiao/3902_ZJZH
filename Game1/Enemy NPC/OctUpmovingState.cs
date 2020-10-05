namespace Game1
{
    internal class OctUpmovingState : ILinkState
    {
        private Oct oct;
        private MainStage game;

        public OctUpmovingState(Oct oct, MainStage game)
        {
            this.oct = oct;
            this.game = game;
        }
    }
}