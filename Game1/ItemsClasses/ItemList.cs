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
    class ItemList
    {
        private List<Interfaces.Iitem> itemList;
        private static int index;

        public ItemList()
        {

            itemList = new List<Interfaces.Iitem>();
            index = 0;
            itemList.Add(new UseArrowSprite(Texture2DStorage.GetArrowSpriteSheet()));
            itemList.Add(new UseBombSprite(Texture2DStorage.GetBombSpriteSheet()));
            itemList.Add(new UseBoomerangSprite(Texture2DStorage.GetBoomerangSpriteSheet()));

            itemList.Add(new UseBowSprite(Texture2DStorage.GetBowSpriteSheet()));
            itemList.Add(new UseClockSprite(Texture2DStorage.GetClockSpriteSheet()));
            itemList.Add(new UseCompassSprite(Texture2DStorage.GetCompassSpriteSheet()));

            itemList.Add(new UseFairySprite(Texture2DStorage.GetFairySpriteSheet()));
            itemList.Add(new UseHeartContainerSprite(Texture2DStorage.GetHeartContainerSpriteSheet()));
            itemList.Add(new UseHeartSprite(Texture2DStorage.GetHeartSpriteSheet()));

            itemList.Add(new UseKeySprite(Texture2DStorage.GetKeySpriteSheet()));
            itemList.Add(new UseMapSprite(Texture2DStorage.GetMapSpriteSheet()));
            itemList.Add(new UseRupeeSprite(Texture2DStorage.GetRupeeSpriteSheet()));

            itemList.Add(new UseTriforceSprite(Texture2DStorage.GetTriforceSpriteSheet()));
            

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
