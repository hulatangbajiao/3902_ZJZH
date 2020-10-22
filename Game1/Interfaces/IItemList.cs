using Game1.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public interface IItemList
    {
        
        void MoveToPrev();
        void MoveToNext();
        void Update(Game game);
        void Draw(SpriteBatch spriteBatch);
        
    }
}
