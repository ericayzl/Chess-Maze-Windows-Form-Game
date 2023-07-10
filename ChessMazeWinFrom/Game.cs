using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameNS;

namespace GamePlayer 
{
    public class Game : IGame
    {
        //public Piece[,] Board = new Piece[4, 4] { 
        //    { new Rook(0, 0), new Empty(0, 1), new Bishop(0, 2), new Empty(0, 3) }, 
        //    { new Empty(1, 0), new Rook(1, 1), new Empty(1, 2), new Bishop(1, 3) }, 
        //    { new Knight(2, 0), new Knight(2, 1), new Bishop(2, 2), new King(2, 3) }, 
        //    { new Rook(3, 0), new Empty(3, 1), new Empty(3, 2), new King(3, 3) } };

        public Piece[,] Board;
        public List<string> EmptyTiles = new List<string>();

        public string TheCurrentTile => $"{_currentTile[0]} : {_currentTile[1]}";
        private int[] _currentTile = new int[] { 0, 0 };

        private List<string> _currentAllowedUpMoves = new List<string>();
        private List<string> _currentAllowedDownMoves = new List<string>();
        private List<string> _currentAllowedLeftMoves = new List<string>();
        private List<string> _currentAllowedRightMoves = new List<string>();
        private List<string> _currentAllowedUpLeftMoves = new List<string>();
        private List<string> _currentAllowedUpRightMoves = new List<string>();
        private List<string> _currentAllowedDownLeftMoves = new List<string>();
        private List<string> _currentAllowedDownRightMoves = new List<string>();

        private string _winningTile;
        private int _numOfMoves = 0;

        private int _boardSize;
        private const int _minCoordinate = 0;

        private Stack<string> _previousMoves = new Stack<string>();


        public void Move(Direction moveDirection)
        {
            const int DefaultStep = 1;
            switch (moveDirection)
            {
                case Direction.Up:

                    int[] newUpTile = new int[] { _currentTile[0] - DefaultStep, _currentTile[1] };
                    GenerateUpAction(newUpTile[0], newUpTile[1], DefaultStep);
                    break;

                case Direction.Down:

                    int[] newDownTile = new int[] { _currentTile[0] + DefaultStep, _currentTile[1] };
                    GenerateDownAction(newDownTile[0], newDownTile[1], DefaultStep);
                    break;

                case Direction.Left:
                    int[] newLeftTile = new int[] { _currentTile[0], _currentTile[1] - DefaultStep };
                    GenerateLeftAction(newLeftTile[0], newLeftTile[1], DefaultStep);
                    break;

                case Direction.Right:
                    int[] newRightTile = new int[] { _currentTile[0], _currentTile[1] + DefaultStep };
                    GenerateRightAction(newRightTile[0], newRightTile[1], DefaultStep);
                    break;

                case Direction.UpLeft:
                    int[] newUpLeftTile = new int[] { _currentTile[0] - DefaultStep, _currentTile[1] - DefaultStep };
                    GenerateUpLeftAction(newUpLeftTile[0], newUpLeftTile[1], DefaultStep);
                    break;

                case Direction.UpRight:
                    int[] newUpRightTile = new int[] { _currentTile[0] - DefaultStep, _currentTile[1] + DefaultStep };
                    GenerateUpRightAction(newUpRightTile[0], newUpRightTile[1], DefaultStep);
                    break;

                case Direction.DownLeft:
                    int[] newDownLeftTile = new int[] { _currentTile[0] + DefaultStep, _currentTile[1] - DefaultStep };
                    GenerateDownLeftAction(newDownLeftTile[0], newDownLeftTile[1], DefaultStep);
                    break;

                case Direction.DownRight:
                    int[] newDownRightTile = new int[] { _currentTile[0] + DefaultStep, _currentTile[1] + DefaultStep };
                    GenerateDownRightAction(newDownRightTile[0], newDownRightTile[1], DefaultStep);
                    break;
            }
        }

