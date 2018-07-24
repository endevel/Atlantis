using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicorn.BoardSize;

namespace Unicorn.GameRules
{
    /// <summary>
    /// Определяет набор флагов, по которым отличаются различные правила игры.
    /// </summary>
    public interface IGameRules
    {
        /// <summary>
        /// Размер доски
        /// </summary>
        IBoardSize BoardSize { get; }
        /// <summary>
        /// Простая может бить назад
        /// </summary>
        bool IsManTakeBack { get; }
        /// <summary>
        /// Простая может бить дамку
        /// </summary>
        bool IsManTakeKing { get; }
        /// <summary>
        /// 
        /// </summary>
        bool IsPromoteImmediate { get; }
        bool IsTakeMost { get; }
        bool IsLangRangeKing { get; }
    }
}
