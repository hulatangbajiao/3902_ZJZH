
using Microsoft.Xna.Framework.Graphics;

namespace Team4_LegendOfZelda
{
    public interface ILevel
    {
        LevelLoader LevelLoader1 { get; set; }
        IMap Map { get; set; }
        ILink Link { get; set; }
        System.Collections.Generic.List<IRoom> Rooms { get; set; }
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