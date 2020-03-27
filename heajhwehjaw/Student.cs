using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace heajhwehjaw
{
    public class Student : GameObject
    {
       

        public Student(Texture2D studentSprite, Vector2 pos)
        {
            //this.position.X = 100;
            //this.position.Y = 10;

            this.position = pos;


            this.sprite = studentSprite;
        }

        public override void LoadContent(ContentManager content)
        {
            throw new NotImplementedException();
        }

        public override void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }



        //private void Move(GameTime gameTime)
        //{
        //    float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

        //    position += ((velocity * speed) * deltaTime);
        //}
        //private void Gravity(GameTime gameTime)
        //{
        //    velocity += new Vector2(0, 1);

        //    Move(gameTime);
        //}
    }
}
