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
        private List<Rectangle> doors;
        public DetectCollision DetectCollision { get; set; }
        private MainStage game;
        public DungeonLevel(MainStage game)
        {
            this.game = game;
            LevelLoader1 = new LevelLoader(game.enemyFactory);
            Map = new Map();
            Link = game.Link;
            Rooms = new List<IRoom>();
            CurrentRoom = new Room();
            DetectCollision = new DetectCollision();
            Rooms = LevelLoader1.LoadRooms(Link);

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
            if (CurrentRoom.HasNorth)
            {
                Map.North();
                CurrentRoom = CurrentRoom.North;
                GlobalDefinitions.Position = new Vector2(doors[2].X, doors[2].Y - Link.GetRectangle().Height);

            }
        }

        public void East()
        {
            if (CurrentRoom.HasEast)
            {
                Map.East();
                CurrentRoom = CurrentRoom.East;
                GlobalDefinitions.Position = new Vector2(doors[3].X + doors[3].Width, doors[3].Y);
            }
        }

        public void South()
        {
            if (CurrentRoom.HasSouth)
            {
                Map.South();
                CurrentRoom = CurrentRoom.South;
                GlobalDefinitions.Position = new Vector2(doors[0].X, doors[0].Y + doors[0].Height);

            }
        }

        public void West()
        {
            if (CurrentRoom.HasWest)
            {
                Map.West();
                CurrentRoom = CurrentRoom.West;
                GlobalDefinitions.Position = new Vector2(doors[1].X - Link.GetRectangle().Width, doors[1].Y);
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
            DetectCollision.linkBlockDetection(this.Link, CurrentRoom.Block);
            DetectCollision.LinkEnemyDetection(this.Link, CurrentRoom.Enemies);
            DetectCollision.linkReceivedItemDetection(this.Link, CurrentRoom.ReceivedItems);
            DetectCollision.linkObtainedItemDetection(this.Link, CurrentRoom.ObtainedItems);
            DetectCollision.EnemyBlockDetection(CurrentRoom.Enemies, CurrentRoom.Block);
            DetectCollision.EnemyProjectileDetection(CurrentRoom.Enemies, this.game.ProjectileFactory);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Map.Draw(spriteBatch);
            CurrentRoom.Draw(spriteBatch);
        }
    }
}
