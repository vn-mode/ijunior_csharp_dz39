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
            renderer.GetCoordinatePlayer();
        }

        class Player
        {
            protected int CoordinateX = 10;
            protected int CoordinateY = 10;
        }
        class Renderer : Player
        {
            char Player = '@';
            public void GetCoordinatePlayer()
            {
                Console.SetCursorPosition(CoordinateX, CoordinateY);
                Console.Write(Player);
            }
        }
    }
}

