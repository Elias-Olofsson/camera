using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{

    class Redbox
    {
        public Texture2D redbox;
        Vector2 redboxPosition = new Vector2(1, 1);
        public Redbox(Texture2D redbox)
        {
            this.redbox = redbox;
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(redbox,new Rectangle(redboxPosition.ToPoint(),new Point(10,10)), Color.White);
        }
    }
}
