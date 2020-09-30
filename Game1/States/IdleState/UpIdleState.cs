namespace Game1
{
    internal class UpIdleState : ILinkState
    {
        public ILink link;
        MainStage game;
        int timer = 100;
        public UpIdleLinkSprite GetSprite { get; set; }
        public UpIdleState(Link link, MainStage game)
        {
            this.link = link;
            this.game = game;
            GetSprite = new UpIdleLinkSprite(this.link.position);
            
        }
        //link has already faced up so no code for MoveUp()

        public void TakeDamage()
        {
            link = new DamagedLink(link, game);
            GetSprite = new DamagedLinkSprite(this.link.position);
            timer--;
            if (timer == 0)
            {
                GetSprite = new UpIdleLinkSprite(this.link.position);
            }
            //remains to be discussed
        }
        public void MoveUp()
        {
        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), link will be animated and move up in y axis.
        public void KeepMoveUp()
        {
            link.state = new UpMovingState((Link)link);

        }

        public void MoveDown()
        {
            link.state = new DownIdleState((Link)link);

        }

        public void KeepMoveDown()
        {
            link.state = new DownMovingState((Link)link);
        }
        public void MoveLeft()
        {
            link.state = new LeftIdleState((Link)link);
        }
        public void KeepMoveLeft()
        {
            link.state = new LeftMovingState((Link)link);
        }

        public void MoveRight()
        {
            link.state = new RightIdleState((Link)link);
        }
        public void KeepMoveRight()
        {
            link.state = new RightMovingState((Link)link);
        }
        public void UseWoodenSword()
        {
            link.state = new UpWoodenSwordState((Link)link);
        }

        public void UseWhiteSword()
        {
            link.state = new UpWhiteSwordState((Link)link);
        }

        public void UseMagicalRod()
        {
            link.state = new UpMagicalRodState((Link)link);
        }

        public void UseItem()
        {
            link.state = new UpItemState((Link)link);
        }
    }
}