using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.GameState
{
    public interface IGameState
    {
        ISprite MessageSprite { get; set; }
        ISprite ResetSprite { get; set; }
        ISprite QuitSprite { get; set; }
        void Draw(SpriteBatch spriteBatch);
    }
}
