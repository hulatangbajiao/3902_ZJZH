namespace Game1
{
    public class UpMovingState : ILinkState
    {
        public ILink Link { get; set; }
        MainStage game;
        public ISprite GetSprite { get; set; }
        public UpMovingState(Link link, MainStage game)
        {
            this.Link = link;
            this.game = game;
            GetSprite = new UpIdleLinkSprite(link.Position);

        }
        //link has already faced up so no code for MoveUp()

        public void TakeDamage()
        {
            Link = new DamagedLink((Link)Link, game);

            //remains to be discussed
        }
        public void MoveUp()
        {
        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), link will be animated and move up in y axis.

        public void MoveDown()
        {
            Link.State = new DownIdleState((Link)Link);

        }


        public void MoveLeft()
        {
            Link.State = new LeftIdleState((Link)Link);
        }


        public void MoveRight()
        {
            Link.State = new RightIdleState((Link)Link);
        }

        public void Stop()
        {
            Link.State = new UpIdleState(Link, game); //when call stop(), the moving state transforms to idle state
        }

        public void Attack()
        {
            Link.State = new UpWoodenSwordState((Link)Link);
        }
        public void UseItem()
        {
            Link.State = new UpItemState((Link)Link);
        }

        public void Update()
        {
            GetSprite.Update();
        }
    }
}