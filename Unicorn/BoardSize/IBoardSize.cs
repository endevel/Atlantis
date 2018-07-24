using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicorn.BoardSize
{
    public interface IBoardSize
    {
        int Height { get; }
        int Width { get; }
    }
}
