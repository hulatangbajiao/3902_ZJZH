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
			// More private static Texture2D fields follow
			// ...

			// static classes have no constructor, but we need a method to initialize the Texture2D fields
			public static void LoadAllTextures(ContentManager content)
			{
				UpIdleLinkSpriteSheet = content.Load<Texture2D>("images/UpIdle.png");
			UpMovingLinkSpriteSheet = content.Load<Texture2D>("images/UpMoving.png");
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


	}
	
}
