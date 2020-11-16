using Game1.Block;
using Game1.Controller;
using Game1.Interfaces;
using Game1.Level;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;

namespace Game1
{
    public class MainStage : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private List<IController> controllers;
        public DungeonLevel dungeonlevel { get; set; }

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
        public IEnemyFactory enemyFactory { get; set; }
        public IItemFactory itemFactory { get; set; }
        public IBlockFactory blockFactory { get; set; }
        public ILinkState[] Linkstates { get; }
        public bool paused { get; set; }


        public MainStage()
        {
            graphics = new GraphicsDeviceManager(this);

            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = GlobalDefinitions.GraphicsWidth;
            graphics.PreferredBackBufferHeight = GlobalDefinitions.GraphicsHeight;

            this.Link = new Link(this);
            this.ProjectileFactory = new ProjectileFactory(this);
            this.blockFactory = new BlockFactory(this);
            this.enemyFactory = new EnemyFactory(this);
            this.itemFactory = new ItemFactory(this);
            this.dungeonlevel = new DungeonLevel(this);

            controllers = new List<IController>
            {
                new KeyboardController(this), new MouseController(this)
            };
            
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
            this.blockFactory.Initialize();
            this.enemyFactory.Initialize();
            this.itemFactory.Initialize();
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
            AudioFactory.Instance.LoadAllAudio(this.Content);
            AudioFactory.Instance.PlayDungeonBGM();

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
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            foreach (var controller in controllers)
            {
                controller.Update();
            }
            if (!paused)
            {

                this.ProjectileFactory.Update();

                Link.Update();

                base.Update(gameTime);
                this.dungeonlevel.Update();
            }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            spriteBatch.Begin();
            


            this.dungeonlevel.Draw(spriteBatch);
            Link.State.Draw(spriteBatch);
            this.ProjectileFactory.Draw(spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }

        public void Restart()
        {
            this.Link.State = new UpIdleState(this.Link, this);
            GlobalDefinitions.Position = new Vector2(GlobalDefinitions.GraphicsWidth / 2, GlobalDefinitions.GraphicsHeight / 2);
            this.ProjectileFactory = new ProjectileFactory(this);
            this.dungeonlevel = new DungeonLevel(this);
            Initialize();
        }


    }
}
