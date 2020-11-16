using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    public class UpIdleState : ILinkState
    {
        public ILink Link { get; set; }
        private Link decoratedLink;
        MainStage game;
        public IGeneralSprite GetSprite { get; set; }
        public UpIdleState(ILink link, MainStage game)
        {
            this.Link = link;
            this.decoratedLink = (Link)link;
            this.game = game;
            GetSprite = new GeneralSprite(96,96,1);

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
            Link.State = new UpWoodenSwordState(Link, game);

        }
        public void UseItem()
        {
            Link.State = new UpUseItemState(Link, game);
        }

        public void Update()
        {
            GetSprite.Update();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            GetSprite.Draw(Texture2DStorage.GetUpIdleLinkSpriteSheet(),spriteBatch, GlobalDefinitions.Position);

        }
    }
}