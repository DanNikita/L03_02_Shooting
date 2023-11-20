internal class Target
{
    public struct Shooting
    {
        public int x;
        public int y;
    }
    public static int ScoreAssess(Shooting a)
    {
        int res = 0;
        switch (a.x, a.y)
        {
            case ( < 5, < 5):
                res = 10; break;
            case ( < 10, < 5):
                res = 5; break;
            case ( < 5, < 10):
                res = 5; break;
            case ( < 10, < 10):
                res = 1; break;
            default: Console.WriteLine("No points at all!");
                break;
        }
        Console.WriteLine("Score for that try: {0}", res);
        return res;
    }
static void Main(string[] args)
{
    Console.WriteLine("Welcome to the shooting range! How much attempts do you want?");
    int attempts = int.Parse(Console.ReadLine());
    int[,] ShootArray = new int[attempts, 2];
    for (int i = 0; i < attempts; i++)
    {
        Console.WriteLine("Attempt No {0}", i + 1);
        Console.WriteLine("Enter x coordinate");
        int x = int.Parse(Console.ReadLine());
        ShootArray[i, 0] = x;
        Console.WriteLine("Enter y coordinate");
        int y = int.Parse(Console.ReadLine());
        ShootArray[i, 1] = y;
        Console.WriteLine("x,y: {0},{1}", ShootArray[i, 0], ShootArray[i, 1]);
    }
    int summary = 0;
    for (int i = 0; i < attempts; i++)
    {
        Console.WriteLine("Asessing attempt No {0}", i + 1);
        Shooting temp;
        temp.x = ShootArray[i, 0];
        temp.y = ShootArray[i, 1];
        int Score = ScoreAssess(temp);
        summary += Score;
    }
    Console.WriteLine("Total score {0}", summary);
    Console.ReadLine();
}
                         
        
      
}