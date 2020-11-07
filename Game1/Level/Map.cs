using Game1.Interfaces;
using Game1.Sprite_;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1.Level
{
    class Map : IMap
    {
        public Rectangle DestinationRectangle { get; set; }
        public MapSprite MapSprite { get; set; }
        const int ROOM_WIDTH = GlobalDefinitions.RoomWidth, ROOM_HEIGHT = GlobalDefinitions.RoomHeight;

        public Map()
        {
            MapSprite = new MapSprite();//need to know about the factory
        }


        public void North()
        {
            int newRoomY = MapSprite.SourceRectangle.Y - ROOM_HEIGHT;
            MapSprite.SourceRectangle = new Rectangle(MapSprite.SourceRectangle.X, newRoomY, MapSprite.SourceRectangle.Width, MapSprite.SourceRectangle.Height);
        }

        public void East()
        {
            int newRoomX = MapSprite.SourceRectangle.X + ROOM_WIDTH;
            MapSprite.SourceRectangle = new Rectangle(newRoomX, MapSprite.SourceRectangle.Y, MapSprite.SourceRectangle.Width, MapSprite.SourceRectangle.Height);
        }

        public void South()
        {
            int newRoomY = MapSprite.SourceRectangle.Y + ROOM_HEIGHT;
            MapSprite.SourceRectangle = new Rectangle(MapSprite.SourceRectangle.X, newRoomY, MapSprite.SourceRectangle.Width, MapSprite.SourceRectangle.Height);
        }

        public void West()
        {
            int newRoomX = MapSprite.SourceRectangle.X - ROOM_WIDTH;
            MapSprite.SourceRectangle = new Rectangle(newRoomX, MapSprite.SourceRectangle.Y, MapSprite.SourceRectangle.Width, MapSprite.SourceRectangle.Height);
        }

        public void Other()
        {
            // Transition to current room's other room, if it exists
        }

        public void Update()
        {
            // TODO?
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            MapSprite.Draw(spriteBatch);
        }
    }
}
