using Game1.Command;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    public class DownWoodenSwordState : ILinkState
    {
        public ILink Link { get; set; }
        MainStage game;
        public ISprite GetSprite { get; set; }
        public DownWoodenSwordState(ILink link, MainStage game)
        {
            this.Link = link;
            this.game = game;
            GetSprite = new DownWoodenSwordLinkSprite();

        }
        //link has already faced up so no code for MoveUp()

        public void TakeDamage()
        {
            game.Link = new DamagedLink((Link)Link, game);

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
            Link.State = new DownIdleState(Link, game); //when call stop(), the moving state transforms to idle state
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
        public void Draw(SpriteBatch spriteBatch)
        {
            GetSprite.Draw(spriteBatch);

        }
    }
}