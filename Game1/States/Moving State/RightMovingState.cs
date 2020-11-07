using Game1.Command;
using Game1.Sprite_;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    public class RightMovingState : ILinkState
    {
        public ILink Link { get; set; }
        MainStage game;
        public ISprite GetSprite { get; set; }
        public RightMovingState(ILink link, MainStage game)
        {
            this.Link = link;
            this.game = game;
            GetSprite = new RightMovingLinkSprite();

        }
        //link has already faced up so no code for MoveUp()

        public void TakeDamage()
        {
            game.Link = new DamagedLink((Link)Link, game);

            //remains to be discussed
        }
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
        }

        public void Stop()
        {
            Link.State = new RightIdleState(Link, game); //when call stop(), the moving state transforms to idle state
        }

        public void Attack()
        {
            Link.State = new RightWoodenSwordState(Link, game);
        }
        public void UseItem()
        {
            Link.State = new RightUseItemState(Link, game);
        }

        public void Update()
        {
            GetSprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            GetSprite.Draw(spriteBatch, GlobalDefinitions.Position);

        }
    }
}