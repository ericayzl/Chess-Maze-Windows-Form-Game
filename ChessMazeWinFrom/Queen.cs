using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayer
{
    class Queen : Piece
    {
        public Queen(int yValue, int xValue, int boardSize)
        {
            YCoordinate = yValue;
            XCoordinate = xValue;
            Name = FilerNS.Part.Queen;
            BoardWidth = boardSize;
            SetAllowedUpMoves();
            SetAllowedDownMoves();
            SetAllowedLeftMoves();
            SetAllowedRightMoves();
            SetAllowedUpLeftMoves();
            SetAllowedUpRightMoves();
            SetAllowedDownLeftMoves();
            SetAllowedDownRightMoves();
        }

        override public void ActiveTile()
        {
            Name = FilerNS.Part.PlayerOnQueen;
        }

        override public void NotActiveTile()
        {
            Name = FilerNS.Part.Queen;
        }

        override protected bool SetAllowedUpMoves()
        {
            AllowedUpMoves.Clear();
            for (int i = YCoordinate - 1; i >= BoardMin; i--)
            {
                string allowedMove = $"{i} : {XCoordinate}";
                AllowedUpMoves.Add(allowedMove);
            }
            bool moveIsSet = true;
            return moveIsSet;
        }

        override protected bool SetAllowedDownMoves()
        {
            AllowedDownMoves.Clear();
            for (int i = YCoordinate + 1; i < BoardWidth; i++)
            {
                string allowedMove = $"{i} : {XCoordinate}";
                AllowedDownMoves.Add(allowedMove);
            }
            bool moveIsSet = true;
            return moveIsSet;
        }

        override protected bool SetAllowedLeftMoves()
        {
            AllowedLeftMoves.Clear();
            for (int i = XCoordinate - 1; i >= BoardMin; i--)
            {
                string allowedMove = $"{YCoordinate} : {i}";
                AllowedLeftMoves.Add(allowedMove);
            }
            bool moveIsSet = true;
            return moveIsSet;
        }

        override protected bool SetAllowedRightMoves()
        {
            AllowedRightMoves.Clear();
            for (int i = XCoordinate + 1; i < BoardWidth; i++)
            {
                string allowedMove = $"{YCoordinate} : {i}";
                AllowedRightMoves.Add(allowedMove);
            }
            bool moveIsSet = true;
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
