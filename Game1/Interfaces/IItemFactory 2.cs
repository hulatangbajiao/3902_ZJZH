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
    public interface IItemFactory
    {
        List<IItem> ItemList { get; set; }
        void AddItemArrow(Vector2 position);
        void AddItemBomb(Vector2 position);
        void AddItemBoomer(Vector2 position);
        void AddItemBow(Vector2 position);
        void AddItemClock(Vector2 position);
        void AddItemCompass(Vector2 position);
        void AddItemFairy(Vector2 position);
        void AddItemHeartContainer(Vector2 position);
        void AddItemHeart(Vector2 position);
        void AddItemKey(Vector2 position);
        void AddItemMap(Vector2 position);
        void AddItemRupee(Vector2 position);
        void AddItemTriforce(Vector2 position);


        void Update();
        void Draw(SpriteBatch spriteBatch);
        
    }
}
