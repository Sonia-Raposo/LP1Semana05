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
            shield = 0;
        }

        public string GetName ()
        {
            return name;

        }
        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }


        /// <summary>
        /// Damage is first inflicted on enemy shield, reducing its value
        /// If the shield value becomes 0, damage now is inflicted on health
        /// If damage inflicted lowers the enemy health bellow 0,
        /// the health value becomes 0 to avoid a negative health value
        /// </summary>
        /// <param name="damage"></param>
        public void TakeDamage (float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict =- shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0)
                    health = 0;
            }
        }

    }
}