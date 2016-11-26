using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MiningTeddies
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Texture2D explosionSprite, mineSprite;
        private List<Texture2D> textureList;
        private List<TeddyBear> bearList;
        private List<Mine> mineList;
        private List<Explosion> explosionList;
        private Random rand;
        private int timer, randText, randX, randY;
        public const int WindowHeight = 600;
        public const int WindowWidth = 800;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            graphics.IsFullScreen = false;
            graphics.PreferredBackBufferHeight = WindowHeight;
            graphics.PreferredBackBufferWidth = WindowWidth;

        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            rand = new Random();
            textureList = new List<Texture2D>();
            bearList = new List<TeddyBear>();
            mineList = new List<Mine>();
            explosionList = new List<Explosion>();
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

            // TODO: use this.Content to load your game content here
            textureList.Add(Content.Load<Texture2D>(@"graphics\teddybear0"));
            textureList.Add(Content.Load<Texture2D>(@"graphics\teddybear1"));
            textureList.Add(Content.Load<Texture2D>(@"graphics\teddybear2"));
            mineSprite = Content.Load<Texture2D>(@"graphics\mine");
            explosionSprite = Content.Load<Texture2D>(@"graphics\explosion");
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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                Mine mine = new Mine(mineSprite, Mouse.GetState().X, Mouse.GetState().Y);
                mine.Active = true;
                mineList.Add(mine);
            }

            int randtime = rand.Next(1000,3001);
            timer += gameTime.ElapsedGameTime.Milliseconds; // Increment the timer by the elapsed game time.

            Vector2 randVect = new Vector2();
            randText = rand.Next(0, textureList.Count);
            randVect.X = (float)rand.Next(-5, 5) / 10;
            randVect.Y = (float) rand.Next(-5, 5) / 10;
            randX = rand.Next(0,graphics.PreferredBackBufferWidth-1);    //random pixel in the windowWidth
            randY = rand.Next(0, graphics.PreferredBackBufferHeight-1);    //random pixel in the windowHeight

            if (timer >= randtime) // Check to see if X amount of seconds has passed.
            {
                while (randVect.X.Equals(0) && randVect.Y.Equals(0))
                {
                    randVect.X = (float)rand.Next(-5, 5) / 10;
                    randVect.Y = (float) rand.Next(-5, 5) / 10;
                }
                bearList.Add(new TeddyBear(textureList[randText], randVect, randX, randY));
                timer = 0; // Reset the timer.
            }

            foreach (TeddyBear bear in bearList)
            {
                foreach (Mine mine in mineList)
                {
                        if (bear.CollisionRectangle.Intersects(mine.CollisionRectangle) && mine.Active && bear.Active)
                        {
                            explosionList.Add(new Explosion(explosionSprite, mine.Location.X, mine.Location.Y));
                            bear.Active = false;
                            mine.Active = false;
                            foreach (Explosion explosion in explosionList)
                                explosion.Play(mine.Location.X, mine.Location.Y);
                        }
                }
                bear.Update(gameTime);
            }
            foreach (Explosion explosion in explosionList)
                if(explosion.Playing)
                    explosion.Update(gameTime);

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            foreach (Explosion explosion in explosionList)
                explosion.Draw(spriteBatch);
            foreach (Mine mine in mineList)
                   mine.Draw(spriteBatch);
            foreach (TeddyBear bear in bearList)
                bear.Draw(spriteBatch);
            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
