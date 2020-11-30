using Game1.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Game1.Block;
using Game1.Detection;

namespace Game1.Level
{
    public class DungeonLevel : ILevel
    {
        public LevelLoader LevelLoader1 { get; set; }
        public IMap Map { get; set; }
        public ILink Link { get; set; }
        public List<IRoom> Rooms { get; set; }
        public IRoom CurrentRoom { get; set; }
        public IRoom TempRoom { get; set; }
        public List<Rectangle> doors { get; set; }
        public DetectCollision DetectCollision { get; set; }
        public MainStage game { get; set; }


        public DungeonLevel(MainStage game)
        {
            this.game = game;

        }

        public void initialize()
        {

            LevelLoader1 = new LevelLoader(game.enemyFactory,game);
            Map = new Map(this);
            Link = game.Link;
            Rooms = new List<IRoom>();
            CurrentRoom = new Room();
            DetectCollision = new DetectCollision();
            Rooms = LevelLoader1.LoadRooms(Link);
            Rooms.Add(new Room());
            CurrentRoom = Rooms[0];


            foreach (Room room in Rooms)
            {
                room.Boundary = new List<IBlock>
                {
                    new BoundaryLong(new Vector2(0,0)),
                    new BoundaryShort(new Vector2(0, (int)((float)GlobalDefinitions.Boundary/GlobalDefinitions.RoomWidth*GlobalDefinitions.GraphicsWidth))),
                    new BoundaryShort(new Vector2(GlobalDefinitions.GraphicsWidth - (int)((float)GlobalDefinitions.Boundary/GlobalDefinitions.RoomWidth*GlobalDefinitions.GraphicsWidth), (int)((float)GlobalDefinitions.Boundary/GlobalDefinitions.RoomWidth*GlobalDefinitions.GraphicsWidth))),
                    new BoundaryLong(new Vector2(0, GlobalDefinitions.GraphicsHeight - (int)((float)GlobalDefinitions.Boundary/GlobalDefinitions.RoomHeight*GlobalDefinitions.GraphicsHeight)))
                };

                room.Block.AddRange(room.Boundary);
            }


            doors = new List<Rectangle>
            {
                new Rectangle((int)(GlobalDefinitions.GraphicsWidth*0.5 - (float)GlobalDefinitions.DoorWidth/GlobalDefinitions.RoomWidth*GlobalDefinitions.GraphicsWidth*0.5),
                                0,
                                 (int)((float)GlobalDefinitions.DoorWidth/GlobalDefinitions.RoomWidth*GlobalDefinitions.GraphicsWidth),
                                 (int)((float)GlobalDefinitions.DoorDepth/GlobalDefinitions.RoomHeight*GlobalDefinitions.GraphicsHeight)), // North, 0
                new Rectangle(GlobalDefinitions.GraphicsWidth - (int)((float)GlobalDefinitions.DoorDepth/GlobalDefinitions.RoomWidth*GlobalDefinitions.GraphicsWidth),
                               (int)(GlobalDefinitions.GraphicsHeight*0.5 - (float)GlobalDefinitions.DoorWidth/GlobalDefinitions.RoomHeight*GlobalDefinitions.GraphicsHeight*0.5),
                               (int)((float)GlobalDefinitions.DoorDepth/GlobalDefinitions.RoomWidth*GlobalDefinitions.GraphicsWidth),
                               (int)((float)GlobalDefinitions.DoorWidth/GlobalDefinitions.RoomHeight*GlobalDefinitions.GraphicsHeight)), // East, 1
                new Rectangle((int)(GlobalDefinitions.GraphicsWidth*0.5 - (float)GlobalDefinitions.DoorWidth/GlobalDefinitions.RoomWidth*GlobalDefinitions.GraphicsWidth*0.5),
                                GlobalDefinitions.GraphicsHeight - (int)((float)GlobalDefinitions.DoorDepth/GlobalDefinitions.RoomHeight*GlobalDefinitions.GraphicsHeight),
                                 (int)((float)GlobalDefinitions.DoorWidth/GlobalDefinitions.RoomWidth*GlobalDefinitions.GraphicsWidth),
                                 (int)((float)GlobalDefinitions.DoorDepth/GlobalDefinitions.RoomHeight*GlobalDefinitions.GraphicsHeight)), // South, 2
                new Rectangle(0,
                               (int)(GlobalDefinitions.GraphicsHeight*0.5 - (float)GlobalDefinitions.DoorWidth/GlobalDefinitions.RoomHeight*GlobalDefinitions.GraphicsHeight*0.5),
                               (int)((float)GlobalDefinitions.DoorDepth/GlobalDefinitions.RoomWidth*GlobalDefinitions.GraphicsWidth),
                               (int)((float)GlobalDefinitions.DoorWidth/GlobalDefinitions.RoomHeight*GlobalDefinitions.GraphicsHeight))  // West, 3
            };
        }

