using Game1.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Game1.Block;

namespace Game1.Level
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

            CurrentRoom = Rooms[0];
            
            foreach (Room room in Rooms)
            {
                room.Boundary = new List<IBlock>
                {
                    new BoundaryLong(new Vector2(0,0)),
                    new BoundaryShort(new Vector2(0, GlobalDefinitions.Boundary/GlobalDefinitions.RoomWidth*GlobalDefinitions.GraphicsWidth)),
                    new BoundaryShort(new Vector2(GlobalDefinitions.GraphicsWidth - GlobalDefinitions.DoorDepth/GlobalDefinitions.RoomWidth*GlobalDefinitions.GraphicsWidth, GlobalDefinitions.Boundary/GlobalDefinitions.RoomWidth*GlobalDefinitions.GraphicsWidth)),
                    new BoundaryLong(new Vector2(0, GlobalDefinitions.GraphicsHeight - GlobalDefinitions.Boundary/GlobalDefinitions.RoomHeight*GlobalDefinitions.GraphicsHeight))
                };
            }


            doors = new List<Rectangle>
            {
                new Rectangle((int)(GlobalDefinitions.GraphicsWidth*0.5 - GlobalDefinitions.DoorWidth/GlobalDefinitions.RoomWidth*GlobalDefinitions.GraphicsWidth*0.5), 
                                0,
                                 GlobalDefinitions.DoorWidth/GlobalDefinitions.RoomWidth*GlobalDefinitions.GraphicsWidth,
                                 GlobalDefinitions.DoorDepth/GlobalDefinitions.RoomHeight*GlobalDefinitions.GraphicsHeight), // North, 0
                new Rectangle(GlobalDefinitions.GraphicsWidth - GlobalDefinitions.DoorDepth/GlobalDefinitions.RoomWidth*GlobalDefinitions.GraphicsWidth, 
                               (int)(GlobalDefinitions.GraphicsHeight*0.5 - GlobalDefinitions.DoorWidth/GlobalDefinitions.RoomHeight*GlobalDefinitions.GraphicsHeight*0.5),
                               GlobalDefinitions.DoorDepth/GlobalDefinitions.RoomWidth*GlobalDefinitions.GraphicsWidth,
                               GlobalDefinitions.DoorWidth/GlobalDefinitions.RoomHeight*GlobalDefinitions.GraphicsHeight), // East, 1
                new Rectangle((int)(GlobalDefinitions.GraphicsWidth*0.5 - GlobalDefinitions.DoorWidth/GlobalDefinitions.RoomWidth*GlobalDefinitions.GraphicsWidth*0.5),
                                GlobalDefinitions.GraphicsHeight - GlobalDefinitions.DoorDepth/GlobalDefinitions.RoomHeight*GlobalDefinitions.GraphicsHeight,
                                 GlobalDefinitions.DoorWidth/GlobalDefinitions.RoomWidth*GlobalDefinitions.GraphicsWidth,
                                 GlobalDefinitions.DoorDepth/GlobalDefinitions.RoomHeight*GlobalDefinitions.GraphicsHeight), // South, 2
                new Rectangle(0,
                               (int)(GlobalDefinitions.GraphicsHeight*0.5 - GlobalDefinitions.DoorWidth/GlobalDefinitions.RoomHeight*GlobalDefinitions.GraphicsHeight*0.5),
                               GlobalDefinitions.DoorDepth/GlobalDefinitions.RoomWidth*GlobalDefinitions.GraphicsWidth,
                               GlobalDefinitions.DoorWidth/GlobalDefinitions.RoomHeight*GlobalDefinitions.GraphicsHeight)  // West, 3
            };
        }



        public void North()
        {
            if (CurrentRoom.HasNorth)
            {
                Map.North();
                CurrentRoom = CurrentRoom.North;
                Link.GetRectangle() = new Rectangle(doors[2].X, doors[2].Y - Link.GetRectangle.Height, Link.GetRectangle.Width, Link.GetRectangle.Height);
            }
        }

        public void East()
        {
            if (CurrentRoom.HasEast)
            {
                Map.East();
                CurrentRoom = CurrentRoom.East;
                Link.GetRectangle = new Rectangle(doors[3].X + doors[3].Width, doors[3].Y, Link.GetRectangle.Width, Link.GetRectangle.Height);
            }
        }

        public void South()
        {
            if (CurrentRoom.HasSouth)
            {
                Map.South();
                CurrentRoom = CurrentRoom.South;
                Link. = new Rectangle(doors[0].X, doors[0].Y + doors[0].Height, Link.GetRectangle.Width, Link.GetRectangle.Height);
            }
        }

        public void West()
        {
            if (CurrentRoom.HasWest)
            {
                Map.West();
                CurrentRoom = CurrentRoom.West;
                Link.GetRectangle = new Rectangle(doors[1].X - Link.GetRectangle.Width, doors[1].Y, Link.GetRectangle.Width, Link.GetRectangle.Height);
            }
        }

        public void Other()
        {
            // Move to other room
        }

        public void Update()
        {
            CurrentRoom.Update();

            if (Link.GetRectangle().Intersects(doors[0]))
            {
                North();
            }
            else if (Link.GetRectangle().Intersects(doors[1]))
            {
                East();
            }
            else if (Link.GetRectangle().Intersects(doors[2]))
            {
                South();
            }
            else if (Link.GetRectangle().Intersects(doors[3]))
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