        public void Move(Direction moveDirection, int step)
        {
            switch (moveDirection)
            {
                case Direction.Up:

                    int[] newUpTile = new int[] { _currentTile[0] - step, _currentTile[1] };
                    GenerateUpAction(newUpTile[0], newUpTile[1], step);
                    break;

                case Direction.Down:

                    int[] newDownTile = new int[] { _currentTile[0] + step, _currentTile[1] };
                    GenerateDownAction(newDownTile[0], newDownTile[1], step);
                    break;

                case Direction.Left:
                    int[] newLeftTile = new int[] { _currentTile[0], _currentTile[1] - step };
                    GenerateLeftAction(newLeftTile[0], newLeftTile[1], step);
                    break;

                case Direction.Right:
                    int[] newRightTile = new int[] { _currentTile[0], _currentTile[1] + step };
                    GenerateRightAction(newRightTile[0], newRightTile[1], step);
                    break;

                case Direction.UpLeft:
                    int[] newUpLeftTile = new int[] { _currentTile[0] - step, _currentTile[1] - step };
                    GenerateUpLeftAction(newUpLeftTile[0], newUpLeftTile[1], step);
                    break;

                case Direction.UpRight:
                    int[] newUpRightTile = new int[] { _currentTile[0] - step, _currentTile[1] + step };
                    GenerateUpRightAction(newUpRightTile[0], newUpRightTile[1], step);
                    break;

                case Direction.DownLeft:
                    int[] newDownLeftTile = new int[] { _currentTile[0] + step, _currentTile[1] - step };
                    GenerateDownLeftAction(newDownLeftTile[0], newDownLeftTile[1], step);
                    break;

                case Direction.DownRight:
                    int[] newDownRightTile = new int[] { _currentTile[0] + step, _currentTile[1] + step };
                    GenerateDownRightAction(newDownRightTile[0], newDownRightTile[1], step);
                    break;
            }
        }

        public void MoveKnight(int yValue, int xValue)
        {
            if (Board[_currentTile[0], _currentTile[1]].Name == FilerNS.Part.PlayerOnKnight)
            {
                bool validKnightMoveOne = Math.Abs(yValue) == 1 && Math.Abs(xValue) == 2;
                bool validKnightMoveTwo = Math.Abs(yValue) == 2 && Math.Abs(xValue) == 1;

                if (validKnightMoveOne || validKnightMoveTwo)
                {
                    int[] newTile = new int[] { _currentTile[0] + yValue, _currentTile[1] + xValue };
                    string stringNewTile = $"{newTile[0]} : {newTile[1]}";

                    if (IsWithinBoard(newTile[0], newTile[1]) && (EmptyTiles.Contains(stringNewTile) == false))
                    {
                        SuccessfulAction(newTile[0], newTile[1]);
                    }
                }
            }
        }


        public int GetMoveCount()
        {
            return _numOfMoves;
        }


        public void Undo()
        {
            if (_numOfMoves > 0)
            {
                string lastMove = _previousMoves.Pop();
                _currentTile = new int[] { int.Parse(lastMove[0].ToString()), int.Parse(lastMove[4].ToString()) };
                UpdateCurrentTileFeatures();
                _numOfMoves--;
            }
        }


        public void Restart()
        {
            _currentTile = new int[] { 0, 0 };
            _numOfMoves = 0;
            _previousMoves.Clear();
            UpdateCurrentTileFeatures();
        }


        public bool IsFinished()
        {
            string currentTile = $"{_currentTile[0]} : {_currentTile[1]}";
            Console.WriteLine($"Winning tile is: {_winningTile}");
            Console.WriteLine($"Current tile is: {currentTile}");
            return currentTile == _winningTile;
        }


        public void Load(string newLevel) {

            _boardSize = newLevel.IndexOf("\n");

            Board = new Piece[_boardSize, _boardSize];

            int stringIndex = 0;

            for (int y = 0; y < _boardSize; y++) {
                for (int x = 0; x < _boardSize; x++) {
                    switch (newLevel[stringIndex].ToString()) {
                        case "E":
                            Board[y, x] = new Empty(y, x, _boardSize);
                            EmptyTiles.Add($"{y} : {x}");
                            break;
                        case "K":
                            Board[y, x] = new King(y, x, _boardSize);
                            break;
                        case "R":
                            Board[y, x] = new Rook(y, x, _boardSize);
                            break;
                        case "B":
                            Board[y, x] = new Bishop(y, x, _boardSize);
                            break;
                        case "Q":
                            Board[y, x] = new Queen(y, x, _boardSize);
                            break;
                        case "N":
                            Board[y, x] = new Knight(y, x, _boardSize);
                            break;
                    }
                    stringIndex++;
                }
                stringIndex++;
            }
            UpdateCurrentTileFeatures();
            _winningTile = $"{_boardSize - 1} : {_boardSize - 1}";
        }


