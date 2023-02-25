using System;
using System.Numerics;

namespace vn_mode_csharp_dz_39
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(10, 10);
            Renderer renderer = new Renderer();
            renderer.GetCoordinatePlayer(player1.CoordinateX, player1.CoordinateY);
        }

        class Player
        {
            public Player(int coordinateX, int coordinateY)
            {
                CoordinateX = coordinateX;
                CoordinateY = coordinateY;
            }

            public int CoordinateX { get; private set; }
            public int CoordinateY { get; private set; }

        }

        class Renderer
        {
            char Player = '@';
            public void GetCoordinatePlayer(int coordinateX, int coordinateY)
            {
                Console.SetCursorPosition(coordinateX, coordinateY);
                Console.Write(Player);
            }
        }
    }
}

