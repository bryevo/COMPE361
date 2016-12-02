using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Lab_8___Text_Output_Fun
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private const int WindowHeight = 600;
        private const int WindowWidth = 800;
        private SpriteFont font;
        private string[] fontArray = { "Ted", "Cruz", "is", "the", "Zodiac", "Killer" };
        private List<string> fontList;
        private int fontIndex, checkIndex;
        private MouseState lastMouseState, currentMouseState;
        private Vector2 fontLocation, fontOrigin;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            graphics.PreferredBackBufferWidth = WindowWidth;
            graphics.PreferredBackBufferHeight = WindowHeight;
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
            font = Content.Load<SpriteFont>(@"font\Arial24");
            fontList = new List<string>(fontArray);
            fontLocation = new Vector2(WindowWidth - fontOrigin.X, WindowHeight - fontOrigin.Y);
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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            Random rand = new Random();
            // Get the mouse state relevant for this frame
            lastMouseState = currentMouseState;
            currentMouseState = Mouse.GetState();
            // Recognize a single click of the left mouse button
            if (lastMouseState.LeftButton == ButtonState.Released && currentMouseState.LeftButton == ButtonState.Pressed)
            {
                checkIndex = fontIndex;
                fontIndex = rand.Next(0, fontList.Count);
                //Checks for repeating strings
                while (fontIndex == checkIndex)
                    fontIndex = rand.Next(0, fontList.Count);
                Vector2 fontOrigin = font.MeasureString(fontList[fontIndex]);
                fontLocation = new Vector2(WindowWidth - fontOrigin.X, WindowHeight - fontOrigin.Y);
            }
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
            //Draw the string
            spriteBatch.DrawString(font, fontList[fontIndex], fontLocation, Color.Black, 0,
                fontOrigin, 1.0f, SpriteEffects.None, 1.0f);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
