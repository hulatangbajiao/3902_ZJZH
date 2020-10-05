using Game1.ItemsClasses;
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

		public static Texture2D ArrowSpriteSheet;
		public static Texture2D BombSpriteSheet;
		public static Texture2D BoomerangSpriteSheet;
		public static Texture2D BowSpriteSheet;
		public static Texture2D ClockSpriteSheet;
		public static Texture2D CompassSpriteSheet;
		public static Texture2D HeartContainerSpriteSheet;
		public static Texture2D KeySpriteSheet;
		public static Texture2D MapSpriteSheet;

		public static Texture2D FairySpriteSheet;
		public static Texture2D HeartSpriteSheet;
		public static Texture2D RupeeSpriteSheet;
		public static Texture2D TriforceSpriteSheet;

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
			
			//load items' texture 
			ArrowSpriteSheet = content.Load<Texture2D>("images/Item/Arrow");
			BombSpriteSheet = content.Load<Texture2D>("images/Item/Bomb");
			BoomerangSpriteSheet = content.Load<Texture2D>("images/Item/Boomerang");

			BowSpriteSheet = content.Load<Texture2D>("images/Item/Bow");
			ClockSpriteSheet = content.Load<Texture2D>("images/Item/Clock");
			CompassSpriteSheet = content.Load<Texture2D>("images/Item/Compass");

			HeartContainerSpriteSheet = content.Load<Texture2D>("images/Item/HeartContainer");
			KeySpriteSheet = content.Load<Texture2D>("images/Item/Key");
			MapSpriteSheet = content.Load<Texture2D>("images/Item/Map");


			FairySpriteSheet = content.Load<Texture2D>("images/Item/Fairy");
			HeartSpriteSheet = content.Load<Texture2D>("images/Item/Heart");
			RupeeSpriteSheet = content.Load<Texture2D>("images/Item/Rupee");
			TriforceSpriteSheet = content.Load<Texture2D>("images/Item/Triforce");

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



	
		/*
	public static Texture2D GetBombSpriteSheet()
	{
		return BombSpriteSheet;
	}
	public static Texture2D GetBoomerangSpriteSheet()
	{
		return BoomerangSpriteSheet;
	}

	public static Texture2D GetBowSpriteSheet()
	{
		return BowSpriteSheet;
	}
	public static Texture2D GetClockSpriteSheet()
	{
		return ClockSpriteSheet;
	}
	public static Texture2D GetCompassSpriteSheet()
	{
		return CompassSpriteSheet;
	}


	public static Texture2D GetHeartContainerSpriteSheet()
	{
		return HeartContainerSpriteSheet;
	}
	public static Texture2D GetKeySpriteSheet()
	{
		return KeySpriteSheet;
	}
	public static Texture2D GetMapSpriteSheet()
	{
		return MapSpriteSheet;
	}
	*/


	}

}
