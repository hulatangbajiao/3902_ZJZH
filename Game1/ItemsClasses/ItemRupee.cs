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
    public class ItemRupee : IItem
    {
        private IGeneralSprite GetSprite { get; set; }
        public Vector2 Position { get; set; }
        private MainStage game;


        public bool exist { get; set; }


        public ItemRupee(Vector2 Position, MainStage game)
        {
            this.game = game;

            this.Position = Position;
            
            exist = true;
            
            GetSprite = new GeneralSprite(50,70,2);
            

        }
        public void PickUp()
        {
            game.Link.RupeeNumber += 1;
        }
        public void Update()
        {

            GetSprite.Update();

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (exist)
            {
                GetSprite.Draw(Texture2DStorage.GetRupeeSpriteSheet(),spriteBatch, Position);
            }
        }
        public Rectangle GetRectangle()
        {
            return this.GetSprite.GetRectangle();
        }

    }
}

