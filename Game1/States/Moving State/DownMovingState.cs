namespace Game1
{
    internal class DownMovingState : ILinkState
    {
        private Link link;

        public DownMovingState(Link link)
        {
            this.link = link;
        }
    }
}