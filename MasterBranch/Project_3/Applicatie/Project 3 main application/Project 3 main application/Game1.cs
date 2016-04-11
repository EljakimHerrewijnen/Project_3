using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Project_3_main_application.Marcels_partition;
using System.Collections.Generic;

/*
eigenaar van deze file: "Marcel Bostelaar"
*/


namespace Project_3_main_application
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Globalvars GlobalVars = new Globalvars();

        Marcel_basis Marcel_Basis = new Marcel_basis();
        Marco_basis Marco_Basis = new Marco_basis();
        Marc_basis Marc_Basis = new Marc_basis();
        Eljakim_basis Eljakim_Basis = new Eljakim_basis();
        Paul_basis Paul_Basis = new Paul_basis();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            Marcel_Basis.Initialize(GlobalVars);
            Marco_Basis.Initialize(GlobalVars);
            Marc_Basis.Initialize(GlobalVars);
            Paul_Basis.Initialize(GlobalVars);
            Eljakim_Basis.Initialize(GlobalVars);

            //Algemene initialisatie
            this.IsMouseVisible = true;



            /*
            *TODO: Add your initialization logic here
            */

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            // Create a new SpriteBatch, which can be used to draw textures.

            Marcel_Basis.LoadContent(GlobalVars, this);
            Marco_Basis.LoadContent(GlobalVars, this);
            Marc_Basis.LoadContent(GlobalVars, this);
            Paul_Basis.LoadContent(GlobalVars, this);
            Eljakim_Basis.LoadContent(GlobalVars, this);

            /*
            *TODO: use this.Content to load your game content here
            */
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {

            Marcel_Basis.unloadContent();
            Marco_Basis.unloadContent();
            Marc_Basis.unloadContent();
            Paul_Basis.unloadContent();
            Eljakim_Basis.unloadContent();


            /* TODO: Unload any non ContentManager content here
            *
            *
            *
            */
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


            Marcel_Basis.Update(gameTime);
            Marco_Basis.Update(gameTime);
            Marc_Basis.Update(gameTime);
            Paul_Basis.Update(gameTime);
            Eljakim_Basis.Update(gameTime);

            /* TODO: Add your update logic here
            *
            *
            *
            *
            */

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            Marcel_Basis.Draw(spriteBatch, GlobalVars);
            Marco_Basis.Draw(spriteBatch, GlobalVars);
            Marc_Basis.Draw(spriteBatch, GlobalVars);
            Paul_Basis.Draw(spriteBatch, GlobalVars);
            Eljakim_Basis.Draw(spriteBatch, GlobalVars);


            spriteBatch.End();


            /* TODO: Add your drawing code here
            *
            *
            *
            *
            */






            base.Draw(gameTime);
        }
    }
}
