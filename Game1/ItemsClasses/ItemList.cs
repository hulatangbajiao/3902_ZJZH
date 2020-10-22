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

namespace Game1.ItemsClasses
{
    class ItemList : IItemList
    {
        private List<Interfaces.Iitem> itemList;
        private static int index;

        public ItemList()
        {

            itemList = new List<Interfaces.Iitem>();
            index = 0;
            itemList.Add(new UseArrowSprite());
            itemList.Add(new UseBombSprite());
            itemList.Add(new UseBoomerangSprite());

            itemList.Add(new UseBowSprite());
            itemList.Add(new UseClockSprite());
            itemList.Add(new UseCompassSprite());

            itemList.Add(new UseFairySprite());
            itemList.Add(new UseHeartContainerSprite());
            itemList.Add(new UseHeartSprite());

            itemList.Add(new UseKeySprite());
            itemList.Add(new UseMapSprite());
            itemList.Add(new UseRupeeSprite());

            itemList.Add(new UseTriforceSprite());
            

        }


        public void Draw(SpriteBatch spriteBatch)

        {
            itemList[index].Draw(spriteBatch);

        }

        public void Update(Game game)
        {
            itemList[index].Update();
        }

        public void MoveToNext()
        {
            index++;
            if(index==itemList.Count)
            {
                index = 0;

            }
            
        }

        public void MoveToPrev()
        {
            index--;
            if (index <0)
            {
                index = itemList.Count-1;

            }

        }





    }
}
