using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Game1.Sprite_;
using Game1.Interfaces;
using Game1;

namespace Game1.Sprite_
{
    public class MapSprite : ISprite
    {


        public Texture2D Texture { get; set; }
        public Rectangle SourceRectangle { get; set; }

        public Rectangle DestinationRectangle { get; set; }

        public MapSprite()
        {

        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {

            Texture = Texture2DStorage.GetFullMapSpriteSheet();


             SourceRectangle = new Rectangle(0, (int)0.29276*GlobalDefinitions.GraphicsHeight, (int)0.119070*GlobalDefinitions.GraphicsWidth, (int)0.144737*GlobalDefinitions.GraphicsHeight);
             DestinationRectangle = new Rectangle(0, 0, GlobalDefinitions.GraphicsWidth, GlobalDefinitions.GraphicsHeight);


            spriteBatch.Draw(Texture, DestinationRectangle, SourceRectangle, Color.White);

        }



    }
}
