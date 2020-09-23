namespace Game1
{
    internal class LeftIdleState : ILinkState
    {
        private Link link;

        public LeftIdleState(Link link)
        {
            this.link = link;
        }
    }
}