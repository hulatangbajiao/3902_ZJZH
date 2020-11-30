using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    public class RightIdleState : ILinkState
    {
        public ILink Link { get; set; }
        MainStage game;
        public IGeneralSprite GetSprite { get; set; }
        public RightIdleState(ILink link, MainStage game)
        {
            this.Link = link;
            this.game = game;
            GetSprite = new GeneralSprite(72,72,1);

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
            Link.State = new RightMovingState(Link, game);

        }

        public void Stop()
        {
            // no-op
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
            GetSprite.Draw(Texture2DStorage.GetRightIdleLinkSpriteSheet(),spriteBatch, GlobalDefinitions.Position);

        }
    }
}