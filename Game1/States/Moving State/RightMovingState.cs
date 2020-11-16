using Game1.Command;
using Game1.Sprite_;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    public class RightMovingState : ILinkState
    {
        public ILink Link { get; set; }
        MainStage game;
        public IGeneralSprite GetSprite { get; set; }
        public RightMovingState(ILink link, MainStage game)
        {
            this.Link = link;
            this.game = game;
            GetSprite = new GeneralSprite(96,96,2);

        }
        //link has already faced up so no code for MoveUp()

        
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
            GlobalDefinitions.Position += new Vector2(10, 0);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            GetSprite.Draw(Texture2DStorage.GetRightMovingLinkSpriteSheet(),spriteBatch, GlobalDefinitions.Position);

        }
    }
}