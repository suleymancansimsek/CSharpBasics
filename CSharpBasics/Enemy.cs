using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class Enemy
    {
        public enum Type
        {
            WARRIOR,
            ARCHER,
            WITCH
        }

        private Type _enemyType;
        private int _health;
        private int _damage;

        public Enemy(Type type, int health, int damage)
        {
            _enemyType = type;
            _health = health;
            _damage = damage;
        }

        public Type EnemyType
        {
            get { return _enemyType; }
        }

        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public int Damage
        {
            get { return _damage; }
        }

        public void Attack(Enemy target)
        {
            target.Health -= Damage;
            Console.WriteLine("{0} attacked {1} and dealt {2} damage", EnemyType, target.EnemyType, Damage);
        }

        public void Defense(int damage)
        {
            Health -= damage;
            Console.WriteLine("{0} defended and took {1} damage. Current health: {2}", EnemyType, damage, Health);
        }
    }
}

