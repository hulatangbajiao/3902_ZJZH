using Game1.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class ItemFairy : IItem
    {
        private IGeneralSprite GetSprite { get; set; }
        private int x, y;
        public Vector2 Position { get; set; }
        private MainStage game;


        public bool exist { get; set; }


        public ItemFairy(Vector2 Position, MainStage game)
        {

            this.game = game;
            this.Position = Position;
            
            exist = true;
            
            GetSprite = new GeneralSprite(20,40,2);
            

        }
        public void PickUp()
        {

            if (game.Link.HeartContainer * 2 - game.Link.Life > 5)
            {
                game.Link.Life += 5;

            }
            else 
            {
                game.Link.Life = game.Link.HeartContainer * 2;
            }
        }
        public void Update()
        {
            Random rdm = new Random();
            if (x >= 800)
            {
                x = x - rdm.Next(60, 110);
            }
            else if (x <= 0)
            {
                x = x + rdm.Next(60, 110);
            }
            else if (y >= 360)
            {
                y = y - rdm.Next(60, 110);
            }
            else if (y <= 0)
            {
                y = y + rdm.Next(60, 110);
            }
            else
            {
                x = x + rdm.Next(-15, 15);
                y = y + rdm.Next(-10, 10);
            }

            Position = Position + new Vector2(x,y);

            GetSprite.Update();

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (exist)
            {
                GetSprite.Draw(Texture2DStorage.GetFairySpriteSheet(),spriteBatch, Position);
            }
        }

        public Rectangle GetRectangle()
        {
            return this.GetSprite.GetRectangle();
        }
    }
}

