using Microsoft.Xna.Framework;
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
        void AddUnpassableBlock(Vector2 position);
    }
}
