namespace Game1
{
    internal class RightMovingState : ILinkState
    {
        private Link link;

        public RightMovingState(Link link)
        {
            this.link = link;
        }
    }
}