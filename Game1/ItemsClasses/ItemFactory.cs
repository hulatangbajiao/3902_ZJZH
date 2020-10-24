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
    class ItemFactory : IItemFactory
    {
        public List<IItem> ItemList { get; set; }

        public ItemFactory(MainStage game)
        {

        }

        public void Initialize()
        {
            ItemList = new List<IItem>();

        }

        public void AddItemArrow(Vector2 position)
        {
            ItemList.Add(new ItemArrow(position));

        }
        public void AddItemBomb(Vector2 position)
        {
            ItemList.Add(new ItemBomb(position));

        }
        public void AddItemBoomer(Vector2 position)
        {
            ItemList.Add(new ItemBoomer(position));

        }
        public void AddItemBow(Vector2 position)
        {
            ItemList.Add(new ItemBow(position));

        }
        public void AddItemClock(Vector2 position)
        {
            ItemList.Add(new ItemClock(position));

        }
        public void AddItemCompass(Vector2 position)
        {
            ItemList.Add(new ItemCompass(position));

        }
        public void AddItemFairy(Vector2 position)
        {
            ItemList.Add(new ItemFairy(position));

        }
        public void AddItemHeartContainer(Vector2 position)
        {
            ItemList.Add(new ItemHeartContainer(position));

        }
        public void AddItemHeart(Vector2 position)
        {
            ItemList.Add(new ItemHeart(position));

        }
        public void AddItemKey(Vector2 position)
        {
            ItemList.Add(new ItemKey(position));

        }
        public void AddItemMap(Vector2 position)
        {
            ItemList.Add(new ItemMap(position));

        }
        public void AddItemRupee(Vector2 position)
        {
            ItemList.Add(new ItemRupee(position));

        }
        public void AddItemTriforce(Vector2 position)
        {
            ItemList.Add(new ItemTriforce(position));

        }
        public void Update()
        {

            foreach (IItem item in ItemList)
            {
                item.Update();
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {

            foreach (IItem item in ItemList)
            {
                item.Draw(spriteBatch);
            }
        }





    }


}
