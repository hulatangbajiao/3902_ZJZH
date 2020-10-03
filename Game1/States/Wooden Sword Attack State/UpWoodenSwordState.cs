using Game1.Command;
namespace Game1
{
    public class UpWoodenSwordState : ILinkState
    {
        public ILink Link { get; set; }
        MainStage game;
        public ISprite GetSprite { get; set; }
        public UpWoodenSwordState(ILink link, MainStage game)
        {
            this.Link = link;
            this.game = game;
            GetSprite = new UpWoodenSwordLinkSprite();

        }
<<<<<<< HEAD
        //link has already faced up so now code for MoveUp()

        public void TakeDamage()
        {
            game.Link = new DamagedLink((Link)Link, game);
=======
        //link has already faced up so no code for MoveUp()

        public void TakeDamage()
        {
            Link = new DamagedLink((Link)Link, game);
>>>>>>> 7138942d4ffb4ce348a80ca24494c5f810f3311e

            //remains to be discussed
        }
        //Link will move up if 'w' was pressed while pressing 'z'
        public void MoveUp()
        {
            Link.State = new UpMovingState(Link, game);
        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), link will be animated and move up in y axis.

        public void MoveDown()
        {
            Link.State = new DownMovingState(Link, game);
        }

        public void MoveLeft()
        {
            Link.State = new LeftMovingState(Link, game);
        }


        public void MoveRight()
        {
            Link.State = new RightMovingState(Link, game);
        }

        public void Stop()
        {
            Link.State = new UpIdleState(Link, game); //when call stop(), the moving state transforms to idle state
        }

        public void Attack()
        {
        }
        public void UseItem()
        {

        }

        public void Update()
        {
            GetSprite.Update();
        }
    }
}