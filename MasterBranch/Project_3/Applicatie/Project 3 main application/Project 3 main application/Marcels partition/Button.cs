using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

/*
*Deze file is van: "Marcle Bostelaar"
*/

namespace Project_3_main_application.Marcels_partition
{
    class Button
    {
        private Texture2D plaatje;
        private bool clickable;
        private Vector2 positie;
        private string text;
        private Vector2 textoffset;

        private Vector2 dimenties;
        private string font;


        public Button(string Font, Texture2D Plaatje, bool Clickable, Vector2 Positie, string Text, Vector2 TextOffsetFromCenter)
        {
            font = Font;
            plaatje = Plaatje;
            clickable = Clickable;
            positie = Positie;
            text = Text;
            textoffset = TextOffsetFromCenter;

            dimenties = new Vector2(plaatje.Width, plaatje.Height);
        }
        public Button(string Font, Texture2D Plaatje, bool Clickable, string Text, Vector2 textoffsetfromcenter)
        {
            font = Font;
            plaatje = Plaatje;
            clickable = Clickable;
            positie = new Vector2(0,0);
            text = Text;
            textoffset = new Vector2(0, 0);

            dimenties = new Vector2(plaatje.Width, plaatje.Height);
        }
        public Button(string Font, Texture2D Plaatje, bool Clickable, Vector2 Positie)
        {
            font = Font;
            plaatje = Plaatje;
            clickable = Clickable;
            positie = Positie;
            text = null;
            textoffset = new Vector2(0, 0);

            dimenties = new Vector2(plaatje.Width, plaatje.Height);
        }
        public Button(string Font, Texture2D Plaatje, bool Clickable)
        {
            font = Font;
            plaatje = Plaatje;
            clickable = Clickable;
            positie = new Vector2(0, 0);
            text = null;
            textoffset = new Vector2(0, 0);

            dimenties = new Vector2(plaatje.Width, plaatje.Height);
        }


        public Vector2 Dimenties {
            get{return dimenties;} 
        }

        public void Draw(SpriteBatch spritebatch, Dictionary<string, Texture2D> textDict, Dictionary<string, SpriteFont> fontDict)
        {
            spritebatch.Draw(plaatje, positie, Color.White);
            if(text != null)
            {
                Vector2 sizetext = fontDict[font].MeasureString(text);
                Vector2 renderpos = positie / 2 - sizetext / 2 + textoffset;
                spritebatch.DrawString(fontDict[font], text, renderpos, Color.White);
            }
        }
    }
}
