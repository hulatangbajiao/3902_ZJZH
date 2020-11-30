using Game1.Collision.CollisionHandler;
using Game1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game1.Sprite_;
using Game1.Collision;
using Microsoft.Xna.Framework;
using Game1.CollisionHandler;
using Game1;

namespace Game1.Collision.CollisionHandler
{
    class LinkObtainedItemCollisionHandler:IHandler
    {
        private ICollision side;
        private IItem item;
        private ILink Link;
      
        public LinkObtainedItemCollisionHandler(ILink link, IItem item, ICollision side)
        {
            this.Link = link;
            this.item = item;
            this.side = side;
 
        }

        public void Execute()
        {
            if (side !=ICollision.Null&&item.exist)
            {
                if (item.exist != false)
                {
                    if (item is ItemRupee)
                        AudioFactory.Instance.PlayPickUpRupeeSound();
                    else
                        AudioFactory.Instance.PlayPickUpItemSound();
                }
                item.exist = false;
                item.PickUp();
            }


        }



    }
}
