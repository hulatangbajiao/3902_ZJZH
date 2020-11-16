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
    public class EnemyFactory : IEnemyFactory
    {
        private MainStage game;
        public List<IEnemy> EnemyList { get; set; }

        public EnemyFactory(MainStage game)
        {
            this.game = game;
        }

        public void Initialize()
        {
            EnemyList = game.dungeonlevel.CurrentRoom.Enemies;

        }

        public void AddEnemy(IEnemy enemy)
        {
            EnemyList.Add(enemy);

        }



        public void Update()
        {

            foreach (IEnemy enemy in EnemyList)
            {
                enemy.Update();
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {

            foreach (IEnemy enemy in EnemyList)
            {
                enemy.Draw(spriteBatch);
            }
        }
    }
}