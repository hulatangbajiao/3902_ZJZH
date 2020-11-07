using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Game1.LevelClasses
{
    class DungeonLevel
    {
        public LevelLoader LevelLoader1 { get; set; }
        public IMap Map { get; set; }
        public Link Link { get; set; }
        public List<IRoom> Rooms { get; set; }
        public IRoom CurrentRoom { get; set; }
        private List<Rectangle> doors;

        public DungeonLevel(Link link, int levelNum)
        {
            LevelLoader1 = new LevelLoader(1);
            Map = new Map(levelNum);
            Link = link;
            Rooms = new List<IRoom>();
            CurrentRoom = new Room();
        }

        public void Initialize(int windowWidth, int roomHeight, int hudHeight)
        {
            Map.Initialize(0, 0, GlobalDefinitions., roomHeight);
            Rooms = LevelLoader1.LoadRooms(Player);

            if (Rooms.Count > 0)
            {
                CurrentRoom = Rooms[0];
            }

            foreach (IRoom room in Rooms)
            {
                room.Wall = new List<IBlock>{
                new Block(false, new Rectangle(0, hudHeight, 93, 525), null),
                new Block(false, new Rectangle(0, hudHeight, 765, 93), null),
                new Block(false, new Rectangle(0, 432 + hudHeight, 765, 93), null),
                new Block(false, new Rectangle(672, hudHeight, 93, 525), null),
                };
                room.Boundary = new List<IBlock>{
                new Boundary(new Rectangle(-93, hudHeight, 93, 525)),
                new Boundary(new Rectangle(0, hudHeight-93, 765, 93)),
                new Boundary(new Rectangle(0, 525 + hudHeight, 765, 93)),
                new Boundary(new Rectangle(765, hudHeight, 93, 525))
                };
            }

            doors = new List<Rectangle>
            {
                new Rectangle((int)(0.46875*windowWidth), hudHeight, (int)(0.0625*windowWidth), (int)((2.0/11.0)*roomHeight)), // North
                new Rectangle((int)(0.875*windowWidth), hudHeight + (int)((5.0/11.0)*roomHeight), (int)(0.125*windowWidth), (int)((1.0/11.0)*roomHeight)), // East
                new Rectangle((int)(0.46875*windowWidth), hudHeight + (int)((9.0/11.0)*roomHeight), (int)(0.0625*windowWidth), (int)((2.0/11.0)*roomHeight)), // South
                new Rectangle(0, hudHeight + (int)((5.0/11.0)*roomHeight), (int)(0.125*windowWidth), (int)((1.0/11.0)*roomHeight))  // West
            };
        }

        public void North()
        {
            if (CurrentRoom.HasNorth)
            {
                Map.North();
                CurrentRoom = CurrentRoom.North;
                Player.DestinationRectangle = new Rectangle(doors[2].X, doors[2].Y - Player.DestinationRectangle.Height, Player.DestinationRectangle.Width, Player.DestinationRectangle.Height);
            }
        }

        public void East()
        {
            if (CurrentRoom.HasEast)
            {
                Map.East();
                CurrentRoom = CurrentRoom.East;
                Player.DestinationRectangle = new Rectangle(doors[3].X + doors[3].Width, doors[3].Y, Player.DestinationRectangle.Width, Player.DestinationRectangle.Height);
            }
        }

        public void South()
        {
            if (CurrentRoom.HasSouth)
            {
                Map.South();
                CurrentRoom = CurrentRoom.South;
                Player.DestinationRectangle = new Rectangle(doors[0].X, doors[0].Y + doors[0].Height, Player.DestinationRectangle.Width, Player.DestinationRectangle.Height);
            }
        }

        public void West()
        {
            if (CurrentRoom.HasWest)
            {
                Map.West();
                CurrentRoom = CurrentRoom.West;
                Player.DestinationRectangle = new Rectangle(doors[1].X - Player.DestinationRectangle.Width, doors[1].Y, Player.DestinationRectangle.Width, Player.DestinationRectangle.Height);
            }
        }

        public void Other()
        {
            // Move to other room
        }

        public void Update()
        {
            HUD.Update();
            CurrentRoom.Update();

            if (Player.DestinationRectangle.Intersects(doors[0]))
            {
                North();
            }
            else if (Player.DestinationRectangle.Intersects(doors[1]))
            {
                East();
            }
            else if (Player.DestinationRectangle.Intersects(doors[2]))
            {
                South();
            }
            else if (Player.DestinationRectangle.Intersects(doors[3]))
            {
                West();
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Map.Draw(spriteBatch);
            HUD.Draw(spriteBatch);
            CurrentRoom.Draw(spriteBatch);
        }
    }
}
