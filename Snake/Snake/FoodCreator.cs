using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        private int mapWidht;
        private int mapHeight;
        private char sym;

        public FoodCreator(int usrMapWidht, int usrMapHeight, char usrSym)
        {
            mapWidht = usrMapWidht;
            mapHeight = usrMapHeight;
            sym = usrSym;
        }

        public Point CreateFood()
        {
            Random random = new Random();
            int x = random.Next(2, mapWidht - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}
