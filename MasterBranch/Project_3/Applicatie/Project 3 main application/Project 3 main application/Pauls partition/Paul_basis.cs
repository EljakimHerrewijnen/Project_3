using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

/*  Deze file is van: "Paul de Keijzer"
*
*/

namespace Project_3_main_application
{
    class Paul_basis
    {
        ////static int count = 0;
        internal static void LoadContent(Dictionary<string, Texture2D> textDict, Game1 game1)
        {
            //Hier kan je al je plaatjes enzo laden
            //textDict.Add("test2", game1.Content.Load<Texture2D>("itshim.jpg"));
        }


        internal static void Initialize()
        {
            //Hier kan je initializatie doen
        }

        internal static void unloadContent()
        {
            //Hier kan je dingen ontladen
        }

        internal static void Update(GameTime gameTime)
        {
            //Hier moet je update logica komen
        }

        internal static void Draw(SpriteBatch spriteBatch, Dictionary<string, Texture2D> textDict)
        {
            //if (count < 100) { spriteBatch.Draw(textDict["test2"], new Vector2(100, 0), Color.White); }
            //else if (count < 200) { spriteBatch.Draw(textDict["test2"], new Vector2(200, 0), Color.White); }
            //else if ( count < 300) { spriteBatch.Draw(textDict["test2"], new Vector2(300, 0), Color.White); }
            //else if (count < 400) { spriteBatch.Draw(textDict["test2"], new Vector2(400, 0), Color.White); }
            //else if (count < 500) { spriteBatch.Draw(textDict["test2"], new Vector2(500, 0), Color.White); }
            //else if (count < 600) { spriteBatch.Draw(textDict["test2"], new Vector2(500, 100), Color.White); }
            //else if (count < 700) { spriteBatch.Draw(textDict["test2"], new Vector2(500, 200), Color.White); }
            //else if (count < 800) { spriteBatch.Draw(textDict["test2"], new Vector2(500, 300), Color.White); }
            //else if (count < 900) { spriteBatch.Draw(textDict["test2"], new Vector2(500, 300), Color.White); }
            //else if (count < 1000) { spriteBatch.Draw(textDict["test2"], new Vector2(400, 300), Color.White); }
            //else if (count < 1100) { spriteBatch.Draw(textDict["test2"], new Vector2(300, 300), Color.White); }
            //else if (count < 1200) { spriteBatch.Draw(textDict["test2"], new Vector2(200, 300), Color.White); }
            //else if (count < 1300) { spriteBatch.Draw(textDict["test2"], new Vector2(100, 300), Color.White); }
            //else if (count < 1400) { spriteBatch.Draw(textDict["test2"], new Vector2(100, 0), Color.White); }
            //else if (count < 1500) { spriteBatch.Draw(textDict["test2"], new Vector2(500, 300), Color.White); }
            //else if (count < 1600) { spriteBatch.Draw(textDict["test2"], new Vector2(100, 300), Color.White); }
            //else if (count < 1700) { spriteBatch.Draw(textDict["test2"], new Vector2(300, 150), Color.White); }
            //else { spriteBatch.Draw(textDict["test2"], new Vector2(0, 400), Color.White); }

            //if (count == 1700) { count = 0; }
            //count += 10;
        }
    }
}
