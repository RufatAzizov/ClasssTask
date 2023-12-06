

namespace abstract1;
internal class Program
{
    static void Main(string[] args)
    {
        Fish dolphin = new Dolphin();
        Bird bird = new Owl();

        bird.fly();
        dolphin.swim();
        bird.Eat();
        dolphin.Eat();
    }
}
