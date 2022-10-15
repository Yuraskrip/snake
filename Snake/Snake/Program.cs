
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Program
    {
        static void Main(string[] args) 
        {
            //размер окна
            //Console.SetWindowSize(80, 25);
            // Console.SetBufferSize(80,25);
            //Console.BufferHeight = 25;
            //Console.BufferWidth = 80;
            //Console.BufferHeight = 25;
        
             //отрисовка рамки
             HorozontalLine upLine = new HorozontalLine(0, 78, 0, '+');
            HorozontalLine downLine = new HorozontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();  




            //отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();



           // HorozontalLine line = new HorozontalLine(5, 10, 8, '+');
            //line.Drow();






            Console.ReadLine();
        }
       
       
    }
}
