namespace CSharpBasics
{
    class UsingOOP
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Suleyman","Computer Science", 2.7);
            Student[] students= new Student[2]; 

            for (int i = 0;i < 2; i++) {
                Console.WriteLine("name: ");
                string name = Console.ReadLine();
                Console.WriteLine("major: ");

                string major = Console.ReadLine();
                Console.WriteLine("gpa: ");

                string inputGpa = Console.ReadLine();
                double gpa = double.Parse(inputGpa);
                students[i] = new Student(name,major,gpa);
            };

            foreach (Student student in students)
            {
                Console.WriteLine(
                    "name: " + student.name + " " +
                    "major:" + student.major + " " +
                    "gpa: " + student.gpa
                    ); ; ;
            }

            Book book1 = new Book("harry Potter", "JK Rowling",400);
            Book book2 = new Book("Lord of the Rings", "Tolkein",700);

            Console.WriteLine(book1.title);
            Console.WriteLine(book2.title);

            book2.title = "Hobbits";
            Console.WriteLine(book2.title);


            /*
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
            */
        }
    }
}