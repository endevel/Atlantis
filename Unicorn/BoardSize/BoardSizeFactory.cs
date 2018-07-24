using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicorn.BoardSize
{
    public class BoardSizeFactory
    {
        public static IBoardSize CreateStandardBoard()
        {
            return new StandardSize();
        }

        public static IBoardSize CreateBigBoard()
        {
            return new BigSize();
        }

        public static IBoardSize CreateLargeBoard()
        {
            return new LargeSize();
        }

        public static IBoardSize CreateRectangleBoard()
        {
            return new RectangleSize();
        }
    }
}
