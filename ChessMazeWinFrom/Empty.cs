using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayer
{
    class Empty : Piece
    {
        public Empty(int yValue, int xValue, int boardSize)
        {
            YCoordinate = yValue;
            XCoordinate = xValue;
            Name = FilerNS.Part.Empty;
            BoardWidth = boardSize;
        }

        override public void ActiveTile() {
            Name = FilerNS.Part.Empty;
        }

        override public void NotActiveTile() {
            Name = FilerNS.Part.Empty;
        }

        override protected bool SetAllowedUpMoves()
        {
            bool moveIsSet = false;
            return moveIsSet;
        }

        override protected bool SetAllowedDownMoves()
        {
            bool moveIsSet = false;
            return moveIsSet;
        }

        override protected bool SetAllowedLeftMoves()
        {
            bool moveIsSet = false;
            return moveIsSet;
        }

        override protected bool SetAllowedRightMoves()
        {
            bool moveIsSet = false;
            return moveIsSet;
        }

        override protected bool SetAllowedUpLeftMoves()
        {
            bool moveIsSet = false;
            return moveIsSet;
        }

        override protected bool SetAllowedUpRightMoves()
        {
            bool moveIsSet = false;
            return moveIsSet;
        }

        override protected bool SetAllowedDownLeftMoves()
        {
            bool moveIsSet = false;
            return moveIsSet;
        }

        override protected bool SetAllowedDownRightMoves()
        {
            bool moveIsSet = false;
            return moveIsSet;
        }
    }
}
