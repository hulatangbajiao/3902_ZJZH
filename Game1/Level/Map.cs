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
        public int direction { get; set; }
        public DungeonLevel dungeonlevel { get; set; }


        public Map(DungeonLevel dungeonlevel)
        {
            MapSprite = new MapSprite();//need to know about the factory
            direction = -1;
            this.dungeonlevel = dungeonlevel;

        }


        public void North()
        {
            direction = 0;


        }

        public void East()
        {
            direction = 1;

        }

        public void South()
        {
            direction = 2;

        }

        public void West()
        {
            direction = 3;

        }

        public void Other()
        {
            // Transition to current room's other room, if it exists
        }

        public void Update(GameTime _gameTime)
        {
            double elapsedTime = _gameTime.ElapsedGameTime.TotalSeconds;
            switch (direction)
            {
                case 0:


                    if (GlobalDefinitions.Timer <= ROOM_HEIGHT)
                    {
                        if (GlobalDefinitions.Timer >= ROOM_HEIGHT - GlobalDefinitions.epsilon)
                        {
                            int newRoomY = MapSprite.SourceRectangle.Y - ROOM_HEIGHT + GlobalDefinitions.Timer;
                            MapSprite.SourceRectangle = new Rectangle(MapSprite.SourceRectangle.X, newRoomY, MapSprite.SourceRectangle.Width, MapSprite.SourceRectangle.Height);

                            dungeonlevel.CurrentRoom = dungeonlevel.TempRoom.North;

                            GlobalDefinitions.Timer = 0;
                            direction = -1;
                        }
                        else
                        {
                            int newRoomY = MapSprite.SourceRectangle.Y - (int)(elapsedTime * GlobalDefinitions.Velocity);
                            GlobalDefinitions.Timer += (int)(elapsedTime * GlobalDefinitions.Velocity);
                            MapSprite.SourceRectangle = new Rectangle(MapSprite.SourceRectangle.X, newRoomY, MapSprite.SourceRectangle.Width, MapSprite.SourceRectangle.Height);

                        }


                    }
                    else
                    {

                        GlobalDefinitions.Timer = 0;
                        direction = -1;
                    }
                    break;
                case 1:
                    if (GlobalDefinitions.Timer <= ROOM_WIDTH)
                    {
                        if (GlobalDefinitions.Timer >= ROOM_WIDTH - GlobalDefinitions.epsilon)
                        {
                            int newRoomX = MapSprite.SourceRectangle.X + ROOM_WIDTH - GlobalDefinitions.Timer;

                            MapSprite.SourceRectangle = new Rectangle(newRoomX, MapSprite.SourceRectangle.Y, MapSprite.SourceRectangle.Width, MapSprite.SourceRectangle.Height);
                            dungeonlevel.CurrentRoom = dungeonlevel.TempRoom.East;

                            GlobalDefinitions.Timer = 0;
                            direction = -1;
                        }
                        else
                        {
                            int newRoomX = MapSprite.SourceRectangle.X + (int)(elapsedTime * GlobalDefinitions.Velocity);
                            GlobalDefinitions.Timer += (int)(elapsedTime * GlobalDefinitions.Velocity);
                            MapSprite.SourceRectangle = new Rectangle(newRoomX, MapSprite.SourceRectangle.Y, MapSprite.SourceRectangle.Width, MapSprite.SourceRectangle.Height);

                        }


                    }
                    else
                    {
                        GlobalDefinitions.Timer = 0;
                        direction = -1;
                    }

                    break;
                case 2:

                    if (GlobalDefinitions.Timer <= ROOM_HEIGHT)
                    {
                        if (GlobalDefinitions.Timer >= ROOM_HEIGHT - GlobalDefinitions.epsilon)
                        {
                            int newRoomY = MapSprite.SourceRectangle.Y + ROOM_HEIGHT - GlobalDefinitions.Timer;

                            MapSprite.SourceRectangle = new Rectangle(MapSprite.SourceRectangle.X, newRoomY, MapSprite.SourceRectangle.Width, MapSprite.SourceRectangle.Height);
                            dungeonlevel.CurrentRoom = dungeonlevel.TempRoom.South;

                            GlobalDefinitions.Timer = 0;
                            direction = -1;
                        }
                        else
                        {
                            int newRoomY = MapSprite.SourceRectangle.Y + (int)(elapsedTime * GlobalDefinitions.Velocity);
                            GlobalDefinitions.Timer += (int)(elapsedTime * GlobalDefinitions.Velocity);
                            MapSprite.SourceRectangle = new Rectangle(MapSprite.SourceRectangle.X, newRoomY, MapSprite.SourceRectangle.Width, MapSprite.SourceRectangle.Height);

                        }


                    }
                    else
                    {
                        GlobalDefinitions.Timer = 0;
                        direction = -1;
                    }
                    break;
                case 3:

                    if (GlobalDefinitions.Timer <= ROOM_WIDTH)
                    {
                        if (GlobalDefinitions.Timer >= ROOM_WIDTH - GlobalDefinitions.epsilon)
                        {
                            int newRoomX = MapSprite.SourceRectangle.X - ROOM_WIDTH + GlobalDefinitions.Timer;

                            MapSprite.SourceRectangle = new Rectangle(newRoomX, MapSprite.SourceRectangle.Y, MapSprite.SourceRectangle.Width, MapSprite.SourceRectangle.Height);
                            dungeonlevel.CurrentRoom = dungeonlevel.TempRoom.West;

                            GlobalDefinitions.Timer = 0;
                            direction = -1;
                        }
                        else
                        {
                            int newRoomX = MapSprite.SourceRectangle.X - (int)(elapsedTime * GlobalDefinitions.Velocity);
                            GlobalDefinitions.Timer += (int)(elapsedTime * GlobalDefinitions.Velocity);
                            MapSprite.SourceRectangle = new Rectangle(newRoomX, MapSprite.SourceRectangle.Y, MapSprite.SourceRectangle.Width, MapSprite.SourceRectangle.Height);

                        }


                    }
                    else
                    {
                        GlobalDefinitions.Timer = 0;
                        direction = -1;
                    }
                    break;




                default:
                    // Do nothing, this is not supposed to happen
                    break;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            MapSprite.Draw(spriteBatch);
        }
    }
}
