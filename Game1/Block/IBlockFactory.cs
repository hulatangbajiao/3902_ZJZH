using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Interfaces
{
    public interface IBlockFactory
    {
        List<IBlock> BlockList { get; set; }
        void Initialize();
        void AddBlock(IBlock block);
        void Draw(SpriteBatch spritebatch);
    }
}
