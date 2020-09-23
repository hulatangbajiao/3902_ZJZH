namespace Game1
{
    internal class RightIdleState : ILinkState
    {
        private Link link;

        public RightIdleState(Link link)
        {
            this.link = link;
        }
    }
}