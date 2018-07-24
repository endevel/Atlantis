using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicorn.BoardSize
{
    class BigSize : IBoardSize
    {
        public BigSize()
        {
            Height = 10;
            Width = 10;
        }

        public int Height { get; }
        public int Width { get; }
    }
}
