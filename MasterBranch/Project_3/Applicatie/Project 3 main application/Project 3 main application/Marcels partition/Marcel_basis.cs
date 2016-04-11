using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Project_3_main_application.Marcels_partition;

/*  Deze file is van: "Marcel Bostelaar"
*
*/

namespace Project_3_main_application
{
    class Marcel_basis
    {
        Button testbutton;

        public Marcel_basis()
        {

        }

        public void LoadContent(Dictionary<string, Texture2D> textDict, Game1 game1, Dictionary<string, SpriteFont> fontDict)
        {
            //Hier kan je al je plaatjes enzo laden
            textDict.Add("test", game1.Content.Load<Texture2D>("mine.png"));
            fontDict.Add("Testfont", game1.Content.Load<SpriteFont>("TestFont"));
        }

        public void Initialize(Dictionary<string, Texture2D> textDict)
        {
            //Hier kan je initializatie doen
            this.testbutton = new Button("Testfont", textDict["test"], true, new Vector2(200, 200), "testo", new Vector2(0, 0));
        }

        public void unloadContent()
        {
            //Hier kan je dingen ontladen
        }

        public void Update(GameTime gameTime)
        {
            //Hier moet je update logica komen
        }

        public void Draw(SpriteBatch spriteBatch, Dictionary<string, Texture2D> textDict, Dictionary<string, SpriteFont> fontDict)
        {
            spriteBatch.Draw(textDict["test"], new Vector2(0, 0), Color.White);
            //Hier moet je drawen
        }
    }
}
