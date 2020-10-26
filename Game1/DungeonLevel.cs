using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Game1
{
    class DungeonLevel : ILevel
    {
        public LevelLoader LevelLoader1 { get; set; }
        public IMap Map { get; set; }
        public ILink Link { get; set; }
        public List<IRoom> Rooms { get; set; }
        public IRoom CurrentRoom { get; set; }
        private List<Rectangle> doors;

        public DungeonLevel(ILink link)
        {
            LevelLoader1 = new LevelLoader();
            Map = new Map();
            Link = link;
            Rooms = new List<IRoom>();
            CurrentRoom = new Room();

            Rooms = LevelLoader1.LoadRooms(Link);

            if (Rooms.Count > 0)
            {
                CurrentRoom = Rooms[0];
            }

           

            doors = new List<Rectangle>
            {
                new Rectangle(), // North, 0
                new Rectangle(), // East, 1
                new Rectangle(), // South, 2
                new Rectangle()  // West, 3
            };
        }

       

        private void North()
        {
            if (CurrentRoom.HasNorth)
            {
                Map.North();
                CurrentRoom = CurrentRoom.North;
                Link.DestinationRectangle = new Rectangle(doors[2].X, doors[2].Y - Link.DestinationRectangle.Height, Link.DestinationRectangle.Width, Link.DestinationRectangle.Height);
            }
        }

        private void East()
        {
            if (CurrentRoom.HasEast)
            {
                Map.East();
                CurrentRoom = CurrentRoom.East;
                Link.DestinationRectangle = new Rectangle(doors[3].X + doors[3].Width, doors[3].Y, Link.DestinationRectangle.Width, Link.DestinationRectangle.Height);
            }
        }

        private void South()
        {
            if (CurrentRoom.HasSouth)
            {
                Map.South();
                CurrentRoom = CurrentRoom.South;
                Link.DestinationRectangle = new Rectangle(doors[0].X, doors[0].Y + doors[0].Height, Link.DestinationRectangle.Width, Link.DestinationRectangle.Height);
            }
        }

        private void West()
        {
            if (CurrentRoom.HasWest)
            {
                Map.West();
                CurrentRoom = CurrentRoom.West;
                Link.DestinationRectangle = new Rectangle(doors[1].X - Link.DestinationRectangle.Width, doors[1].Y, Link.DestinationRectangle.Width, Link.DestinationRectangle.Height);
            }
        }

        public void Other()
        {
            // Move to other room
        }

        public void Update()
        {
            CurrentRoom.Update();

            if (Link.DestinationRectangle.Intersects(doors[0]))
            {
                North();
            }
            else if (Link.DestinationRectangle.Intersects(doors[1]))
            {
                East();
            }
            else if (Link.DestinationRectangle.Intersects(doors[2]))
            {
                South();
            }
            else if (Link.DestinationRectangle.Intersects(doors[3]))
            {
                West();
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Map.Draw(spriteBatch);
            CurrentRoom.Draw(spriteBatch);
        }
    }
}
