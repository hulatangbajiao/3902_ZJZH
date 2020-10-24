using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Interfaces
{
    interface IItemSprite
    {
        Texture2D Texture { get; set; }

        void Update();
        void Draw(SpriteBatch spriteBatch, Vector2 Position);
    }
}