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
using Game1.Sprite_.BlockSprite;

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

            blockList.Add(new BombedDoorUpSprite());
            blockList.Add(new BombedDoorDownSprite());
            blockList.Add(new BombedDoorLeftSprite());
            blockList.Add(new BombedDoorRightSprite());

            blockList.Add(new BrickTileSprite());
            blockList.Add(new GapTileSprite());
            blockList.Add(new LadderTileSprite());

            blockList.Add(new LockedDoorDownSprite());
            blockList.Add(new LockedDoorUpSprite());
            blockList.Add(new LockedDoorLeftSprite());
            blockList.Add(new LockedDoorRightSprite());

            blockList.Add(new OpenDoorDownSprite());
            blockList.Add(new OpenDoorLeftSprite());
            blockList.Add(new OpenDoorRightSprite());
            blockList.Add(new OpenDoorUpSprite());

            blockList.Add(new ShutDoorUpSprite());
            blockList.Add(new ShutDoorDownSprite());
            blockList.Add(new ShutDoorLeftSprite());
            blockList.Add(new ShutDoorRightSprite());

            blockList.Add(new StairsSprite());
            blockList.Add(new WallUpSprite());
            blockList.Add(new WallDownSprite());
            blockList.Add(new WallLeftSprite());
            blockList.Add(new WallRightSprite());
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
