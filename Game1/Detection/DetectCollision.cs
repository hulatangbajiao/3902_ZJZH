using Game1.Collision;
using Game1.CollisionHandler;
using Game1.Enemy_NPC;
using Game1.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Detection
{
    class DetectCollision
    {
        public ILink link;
        public IBlockFactory BlockFactory;
        public IEnemyFactory EnemyFactory;
        public IProjectileFactory projectileFactory;
        public IitemFactory iitemFactory;
        public DetectCollision()
        {
        }
        public void linkBlockDetection(ILink link, IBLockFactory BlockFactory)
        {
            this.link = link;
            this.BlockFactory = blockFactory;
            List < IBlock > BlockList = blockFactory.getList();
            foreach (IBlock block in BlockList)
            {
                Rectangle linkRectangle = new Rectangle();
                Rectangle BlockRectangle = new Rectangle();
                ICollision side = new GeneralDetection(linkRectangle, BlockRectangle).ifCollision();
                IHandler LinkBlockCollisionHandler = new LinkBlockCollisionHandler(link, BlockList, side);
                LinkBlockCollisionHandler.Execute();
            } 
        }

        public void linkEnemyDetection(ILink link, IEnemyFactory EnemyFactory)
        {
            this.link = link;
            this.EnemyFactory = enemyFactory;
            List<IEnemy> EnemyList = enemyFactory.getList();
            foreach (IEnemy enemy in EnemyList)
            {
                Rectangle linkRectangle = new Rectangle();
                Rectangle BlockRectangle = new Rectangle();
                ICollision side = new GeneralDetection(linkRectangle, BlockRectangle).ifCollision();
                IHandler LinkEnemyCollisionHandler =  new LinkEnemyCollisionHandler(link, EnemyList, side);
                LinkEnemyCollisionHandler.Execute();
            }
        }

        public void linkItemDetection(ILink link, IitemFactory itemFactory)
        {
            this.link = link;
            this.EnemyFactory = enemyFactory;
            List<IEnemy> EnemyList = enemyFactory.getList();
            foreach (IEnemy enemy in EnemyList)
            {
                Rectangle linkRectangle = new Rectangle();
                Rectangle BlockRectangle = new Rectangle();
                ICollision side = new GeneralDetection(linkRectangle, BlockRectangle).ifCollision();
                new LinkEnemyCollisionHandler(link, EnemyList, side).Excute();
            }
        }


    }
}
