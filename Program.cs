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
            renderer.GetCoordinatePlayer(player1.CoordinateX, player1.CoordinateY);
        }

        class Player
        {
            public int CoordinateX = 10;
            public int CoordinateY = 10;
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

