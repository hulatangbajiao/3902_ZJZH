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
    public class BlockFactory : IBlockFactory
    {
        public List<IBlock> BlockList { get; set; }

        public BlockFactory(MainStage game)
        {

        }

        public void Initialize()
        {
            BlockList = new List<IBlock>();

        }

        public void AddBlock(IBlock block)
        {
            BlockList.Add(block);

        }
        public void Draw(SpriteBatch spritebatch)
        {

            foreach (IBlock block in BlockList)
            {
                block.Draw(spritebatch);
            }
        }

        


        
    }


}
