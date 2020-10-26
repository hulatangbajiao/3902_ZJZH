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
        public List<IBlock> BlockList;
        public List<IEnemy> EnemyList;
        public IProjectileFactory projectileFactory;
        public List<IItem> ReceivedItemList;
        public List<IItem> ObtainedItemList;
        public DetectCollision()
        {
        }
        public void linkBlockDetection(ILink link, List<IBlock> BlockList)
        {
            this.link = link;
            this.BlockList = BlockList;
            foreach (IBlock block in BlockList)
            {
                Rectangle linkRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 96, 96); ;
                Rectangle BlockRectangle = block.GetRectangle();
                Rectangle intersectRectangle = new GeneralDeterctionIntersect(linkRectangle, BlockRectangle).GetRectangle();
                ICollision side = new GeneralDetection(linkRectangle, BlockRectangle).ifCollision();
                IHandler LinkBlockCollisionHandler = new LinkBlockCollisionHandler(link, block, side, intersectRectangle);
                LinkBlockCollisionHandler.Execute();
            }
        }

        public void LinkEnemyDetection(ILink link, List<IEnemy> EnemyList)
        {
            this.link = link;
            this.EnemyList = EnemyList;
            foreach (IEnemy enemy in EnemyList)
            {
                if (enemy.exist)
                {
                    Rectangle linkRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 96, 96);
                    Rectangle EnemyRectangle = enemy.GetRectangle();
                    Rectangle intersectRectangle = new GeneralDeterctionIntersect(linkRectangle, BlockRectangle).GetRectangle();
                    ICollision side = new GeneralDetection(linkRectangle, EnemyRectangle).ifCollision();
                    IHandler LinkEnemyCollisionHandler = new LinkEnemyCollisionHandler(enemy, link, side, intersectRectangle);
                    LinkEnemyCollisionHandler.Execute();
                }
            }
        }

        public void linkReceivedItemDetection(ILink link, List<IItem> ReceivedItemList)
        {
            this.link = link;
            this.ReceivedItemList = ReceivedItemList;
            foreach (IItem item in ReceivedItemList)
            {
                Rectangle linkRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 96, 96);
                Rectangle ItemRectangle = item.GetRectangle();
                Rectangle intersectRectangle = new GeneralDeterctionIntersect(linkRectangle, BlockRectangle).GetRectangle();
                ICollision side = new GeneralDetection(linkRectangle, ItemRectangle).ifCollision();
                IHandler LinkReceivedItemCollision = new LinkReceivedItemCollisionHandler(link, item, side, intersectRectangle);
                LinkReceivedItemCollision.Execute();
            }
        }

        public void linkObtainedItemDetection(ILink link, List<IItem> ObtainedItemList)
        {
            this.link = link;
            this.ObtainedItemList = ObtainedItemList;
            foreach (IItem item in ObtainedItemList)
            {
                Rectangle linkRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 96, 96);
                Rectangle ItemRectangle = item.GetRectangle();
                Rectangle intersectRectangle = new GeneralDeterctionIntersect(linkRectangle, BlockRectangle).GetRectangle();
                ICollision side = new GeneralDetection(linkRectangle, ItemRectangle).ifCollision();
                IHandler LinkObtainedItemCollision = new LinkObtainedItemCollisionHandler(link, item, side, intersectRectangle);
                LinkObtainedItemCollision.Execute();
            }
        }

        public void EnemyBlockDetection(List<IEnemy> EnemyList, List<IBlock> BlockList)
        {
            this.EnemyList = EnemyList;
            this.BlockList = BlockList;
            foreach (IEnemy enemy in EnemyList)
            {
                if (enemy.exist)
                {
                    foreach (IBlock block in BlockList)
                    {
                        Rectangle EnemyRectangle = enemy.GetRectangle();
                        Rectangle BlockRectangle = block.GetRectangle();
                        Rectangle intersectRectangle = new GeneralDeterctionIntersect(linkRectangle, BlockRectangle).GetRectangle();
                        ICollision side = new GeneralDetection(EnemyRectangle, BlockRectangle).ifCollision();
                        IHandler EnemyBlockCollisionHandler = new EnemyBlockCollisionHandler(enemy, block, side, intersectRectangle);
                        EnemyBlockCollisionHandler.Execute();
                    }
                }

            }

        }

        public void EnemyProjectileDetection(List<IEnemy> EnemyList, IProjectileFactory projectileFactory)
        {
            this.EnemyList = EnemyList;
            this.projectileFactory = projectileFactory;
            List<IProjectile> projectileList = projectileFactory.ProjectileList;
            foreach (IEnemy enemy in EnemyList)
            {
                if (enemy.exist)
                {
                    foreach (IProjectile projectile in projectileList)
                    {
                        Rectangle EnemyRectangle = enemy.GetRectangle();
                        Rectangle projectileRectangle = projectile.GetRectangle();
                        ICollision side = new GeneralDetection(EnemyRectangle, projectileRectangle).ifCollision();
                        IHandler EnemyProjectileCollision = new EnemyProjectileCollisonHandler(enemy, projectile, side);
                        EnemyProjectileCollision.Execute();
                    }
                }

            }

        }
    }
}