        public void North()
        {
            if (TempRoom.HasNorth)
            {

                Map.North();
                GlobalDefinitions.Position = new Vector2(doors[2].X, doors[2].Y-12-Link.GetRectangle().Height);


            }
        }

        public void East()
        {
            if (TempRoom.HasEast)
            {
                Map.East();
                GlobalDefinitions.Position = new Vector2(doors[3].X + doors[3].Width + 20, doors[3].Y);
            }
        }

        public void South()
        {
            if (TempRoom.HasSouth)
            {
                Map.South();
                GlobalDefinitions.Position = new Vector2(doors[0].X, doors[0].Y +12+ doors[0].Height);

            }
        }

        public void West()
        {
            if (TempRoom.HasWest)
            {
                Map.West();
                GlobalDefinitions.Position = new Vector2(doors[1].X - Link.GetRectangle().Width - 20, doors[1].Y);
            }
        }

        public void Other()
        {
            // Move to other room
        }

        public void Update(GameTime _gameTime)
        {
            if (CurrentRoom != null)
            {
                CurrentRoom.Update();

            }
            Map.Update(_gameTime);
            Rectangle linkRectangle = Link.GetRectangle();

            if (linkRectangle.Intersects(doors[0]))
            {
                if (CurrentRoom.HasNorth)
                {
                    TempRoom = CurrentRoom;
                    CurrentRoom = Rooms[Rooms.Count - 1];//switch to the empty room
                    North();
                }
            }
            else if (linkRectangle.Intersects(doors[1]))
            {
                if (CurrentRoom.HasEast)
                {
                    TempRoom = CurrentRoom;
                    CurrentRoom = Rooms[Rooms.Count - 1];//switch to the empty room
                    East();
                }
            }
            else if (linkRectangle.Intersects(doors[2]))
            {
                if (CurrentRoom.HasSouth)
                {
                    TempRoom = CurrentRoom;
                    CurrentRoom = Rooms[Rooms.Count - 1];//switch to the empty room
                    South();
                }
            }
            else if (linkRectangle.Intersects(doors[3]))
            {
                if (CurrentRoom.HasWest)
                {
                    TempRoom = CurrentRoom;
                    CurrentRoom = Rooms[Rooms.Count - 1];//switch to the empty room
                    West();
                }
            }
            if (CurrentRoom != null)
            {
                DetectCollision.linkBlockDetection(this.Link, CurrentRoom.Block);
                DetectCollision.LinkEnemyDetection(this.Link, CurrentRoom.Enemies);
                DetectCollision.linkReceivedItemDetection(this.Link, CurrentRoom.ReceivedItems);
                DetectCollision.linkObtainedItemDetection(this.Link, CurrentRoom.ObtainedItems);
                DetectCollision.EnemyBlockDetection(CurrentRoom.Enemies, CurrentRoom.Block);
                DetectCollision.EnemyProjectileDetection(CurrentRoom.Enemies, this.game.ProjectileFactory);
            }


        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Map.Draw(spriteBatch);
            if (CurrentRoom != null)
            {
                CurrentRoom.Draw(spriteBatch);

            }
        }
    }
}
