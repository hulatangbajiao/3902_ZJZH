using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class LeftWoodenSwordLinkSprite : ISprite
    {
        private int currentFrame = 0;
        private int totalFrame = 12;
        private ILink Link;

        public LeftWoodenSwordLinkSprite(MainStage game)
        {
            Link = game.Link;

        }

        public void Update()
        {
            currentFrame++;

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame < 3)
            {
                sourceRectangle = new Rectangle(0, 0, 114, 102);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X - 144 + 96, (int)GlobalDefinitions.Position.Y, 114, 102); 
            }
            else if (3 <= currentFrame && currentFrame < 6)
            {
                sourceRectangle = new Rectangle(114, 0, 138, 102);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X - 138 + 96, (int)GlobalDefinitions.Position.Y, 138, 102);
            }
            else if (6 <= currentFrame && currentFrame < 9)
            {
                sourceRectangle = new Rectangle(252, 0, 162, 102);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X - 162 + 96, (int)GlobalDefinitions.Position.Y, 162, 102);
            }
            else
            {
                sourceRectangle = new Rectangle(414, 0, 96, 102);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X - 96 + 96, (int)GlobalDefinitions.Position.Y, 96, 102);
            }

            spriteBatch.Draw(Texture2DStorage.GetLeftWoodenSwordLinkSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);//use Texture2DStorage class to load texture2D
            if (currentFrame == totalFrame)
            {
                Link.State.Stop();
            }
        }
    }
}
