using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicorn.BoardSize
{
    class LargeSize : IBoardSize
    {
        public LargeSize()
        {
            Height = 12;
            Width = 12;
        }

        public int Height { get; }
        public int Width { get; }
    }
}
