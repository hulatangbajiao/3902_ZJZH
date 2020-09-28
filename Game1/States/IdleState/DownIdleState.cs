namespace Game1
{
    internal class DownIdleState : ILinkState
    {
        private Link link;

        public DownIdleState(Link link)
        {
            this.link = link;
        }
    }
}