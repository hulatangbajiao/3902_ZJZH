using Game1.Block;
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
    public class UnpassableBlock : IBlock
    {
        public Vector2 Position { get; set; }

        private IGeneralSprite GetSprite { get; set; }

        public bool exist { get; set; }
        

        public UnpassableBlock(Vector2 Position)
        {

            this.GetSprite = new GeneralSprite(96,96,1);
            this.Position = Position;
            
            exist = true;
            

        }
        public void Update()
        { 
        }
        public void Draw(SpriteBatch spritebatch) 
        {
            //this.GetSprite.Draw(Texture2DStorage.GetBlueFaceBlockSpriteSheet(),spritebatch, Position);

        }

        public Rectangle GetRectangle()
        {
            return new Rectangle((int)Position.X, (int)Position.Y, 96,96);
        }
    }
}
