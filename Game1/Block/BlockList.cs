using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Game1.Sprite_;
using Game1.Interfaces;
using Game1;
using TextureAtlas;


namespace Game1.Block
{
    class BlockList : IBlockList
    {

        public List<IBlock> blockList { get; set; }
        private static int index;

        public BlockList()
        {

            blockList = new List<IBlock>();
            index = 0;
            blockList.Add(new BlueBlockSprite());
            blockList.Add(new BlueFaceBlockSprite());
            blockList.Add(new BlueStoneBlockSprite());


        }


        public void Draw(SpriteBatch spriteBatch)

        {
            blockList[index].Draw(spriteBatch);

        }

        public void Update(Game game)
        {
            blockList[index].Update();
        }

        public void MoveToNext()
        {
            index++;
            if (index == blockList.Count)
            {
                index = 0;

            }

        }

        public void MoveToPrev()
        {
            index--;
            if (index < 0)
            {
                index = blockList.Count - 1;

            }

        }

    }
}
