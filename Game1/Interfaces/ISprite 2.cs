using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public interface ISprite
    {
        Rectangle SourceRectangle { get; set; }
        Rectangle DestinationRectangle { get; set; }
        void Update();

        void Draw(SpriteBatch spriteBatch);

    }
}
