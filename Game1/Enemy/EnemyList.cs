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
using Game1.Enemy_NPC;

namespace Game1
{
    public class EnemyList
    {

        private List<IEnemy> enemyList;
        private static int index;
        private MainStage game;
        public EnemyList(MainStage game)
        {
            this.game = game;
            enemyList = new List<IEnemy>();
            index = 0;
            enemyList.Add(new Oct(game));
            enemyList.Add(new OldMan());
            enemyList.Add(new OldWoman());
            enemyList.Add(new MerchantP());
            enemyList.Add(new MerchantR());
            enemyList.Add(new MerchantG());
            enemyList.Add(new BlueOct(game));
            enemyList.Add(new BlueM(game));
            enemyList.Add(new BlueGoriya(game));
            enemyList.Add(new BlueBat(game));
            enemyList.Add(new RedGoriya(game));
            enemyList.Add(new RedBat(game));



        }


        public void Draw(SpriteBatch spriteBatch)

        {

            enemyList[index].State.GetSprite.Draw(spriteBatch);

        }

        public void Update(Game game)
        {
            enemyList[index].Update();
            
        }

        public void MoveToNext()
        {
            index++;
            if (index == enemyList.Count)
            {
                index = 0;

            }

        }

        public void MoveToPrev()
        {
            index--;
            if (index < 0)
            {
                index = enemyList.Count - 1;

            }

        }

    }
}
