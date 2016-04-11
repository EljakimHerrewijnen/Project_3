using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Project_3_main_application.Marcels_partition;

/*  Deze file is van: "Marc Harreman"
*
*/

namespace Project_3_main_application
{
    class Marc_basis
    {
        public void LoadContent(Globalvars GlobalVars, Game1 game1)
        {
            //Hier kan je al je plaatjes enzo laden
            GlobalVars.textDict.Add("test", game1.Content.Load<Texture2D>("rotterdam.png"));
        }

        public void Initialize(Globalvars GlobalVars)
        {
            //Hier kan je initializatie doen
        }

        public void unloadContent()
        {
            //Hier kan je dingen ontladen
        }

        public void Update(GameTime gameTime)
        {
            //Hier moet je update logica komen
        }

        public void Draw(SpriteBatch spriteBatch, Globalvars GlobalVars)
        {
            spriteBatch.Draw(GlobalVars.textDict["test"], new Vector2(0, 0), Color.White);
            //Hier moet je drawen
        }
    }
}
