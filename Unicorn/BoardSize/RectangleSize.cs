using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicorn.BoardSize
{
    class RectangleSize : IBoardSize
    {
        public RectangleSize()
        {
            Height = 8;
            Width = 10;
        }

        public int Height { get; }
        public int Width { get; }
    }
}
