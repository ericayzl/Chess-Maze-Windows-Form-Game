using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayer
{
    class Bishop : Piece
    {
        public Bishop(int yValue, int xValue, int boardSize)
        {
            YCoordinate = yValue;
            XCoordinate = xValue;
            Name = FilerNS.Part.Bishop;
            BoardWidth = boardSize;
            SetAllowedUpLeftMoves();
            SetAllowedUpRightMoves();
            SetAllowedDownLeftMoves();
            SetAllowedDownRightMoves();
        }

        override public void ActiveTile()
        {
            Name = FilerNS.Part.PlayerOnBishop;
        }

        override public void NotActiveTile()
        {
            Name = FilerNS.Part.Bishop;
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
            AllowedUpLeftMoves.Clear();
            int step = 1;
            for (int i = YCoordinate; i > BoardMin; i--)
            {
                string allowedMove = $"{YCoordinate - step} : {XCoordinate - step}";
                AllowedUpLeftMoves.Add(allowedMove);
                step++;
            }
            bool moveIsSet = true;
            return moveIsSet;
        }
        override protected bool SetAllowedUpRightMoves()
        {
            AllowedUpRightMoves.Clear();
            int step = 1;
            for (int i = YCoordinate; i > BoardMin; i--)
            {
                string allowedMove = $"{YCoordinate - step} : {XCoordinate + step}";
                AllowedUpRightMoves.Add(allowedMove);
                step++;
            }
            bool moveIsSet = true;
            return moveIsSet;
        }
        override protected bool SetAllowedDownLeftMoves()
        {
            AllowedDownLeftMoves.Clear();
            int step = 1;
            for (int i = YCoordinate; i < (BoardWidth - 1); i++)
            {
                string allowedMove = $"{YCoordinate + step} : {XCoordinate - step}";
                AllowedDownLeftMoves.Add(allowedMove);
                step++;
            }
            bool moveIsSet = true;
            return moveIsSet;
        }
        override protected bool SetAllowedDownRightMoves()
        {
            AllowedDownRightMoves.Clear();
            int step = 1;
            for (int i = YCoordinate; i < (BoardWidth - 1); i++)
            {
                string allowedMove = $"{YCoordinate + step} : {XCoordinate + step}";
                AllowedDownRightMoves.Add(allowedMove);
                step++;
            }
            bool moveIsSet = true;
            return moveIsSet;
        }
    }
}
