using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicorn.BoardSize
{
    class StandardSize : IBoardSize
    {
        public StandardSize()
        {
            Height = 8;
            Width = 8;
        }

        public int Height { get; }
        public int Width { get; }
    }
}
