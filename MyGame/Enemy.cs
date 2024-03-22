using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MyGame
{
    public class Enemy
    {
        //variables
        private string name;
        private float health;
        private float shield;
        
        public Enemy (string name)
        {
            this.name = name;
            health = 100;
            shield =0;
        }
      
    }
}