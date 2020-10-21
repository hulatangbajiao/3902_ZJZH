using Game1.Block;
using Game1.Controller;
using Game1.Detection;
using Game1.ItemsClasses;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace Game1
{
    public class MainStage : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private List<IController> controllers;

        /// <summary>
        /// Active sprite. Exposed as a class property
        /// </summary>

        //Link class
        public ILink Link { get; set; }
        /// <summary>
        /// A list that holds all loaded sprites.
        /// 
        /// </summary>
        //Projectile Factory
        public IProjectileFactory ProjectileFactory { get; set; }
        public IBlockList BlockList { get; set; }
        public IItemList ItemList { get; set; }
        public ILinkState[] Linkstates { get; }
        public EnemyList Enemylist { get; set; }
        public EnemyBlockDetection Enemyblockdetection { get; set; }

        public MainStage()
        {
            graphics = new GraphicsDeviceManager(this);

            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = GlobalDefinitions.GraphicsWidth;
            graphics.PreferredBackBufferHeight = GlobalDefinitions.GraphicsHeight;

            this.Link = new Link(this);
            this.ProjectileFactory = new ProjectileFactory(this);
            this.BlockList = new BlockList();
            this.ItemList = new ItemList();
            this.Enemylist = new EnemyList(this);

            this.Enemyblockdetection = new EnemyBlockDetection(Enemylist, BlockList);
            controllers = new List<IController>
            {
                new KeyboardController(this)
            };
        }

        /// <summary>
        /// Reset all sprites to a known state
        /// </summary>
        public void ResetState()
        {
            Link.Reset();
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // Explicitly set mouse visible option to make the game intuitive
            this.IsMouseVisible = true;
            this.TargetElapsedTime = TimeSpan.FromSeconds(1.0f / 100.0f);
            this.IsFixedTimeStep = false;
            graphics.SynchronizeWithVerticalRetrace = false;
            this.ProjectileFactory.Initialize();

            // Create instances and register commands
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            Texture2DStorage.LoadAllTextures(this.Content);

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for Collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            foreach (var controller in controllers)
            {
                controller.Update();
            }
            this.ProjectileFactory.Update();
            this.BlockList.Update(this);
            this.ItemList.Update(this);
            Link.Update();
            this.Enemylist.Update(this);
            this.Enemyblockdetection.update();
            base.Update(gameTime);
           
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            this.ItemList.Draw(spriteBatch);
            spriteBatch.Begin();
            this.ProjectileFactory.Draw(spriteBatch);
            this.BlockList.Draw(spriteBatch);
            this.Enemylist.Draw(spriteBatch);
            Link.State.Draw(spriteBatch);

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
