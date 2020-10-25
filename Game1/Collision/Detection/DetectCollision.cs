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
        public IItemFactory itemFactory;
        public DetectCollision()
        {
        }
        public void LinkBlockDetection(ILink link, IBlockFactory BlockFactory)
        {
            this.link = link;
            this.BlockFactory = BlockFactory;
            List < IBlock > BlockList = BlockFactory.BlockList;
            foreach (IBlock block in BlockList)
            {
                Rectangle linkRectangle = new Rectangle();
                Rectangle BlockRectangle = block.GetRectangle();
                Rectangle intersectRectangle = new GeneralDeterctionIntersect(linkRectangle, ItemRectangle).GetRectangle();
                ICollision side = new GeneralDetection(linkRectangle, BlockRectangle).ifCollision();
                IHandler LinkBlockCollisionHandler = new LinkBlockCollisionHandler(link, block, side,intersectRectangle);
                LinkBlockCollisionHandler.Execute();
            } 
        }

        public void LinkEnemyDetection(ILink link, IEnemyFactory EnemyFactory)
        {
            this.link = link;
            this.EnemyFactory = EnemyFactory;
            List<IEnemy> EnemyList = EnemyFactory.EnemyList();
            foreach (IEnemy enemy in EnemyList)
            {
                Rectangle linkRectangle = new Rectangle();
                Rectangle EnemyRectangle = enemy.GetRectangle();
                ICollision side = new GeneralDetection(linkRectangle, EnemyRectangle).ifCollision();
                IHandler LinkEnemyCollisionHandler =  new LinkEnemyCollisionHandler(link, enemy, side);
                LinkEnemyCollisionHandler.Execute();
            }
        }

        public void LinkItemDetection(ILink link, IItemFactory itemFactory)
        {
            this.link = link;
            this.itemFactory = itemFactory;
            List<IItem> itemList = itemFactory.ItemList;
            foreach (IItem item in itemList)
            {
                if (item.exist)
                {
                    Rectangle linkRectangle = new Rectangle();
                    Rectangle ItemRectangle = item.GetRectangle();
                    ICollision side = new GeneralDetection(linkRectangle, ItemRectangle).ifCollision();
                    IHandler LinkItemCollision = new LinkItemCollisionHandler(link, item, side);
                    LinkItemCollision.Execute();
                }
            }
        }

        public void EnemyBlockDetection(IEnemyFactory EnemyFactory, IBlockFactory BlockFactory)
        {
            this.EnemyFactory = EnemyFactory;
            this.BlockFactory = BlockFactory;
            List<IEnemy> EnemyList = EnemyFactory.EnemyList;
            List<IBlock> BlockList = BlockFactory.BlockList;
            foreach (IEnemy enemy in EnemyList)
            {
                foreach (IBlock block in BlockList)
                {
                    Rectangle EnemyRectangle = enemy.GetRectangle();
                    Rectangle BlockRectangle = block.GetRectangle();
                    ICollision side = new GeneralDetection(EnemyRectangle, BlockRectangle).ifCollision();
                    IHandler EnemyBlockCollisionHandler = new EnemyBlockCollisionHandler(enemy, block, side);
                    EnemyBlockCollisionHandler.Execute();
                }
            }
            
        }

        public void EnemyProjectileDetection(IEnemyFactory EnemyFactory, IProjectileFactory projectileFactory)
        {
            this.EnemyFactory = EnemyFactory;
            this.projectileFactory = projectileFactory;
            List<IEnemy> EnemyList = EnemyFactory.EnemyList;
            List<IProjectile> projectileList = projectileFactory.ProjectileList;
            foreach (IEnemy enemy in EnemyList)
            {
                foreach (IProjectile projectile in projectileList)
                {
                    Rectangle EnemyRectangle = Enemy.GetRectangle();
                    Rectangle projectileRectangle = projectile.GetRectangle();
                    ICollision side = new GeneralDetection(EnemyRectangle, projectileRectangle).ifCollision();
                    IHandler EnemyProjectileCollisionHandler = new EnemyProjectileCollisionHandler(enemy, projectile, side);
                    EnemyProjectileCollisionHandler.Execute();
                }
            }

        }
    }
}
