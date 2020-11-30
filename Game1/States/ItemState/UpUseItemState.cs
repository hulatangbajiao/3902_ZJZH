using Game1.Command;
using Game1.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class UpUseItemState : ILinkState
    {
        public ILink Link { get; set; }
        MainStage game;
        public IGeneralSprite GetSprite { get; set; }
        public IProjectile Arrow { get; set; }
        public UpUseItemState(ILink link, MainStage game)
        {
            this.Link = link;
            this.game = game;
            GetSprite = new GeneralSprite(72, 72, 1);


        }

        
        //link has already faced up so no code for MoveUp()
        public void MoveUp()
        {

        }

        public void MoveDown()
        {


        }

        public void MoveLeft()
        {

        }

        public void MoveRight()
        {

        }

        public void Stop()
        {
            Link.State = new UpIdleState(Link, game);
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
            GetSprite.Draw(Texture2DStorage.GetUpUseItemLinkSpriteSheet(),spriteBatch, GlobalDefinitions.Position);

            if (Link.Item == 1)
            {
                this.game.ProjectileFactory.AddArrow(GlobalDefinitions.Position, new Vector2(0, -1));
            }
            if (Link.Item == 2)
            {
                this.game.ProjectileFactory.AddBomb(GlobalDefinitions.Position, new Vector2(0, -1));
            }
            if (Link.Item == 3)
            {
                this.game.ProjectileFactory.AddBoomer(GlobalDefinitions.Position,new Vector2(0, -1));
            }


        }
    }
}