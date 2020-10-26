using Game1.Level;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Game1.Interfaces
{
    public interface ILevel
    {
        LevelLoader LevelLoader1 { get; set; }
        IMap Map { get; set; }
        ILink Link { get; set; }
        List<IRoom> Rooms { get; set; }
        IRoom CurrentRoom { get; set; }

        void North();
        void East();
        void South();
        void West();
        void Other();
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}