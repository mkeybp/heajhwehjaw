using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
 
namespace heajhwehjaw
{
    class Node
    {
        protected int gScore;
        protected int hScore;
        protected int fScore;

        protected bool walkable;

        protected Vector2 position;
        protected Vector2 goal;

        protected Node parent;

        public List<Node> neighbors = new List<Node>();

        public int G
        {
            get { return gScore; }
            set { gScore = value; }
        }
        public int H
        {
            get { return hScore; }
        }
        public int F
        {
            get { return fScore; }

        }
        public bool canWalk
        {
            get { return walkable; }
            set { walkable = value; }
        }
        public Vector2 Position
        {
            get { return position; }
        }

        public Node Parent
        {
            get { return parent; }
            set { parent = value; }

        }

        public Node(Node parent, Vector2 position, Vector2 goal)
        {
            this.parent = parent;
            this.position = position;
            this.goal = goal;

        }

        public void Update()
        {
            hScore = (int)Math.Sqrt((Math.Pow((goal.X - position.X), 2)) + (Math.Pow((goal.Y - position.Y), 2)));
            fScore = gScore + hScore;
        }
    }
}