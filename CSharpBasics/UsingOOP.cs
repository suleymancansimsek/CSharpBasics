namespace CSharpBasics
{
    class UsingOOP
    {
        static void Main(string[] args)
        {
            Enemy warrior = new Enemy(Enemy.Type.WARRIOR, 100, 20);
            Enemy archer = new Enemy(Enemy.Type.ARCHER, 80, 25);
            Enemy witch = new Enemy(Enemy.Type.WITCH, 60, 30);

            Console.WriteLine("{0} has {1} health and deals {2} damage", warrior.EnemyType, warrior.Health, warrior.Damage);
            Console.WriteLine("{0} has {1} health and deals {2} damage", archer.EnemyType, archer.Health, archer.Damage);
            Console.WriteLine("{0} has {1} health and deals {2} damage", witch.EnemyType, witch.Health, witch.Damage);

            warrior.Attack(archer);
            archer.Defense(warrior.Damage);

            Console.WriteLine("{0} has {1} health left", archer.EnemyType, archer.Health);

            Console.ReadKey();
        }
    }
}