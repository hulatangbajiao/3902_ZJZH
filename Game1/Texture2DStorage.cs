using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{

    public static class Texture2DStorage
    {
        // Note that we are not using Game1's ContentLoader here (outside the scope of class methods) since it has not been instantiated yet
        private static Texture2D UpIdleLinkSpriteSheet;
        private static Texture2D UpMovingLinkSpriteSheet;

        private static Texture2D DownIdleLinkSpriteSheet;
        private static Texture2D DownMovingLinkSpriteSheet;

        private static Texture2D LeftIdleLinkSpriteSheet;
        private static Texture2D LeftMovingLinkSpriteSheet;

        private static Texture2D RightIdleLinkSpriteSheet;
        private static Texture2D RightMovingLinkSpriteSheet;

        private static Texture2D UpWoodenSwordLinkSpriteSheet;
        private static Texture2D DownWoodenSwordLinkSpriteSheet;
        private static Texture2D LeftWoodenSwordLinkSpriteSheet;
        private static Texture2D RightWoodenSwordLinkSpriteSheet;

        private static Texture2D UpOctorokSpriteSheet;
        private static Texture2D DownOctorokSpriteSheet;
        private static Texture2D LeftOctorokSpriteSheet;
        private static Texture2D RightOctorokSpriteSheet;

        private static Texture2D OldManSpriteSheet;
        private static Texture2D OldWomanSpriteSheet;

        private static Texture2D DamagedLinkSpriteSheet;

        // More private static Texture2D fields follow
        // ...

        // static classes have no constructor, but we need a method to initialize the Texture2D fields
        public static void LoadAllTextures(ContentManager content)
        {
            UpIdleLinkSpriteSheet = content.Load<Texture2D>("images/UpIdle");
            UpMovingLinkSpriteSheet = content.Load<Texture2D>("images/UpMoving");

            LeftIdleLinkSpriteSheet = content.Load<Texture2D>("images/LeftIdle");
            LeftMovingLinkSpriteSheet = content.Load<Texture2D>("images/LeftMoving");

            DownIdleLinkSpriteSheet = content.Load<Texture2D>("images/DownIdle");
            DownMovingLinkSpriteSheet = content.Load<Texture2D>("images/DownMoving");

            RightIdleLinkSpriteSheet = content.Load<Texture2D>("images/RightIdle");
            RightMovingLinkSpriteSheet = content.Load<Texture2D>("images/RightMoving");

            UpWoodenSwordLinkSpriteSheet = content.Load<Texture2D>("images/UpWoodenSword");
            DownWoodenSwordLinkSpriteSheet = content.Load<Texture2D>("images/DownWoodenSword");
            LeftWoodenSwordLinkSpriteSheet = content.Load<Texture2D>("images/LeftWoodenSword");
            RightWoodenSwordLinkSpriteSheet = content.Load<Texture2D>("images/RightWoodenSword");

            UpOctorokSpriteSheet = content.Load<Texture2D>("images/Enemy/Octorok/OctorokUp");
            DownOctorokSpriteSheet = content.Load<Texture2D>("images/Enemy/Octorok/OctorokDown");
            LeftOctorokSpriteSheet = content.Load<Texture2D>("images/Enemy/Octorok/OctorokLeft");
            RightOctorokSpriteSheet = content.Load<Texture2D>("images/Enemy/Octorok/OctorokRight");

            OldManSpriteSheet = content.Load<Texture2D>("images/Npc/OldMan");
            OldWomanSpriteSheet = content.Load<Texture2D>("images/Npc/OldWoman");
            DamagedLinkSpriteSheet = content.Load<Texture2D>("images/DamagedLink");


            // More Content.Load calls follow
            //...
        }

        public static void UnloadAllTextures()
        {
            // unload all the Texture2Ds - not needed for the scope of this project
        }

        public static Texture2D GetUpIdleLinkSpriteSheet()
        {
            return UpIdleLinkSpriteSheet;
        }

        public static Texture2D GetUpMovingLinkSpriteSheet()
        {
            return UpMovingLinkSpriteSheet;
        }

        public static Texture2D GetDownIdleLinkSpriteSheet()
        {
            return DownIdleLinkSpriteSheet;
        }

        public static Texture2D GetDownMovingLinkSpriteSheet()
        {
            return DownMovingLinkSpriteSheet;
        }

        public static Texture2D GetLeftIdleLinkSpriteSheet()
        {
            return LeftIdleLinkSpriteSheet;
        }

        public static Texture2D GetLeftMovingLinkSpriteSheet()
        {
            return LeftMovingLinkSpriteSheet;
        }

        public static Texture2D GetRightIdleLinkSpriteSheet()
        {
            return RightIdleLinkSpriteSheet;
        }

        public static Texture2D GetRightMovingLinkSpriteSheet()
        {
            return RightMovingLinkSpriteSheet;
        }

        public static Texture2D GetUpWoodenSwordLinkSpriteSheet()
        {
            return UpWoodenSwordLinkSpriteSheet;
        }

        public static Texture2D GetDownWoodenSwordLinkSpriteSheet()
        {
            return DownWoodenSwordLinkSpriteSheet;
        }

        public static Texture2D GetLeftWoodenSwordLinkSpriteSheet()
        {
            return LeftWoodenSwordLinkSpriteSheet;
        }

        public static Texture2D GetRightWoodenSwordLinkSpriteSheet()
        {
            return RightWoodenSwordLinkSpriteSheet;
        }

        public static Texture2D GetUpMovingOctorokSpriteSheet()
        {
            return UpOctorokSpriteSheet;
        }

        public static Texture2D GetDownMovingOctorokSpriteSheet()
        {
            return DownOctorokSpriteSheet;
        }

        public static Texture2D GetLeftMovingOctorokSpriteSheet()
        {
            return LeftOctorokSpriteSheet;
        }

        public static Texture2D GetRightMovingOctorokSpriteSheet()
        {
            return RightOctorokSpriteSheet;
        }

        public static Texture2D GetOldManSpriteSheet()
        {
            return OldManSpriteSheet;
        }

        public static Texture2D GetOldWomanSpriteSheet()
        {
            return OldWomanSpriteSheet;
        }

        public static Texture2D GetDamagedLinkSpriteSheet()
        {
            return DamagedLinkSpriteSheet;
        }


    }

}
