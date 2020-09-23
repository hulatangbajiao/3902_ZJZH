namespace Game1
{
    internal class UpMovingState : ILinkState
    {
        private Link link;

        public UpMovingState(Link link)
        {
            this.link = link;
        }
    }
}