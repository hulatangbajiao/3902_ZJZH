﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1.Interfaces
{
    public interface IMap
    {
        Rectangle DestinationRectangle { get; set; }
        ISprite MapSprite { get; set; }

        void North();
        void East();
        void South();
        void West();
        void Other();
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}