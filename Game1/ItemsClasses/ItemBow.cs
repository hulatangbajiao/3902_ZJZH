using Game1.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class ItemBow : IItem
    {
        private IGeneralSprite GetSprite { get; set; }
        public Vector2 Position { get; set; }

        private MainStage game;

        public bool exist { get; set; }


        public ItemBow(Vector2 Position,MainStage game)
        {

            this.game = game;
            this.Position = Position;
            
            exist = true;
            
            GetSprite = new GeneralSprite(48,96,1);
            

        }
        public void PickUp()
        {
            game.Link.HasBow = true;
        }

        public void Update()
        {

            GetSprite.Update();

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (exist)
            {
                GetSprite.Draw(Texture2DStorage.GetBowSpriteSheet(),spriteBatch, Position);
            }
        }

        public Rectangle GetRectangle()
        {
            return this.GetSprite.GetRectangle();
        }
    }
}

