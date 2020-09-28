namespace Game1
{
    internal class LeftMovingState : ILinkState
    {
        private Link link;

        public LeftMovingState(Link link)
        {
            this.link = link;
        }
    }
}