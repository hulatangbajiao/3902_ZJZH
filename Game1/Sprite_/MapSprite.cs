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
    public class MapSprite
    {


        public Texture2D Texture { get; set; }
        public Rectangle SourceRectangle { get; set; }

        public Rectangle DestinationRectangle { get; set; }

        public MapSprite()
        {
            SourceRectangle = new Rectangle(GlobalDefinitions.RoomWidth*2, GlobalDefinitions.RoomHeight*5, GlobalDefinitions.RoomWidth, GlobalDefinitions.RoomHeight);
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {

            Texture = Texture2DStorage.GetFullMapSpriteSheet();


            
            DestinationRectangle = new Rectangle(0, 0, GlobalDefinitions.GraphicsWidth, GlobalDefinitions.GraphicsHeight);


            spriteBatch.Draw(Texture, DestinationRectangle, SourceRectangle, Color.White);

        }



    }
}