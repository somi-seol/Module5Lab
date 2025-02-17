using System;

namespace Module5Lab
{
    internal class SuperPlayer : Player // Superplayer is child, Player is parent
    {
        public void Fly()
        {
            Console.WriteLine("SuperPlayer is flying!");
        }
    }
}