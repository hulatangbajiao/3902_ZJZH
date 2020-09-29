namespace Game1
{
    internal class DamagedUpIdleState : ILinkState
    {
        private Link link;

        public DamagedUpIdleState(Link link)
        {
            this.link = link;
        }
    }
}