        private void UpdateCurrentTileFeatures() {
            Board[_currentTile[0], _currentTile[1]].ActiveTile();
            _currentAllowedUpMoves = Board[_currentTile[0], _currentTile[1]].AllowedUpMoves;
            _currentAllowedDownMoves = Board[_currentTile[0], _currentTile[1]].AllowedDownMoves;
            _currentAllowedLeftMoves = Board[_currentTile[0], _currentTile[1]].AllowedLeftMoves;
            _currentAllowedRightMoves = Board[_currentTile[0], _currentTile[1]].AllowedRightMoves;
            _currentAllowedUpLeftMoves = Board[_currentTile[0], _currentTile[1]].AllowedUpLeftMoves;
            _currentAllowedUpRightMoves = Board[_currentTile[0], _currentTile[1]].AllowedUpRightMoves;
            _currentAllowedDownLeftMoves = Board[_currentTile[0], _currentTile[1]].AllowedDownLeftMoves;
            _currentAllowedDownRightMoves = Board[_currentTile[0], _currentTile[1]].AllowedDownRightMoves;
        }


        private bool IsUpNoBlock(int numOfSteps) {
            bool canMove = true;
            int yTile = _currentTile[0];
            int xTile = _currentTile[1];

            for (int i = 1; i < numOfSteps; i++)
            {
                if (Board[(yTile - i), xTile].Name != FilerNS.Part.Empty)
                {
                    canMove = false;
                    break;
                }
            }
            return canMove;
        }

        private bool IsDownNoBlock(int numOfSteps)
        {
            bool canMove = true;
            int yTile = _currentTile[0];
            int xTile = _currentTile[1];

            for (int i = 1; i < numOfSteps; i++)
            {
                if (Board[(yTile + i), xTile].Name != FilerNS.Part.Empty)
                {
                    canMove = false;
                    break;
                }
            }
            return canMove;
        }

        private bool IsLeftNoBlock(int numOfSteps)
        {
            bool canMove = true;
            int yTile = _currentTile[0];
            int xTile = _currentTile[1];

            for (int i = 1; i < numOfSteps; i++)
            {
                if (Board[yTile, (xTile - i)].Name != FilerNS.Part.Empty)
                {
                    canMove = false;
                    break;
                }
            }
            return canMove;
        }

        private bool IsRightNoBlock(int numOfSteps)
        {
            bool canMove = true;
            int yTile = _currentTile[0];
            int xTile = _currentTile[1];

            for (int i = 1; i < numOfSteps; i++)
            {
                if (Board[yTile, (xTile + i)].Name != FilerNS.Part.Empty)
                {
                    canMove = false;
                    break;
                }
            }
            return canMove;
        }

        private bool IsUpLeftNoBlock(int numOfSteps)
        {
            bool canMove = true;
            int yTile = _currentTile[0];
            int xTile = _currentTile[1];

            for (int i = 1; i < numOfSteps; i++)
            {
                if (Board[(yTile - i), (xTile - i)].Name != FilerNS.Part.Empty)
                {
                    canMove = false;
                    break;
                }
            }
            return canMove;
        }

        private bool IsUpRightNoBlock(int numOfSteps)
        {
            bool canMove = true;
            int yTile = _currentTile[0];
            int xTile = _currentTile[1];

            for (int i = 1; i < numOfSteps; i++)
            {
                if (Board[(yTile - i), (xTile + i)].Name != FilerNS.Part.Empty)
                {
                    canMove = false;
                    break;
                }
            }
            return canMove;
        }

        private bool IsDownLeftNoBlock(int numOfSteps)
        {
            bool canMove = true;
            int yTile = _currentTile[0];
            int xTile = _currentTile[1];

            for (int i = 1; i < numOfSteps; i++)
            {
                if (Board[(yTile + i), (xTile - i)].Name != FilerNS.Part.Empty)
                {
                    canMove = false;
                    break;
                }
            }
            return canMove;
        }

        private bool IsDownRightNoBlock(int numOfSteps)
        {
            bool canMove = true;
            int yTile = _currentTile[0];
            int xTile = _currentTile[1];
            for (int i = 1; i < numOfSteps; i++)
            {
                if (Board[(yTile + i), (xTile + i)].Name != FilerNS.Part.Empty)
                {
                    canMove = false;
                    break;
                }
            }
            return canMove;
        }

