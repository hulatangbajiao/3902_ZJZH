using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class BoomerSprite : ISprite
    {
        private int currentFrame = 0;
        private int totalFrame = 3;
        private Rectangle destinationRectangle;
        public BoomerSprite()
        {


        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrame)
            {
                currentFrame = 0; 
            }

        }

        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            Rectangle sourceRectangle;
            
            Texture2D Texture = Texture2DStorage.GetBoomerSpriteSheet();



            sourceRectangle = new Rectangle(currentFrame * Texture.Width / 3, 0, Texture.Width/3, Texture.Height);
            destinationRectangle = new Rectangle((int)Position.X, (int)Position.Y, 40, 40); 
            


           

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);//use Texture2DStorage class to load texture2D
        }
        public Rectangle GetRectangle()
        {
            return destinationRectangle;
        }
    }
}