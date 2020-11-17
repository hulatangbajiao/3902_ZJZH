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
        private MainStage game;

        public ItemFactory(MainStage game)
        {
            this.game = game;
        }

        public void Initialize()
        {
            ItemList = new List<IItem>();

        }

        public void AddItemArrow(Vector2 position)
        {
            ItemList.Add(new ItemArrow(position,game));

        }
        public void AddItemBomb(Vector2 position)
        {
            ItemList.Add(new ItemBomb(position, game));

        }
        public void AddItemBoomer(Vector2 position)
        {
            ItemList.Add(new ItemBoomer(position, game));

        }
        public void AddItemBow(Vector2 position)
        {
            ItemList.Add(new ItemBow(position, game));

        }
        public void AddItemClock(Vector2 position)
        {
            ItemList.Add(new ItemClock(position, game));

        }
        public void AddItemCompass(Vector2 position)
        {
            ItemList.Add(new ItemCompass(position, game));

        }
        public void AddItemFairy(Vector2 position)
        {
            ItemList.Add(new ItemFairy(position, game));

        }
        public void AddItemHeartContainer(Vector2 position)
        {
            ItemList.Add(new ItemHeartContainer(position,game));

        }
        public void AddItemHeart(Vector2 position)
        {
            ItemList.Add(new ItemHeart(position,game));

        }
        public void AddItemKey(Vector2 position)
        {
            ItemList.Add(new ItemKey(position,game));

        }
        public void AddItemMap(Vector2 position)
        {
            ItemList.Add(new ItemMap(position,game));

        }
        public void AddItemRupee(Vector2 position)
        {
            ItemList.Add(new ItemRupee(position,game));

        }
        public void AddItemTriforce(Vector2 position)
        {
            ItemList.Add(new ItemTriforce(position,game));

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