        private bool IsWithinBoard(int yValue, int xValue) {
            bool valid = false;
            if (yValue >= _minCoordinate && yValue < _boardSize && xValue >= _minCoordinate && xValue < _boardSize) {
                valid = true;
            }
            return valid;
        }

        private void SuccessfulAction(int yValue, int xValue) {

            Board[_currentTile[0], _currentTile[1]].NotActiveTile();
            _previousMoves.Push($"{_currentTile[0]} : {_currentTile[1]}");
            _currentTile = new int[] { yValue, xValue };
            UpdateCurrentTileFeatures();
            _numOfMoves++;
        }

        private void GenerateUpAction(int yValue, int xValue, int step)
        {
            if (IsWithinBoard(yValue, xValue))
            {
                string stringNewTile = $"{yValue} : {xValue}";
                if (_currentAllowedUpMoves.Contains(stringNewTile) && (EmptyTiles.Contains(stringNewTile) == false) && IsUpNoBlock(step))
                {
                    SuccessfulAction(yValue, xValue);
                }
            }
        }

        private void GenerateDownAction(int yValue, int xValue, int step)
        {
            if (IsWithinBoard(yValue, xValue))
            {
                string stringNewTile = $"{yValue} : {xValue}";
                if (_currentAllowedDownMoves.Contains(stringNewTile) && (EmptyTiles.Contains(stringNewTile) == false) && IsDownNoBlock(step))
                {
                    SuccessfulAction(yValue, xValue);
                }
            }
        }

        private void GenerateLeftAction(int yValue, int xValue, int step)
        {
            if (IsWithinBoard(yValue, xValue))
            {
                string stringNewTile = $"{yValue} : {xValue}";
                if (_currentAllowedLeftMoves.Contains(stringNewTile) && (EmptyTiles.Contains(stringNewTile) == false) && IsLeftNoBlock(step))
                {
                    SuccessfulAction(yValue, xValue);
                }
            }
        }

        private void GenerateRightAction(int yValue, int xValue, int step)
        {
            if (IsWithinBoard(yValue, xValue))
            {
                string stringNewTile = $"{yValue} : {xValue}";
                if (_currentAllowedRightMoves.Contains(stringNewTile) && (EmptyTiles.Contains(stringNewTile) == false) && IsRightNoBlock(step))
                {
                    SuccessfulAction(yValue, xValue);
                }
            }
        }


        private void GenerateUpLeftAction(int yValue, int xValue, int step)
        {
            if (IsWithinBoard(yValue, xValue))
            {
                string stringNewTile = $"{yValue} : {xValue}";
                if (_currentAllowedUpLeftMoves.Contains(stringNewTile) && (EmptyTiles.Contains(stringNewTile) == false) && IsUpLeftNoBlock(step))
                {
                    SuccessfulAction(yValue, xValue);
                }
            }
        }

        private void GenerateUpRightAction(int yValue, int xValue, int step)
        {
            if (IsWithinBoard(yValue, xValue))
            {
                string stringNewTile = $"{yValue} : {xValue}";
                if (_currentAllowedUpRightMoves.Contains(stringNewTile) && (EmptyTiles.Contains(stringNewTile) == false) && IsUpRightNoBlock(step))
                {
                    SuccessfulAction(yValue, xValue);
                }
            }
        }

        private void GenerateDownLeftAction(int yValue, int xValue, int step)
        {
            if (IsWithinBoard(yValue, xValue))
            {
                string stringNewTile = $"{yValue} : {xValue}";
                if (_currentAllowedDownLeftMoves.Contains(stringNewTile) && (EmptyTiles.Contains(stringNewTile) == false) && IsDownLeftNoBlock(step))
                {
                    SuccessfulAction(yValue, xValue);
                }
            }
        }

        private void GenerateDownRightAction(int yValue, int xValue, int step)
        {
            if (IsWithinBoard(yValue, xValue))
            {
                string stringNewTile = $"{yValue} : {xValue}";
                if (_currentAllowedDownRightMoves.Contains(stringNewTile) && (EmptyTiles.Contains(stringNewTile) == false) && IsDownRightNoBlock(step))
                {
                        SuccessfulAction(yValue, xValue);
                }
            }
        }
    }
}
