using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class GeneralSprite : IGeneralSprite
    {
        private int currentFrame = 0;
        private int totalFrame;
        private Rectangle destinationRectangle;
        
        private int Width;
        private int Height;
        public Color color { get; set; }
        private List<Color> colorList = new List<Color>();
        private int index = 0;
        public GeneralSprite(int Height, int Width, int totalPicture)
        {
            color = Color.White;
            this.totalFrame = totalPicture * 5;
            this.Width = Width;
            this.Height = Height;
            colorList.Add(Color.Green);
            colorList.Add(Color.Red);
            colorList.Add(Color.LightBlue);
            colorList.Add(Color.Honeydew);
        }
        public void ChangeColor()
        {
            index++;
            color = colorList[index % 4];
        }
        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrame)
                currentFrame = 0;
        }

        public void Draw(Texture2D SpriteSheet, SpriteBatch spriteBatch, Vector2 Position)
        {
            Rectangle sourceRectangle = new Rectangle(SpriteSheet.Width*5/this.totalFrame * (currentFrame / 5), 0, SpriteSheet.Width * 5 / this.totalFrame, SpriteSheet.Height);
            destinationRectangle = new Rectangle((int)Position.X, (int)Position.Y, Height, Width);
            spriteBatch.Draw(SpriteSheet, destinationRectangle, sourceRectangle, color);
        }
        public Rectangle GetRectangle()
        {
            return destinationRectangle;
        }
    }
}



