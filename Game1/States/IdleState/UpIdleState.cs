namespace Game1
{
    internal class UpIdleState : ILinkState
    {
        private Link link;

        public UpIdleLinkSprite GetSprite { get; set; }
        public UpIdleState(Link link)
        {
            this.link = link;
            GetSprite = new UpIdleLinkSprite();
            
        }
        //link has already faced up so no code for MoveUp()
        public void MoveUp()
        {
        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), link will be animated and move up in y axis.
        public void KeepMoveUp()
        {
            link.state = new UpMovingState(link);

        }

        public void MoveDown()
        {
            link.state = new DownIdleState(link);

        }

        public void KeepMoveDown()
        {
            link.state = new DownMovingState(link);
        }
        public void MoveLeft()
        {
            link.state = new LeftIdleState(link);
        }
        public void KeepMoveLeft()
        {
            link.state = new LeftMovingState(link);
        }

        public void MoveRight()
        {
            link.state = new RightIdleState(link);
        }
        public void KeepMoveRight()
        {
            link.state = new RightMovingState(link);
        }
        public void UseWoodenSword()
        {
            link.state = new UpWoodenSwordState(link);
        }

        public void UseWhiteSword()
        {
            link.state = new UpWhiteSwordState(link);
        }

        public void UseMagicalRod()
        {
            link.state = new UpMagicalRodState(link);
        }

        public void UseItem()
        {
            link.state = new UpItemState(link);
        }
    }
}