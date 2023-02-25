using System;
using System.Numerics;

namespace vn_mode_csharp_dz_39
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            Renderer renderer = new Renderer();
            renderer.GetPlayerCoordinates();
        }

        class Player
        {
            protected int _x = 10;
            protected int _y = 10;
        }

        class Renderer : Player
        {
            private char Player = '@';

            public void GetPlayerCoordinates()
            {
                Console.SetCursorPosition(_x, _y);
                Console.Write(Player);
            }
        }
    }
}

