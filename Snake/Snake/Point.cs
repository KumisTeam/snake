using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int usr_x, int usr_y, char usr_sym)
        {
            x = usr_x;
            y = usr_y;
            sym = usr_sym;
        }

        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
            this.sym = p.sym;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
                x += offset;
            else if (direction == Direction.LEFT)
                x -= offset;
            else if (direction == Direction.UP)
                y -= offset;
            else if (direction == Direction.DOWN)
                y += offset;
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
    }
}
