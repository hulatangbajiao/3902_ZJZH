using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class DownArrowSprite : IProjectileSprite
    {
        

        public DownArrowSprite()
        {


        }

        public void Update()
        {
            

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;
            Texture2D Texture = Texture2DStorage.GetDownWoodenArrowSpriteSheet();



            sourceRectangle = new Rectangle(0, 0, Texture.Width, Texture.Height);
            destinationRectangle = new Rectangle((int)Position.X, (int)Position.Y, Texture.Width, Texture.Height);   
            


           

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);//use Texture2DStorage class to load texture2D
        }
    }
}