using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePlayer;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using FilerNS;
using GameNS;


namespace ChessMazeWinFrom
{
    public class GameController
    {
        private readonly IView _view;
        private readonly Game _game;
        private string _fileStringGrid;
        // private IView _childViewSmall;

        public int GridWidthNumber;
        public int GridLengthNumber;

        private readonly Image _queen = ChessMazeWinFrom.Properties.Resources.queen;
        private readonly Image _king = ChessMazeWinFrom.Properties.Resources.king;
        private readonly Image _rook = ChessMazeWinFrom.Properties.Resources.rook;
        private readonly Image _knight = ChessMazeWinFrom.Properties.Resources.knight;
        private readonly Image _bishop = ChessMazeWinFrom.Properties.Resources.bishop;
        private readonly Image _empty = ChessMazeWinFrom.Properties.Resources.empty;

        public GameController(IView view, Game game)
        {
            _view = view;
            _game = game;
        }

        public void SetLoadString(string loadString)
        {
            _fileStringGrid = loadString;
        }

        //public void SetChildViewSmall(IView childview)
        //{
        //    _childViewSmall = childview;
        //}

        //public void SetGridWidth(int width)
        //{
        //    _gridWidthNumber = width;
        //}

        //public void SetGridLength(int length)
        //{
        //    _gridLengthNumber = length;
        //}

        public void Go()
        {
            _game.Load(_fileStringGrid);
            Debug.WriteLine(_game.TheCurrentTile);
            LoadButtonGrid();
            Debug.WriteLine(_game.Board[0, 0].Name);
            //NoBorderExCurrentGrid();
            //// Debug.WriteLine(GridWidthNumber);
            //_game.Move(GameNS.Direction.Right, 2);
            //UpdateCurrentGrid();
            GenerateMoveCount();
            DetermineMoveType();
        }

        public void LoadButtonGrid()
        {
            // Button[,] targetButton = _view.GridOfButtons;
            for (int y = 0; y < GridLengthNumber; y++)
            {
                for (int x = 0; x < GridWidthNumber; x++)
                {
                    switch (_game.Board[y, x].Name)
                    {
                        case FilerNS.Part.PlayerOnQueen:
                        case FilerNS.Part.Queen:
                            _view.GridOfButtons[y, x].BackgroundImage = _queen;
                            _view.GridOfButtons[y, x].BackgroundImageLayout = ImageLayout.Zoom;
                            _view.GridOfButtons[y, x].FlatAppearance.BorderSize = 0;
                            break;
                        case FilerNS.Part.PlayerOnEmpty:
                        case FilerNS.Part.Empty:
                            _view.GridOfButtons[y, x].BackgroundImage = _empty;
                            _view.GridOfButtons[y, x].BackgroundImageLayout = ImageLayout.Zoom;
                            break;
                        case FilerNS.Part.PlayerOnKing:
                        case FilerNS.Part.King:
                            _view.GridOfButtons[y, x].BackgroundImage = _king;
                            _view.GridOfButtons[y, x].BackgroundImageLayout = ImageLayout.Zoom;
                            break;
                        case FilerNS.Part.PlayerOnRook:
                        case FilerNS.Part.Rook:
                            _view.GridOfButtons[y, x].BackgroundImage = _rook;
                            _view.GridOfButtons[y, x].BackgroundImageLayout = ImageLayout.Zoom;
                            Debug.WriteLine($"Grid line: {y} : {x}");
                            break;
                        case FilerNS.Part.PlayerOnBishop:
                        case FilerNS.Part.Bishop:
                            _view.GridOfButtons[y, x].BackgroundImage = _bishop;
                            _view.GridOfButtons[y, x].BackgroundImageLayout = ImageLayout.Zoom;
                            break;
                        case FilerNS.Part.PlayerOnKnight:
                        case FilerNS.Part.Knight:
                            _view.GridOfButtons[y, x].BackgroundImage = _knight;
                            _view.GridOfButtons[y, x].BackgroundImageLayout = ImageLayout.Zoom;
                            break;
                    }

                    _view.GridOfButtons[y, x].FlatAppearance.BorderSize = 0;
                    
                }
            }
            //_view.GridOfButtons[0, 0].BackgroundImage = _rook;
            //_view.GridOfButtons[0, 0].BackgroundImageLayout = ImageLayout.Zoom;

            UpdateCurrentGrid();
            DetermineMoveType();
        }

        public void UpdateCurrentGrid() 
        {   
            int yGridValue = int.Parse(_game.TheCurrentTile[0].ToString());
            int xGridValue = int.Parse(_game.TheCurrentTile[4].ToString());
            _view.GridOfButtons[yGridValue, xGridValue].FlatAppearance.BorderSize = 2;
        }

        public void NoBorderExCurrentGrid()
        {
            int exYValue = int.Parse(_game.TheCurrentTile[0].ToString());
            int exXValue = int.Parse(_game.TheCurrentTile[4].ToString());
            _view.GridOfButtons[exYValue, exXValue].FlatAppearance.BorderSize = 0;
        }

        public void MovePiece(Direction direction, int steps) 
        {
            string beforeCurrentTile = _game.TheCurrentTile;
            NoBorderExCurrentGrid();
            _game.Move(direction, steps);
            UpdateCurrentGrid();
            string afterCurrentTile = _game.TheCurrentTile;
            ConsiderValidity(beforeCurrentTile, afterCurrentTile);
            GenerateMoveCount();
            DetermineMoveType();
            IsGameWon();
        }

        public void MoveKnight(int vertical, int horizontal)
        {
            string beforeCurrentTile = _game.TheCurrentTile;
            NoBorderExCurrentGrid();
            _game.MoveKnight(vertical, horizontal);
            UpdateCurrentGrid();
            string afterCurrentTile = _game.TheCurrentTile;
            ConsiderValidity(beforeCurrentTile, afterCurrentTile);
            GenerateMoveCount();
            DetermineMoveType();
            IsGameWon();
        }

        public void DetermineMoveType()
        {
            int currentYValue = int.Parse(_game.TheCurrentTile[0].ToString());
            int currentXValue = int.Parse(_game.TheCurrentTile[4].ToString());           
            if (_game.Board[currentYValue, currentXValue].GetType().ToString() == "GamePlayer.Knight")
            {
                _view.HidePieceMovement();
                _view.ShowKnightMovement();
            }
            else
            {
                _view.HideKnightMovement();
                _view.ShowPieceMovement();
            }
        }

        public void IsGameWon() 
        {
            if (_game.IsFinished())
            {
                _view.ShowWin();
                _view.HideKnightMovement();
                _view.HidePieceMovement();
            }
            else 
            {
                _view.HideWin();
            }
        }

        public void ConsiderValidity(string beforeValue, string afterValue)
        {
            if (beforeValue == afterValue)
            {
                _view.ShowInvalidMessage();
            }
            else 
            {
                _view.HideInvalidMessage();
            }
        }

        public void GenerateMoveCount() 
        {
            string moveString = _game.GetMoveCount().ToString();
            _view.UpdateMoveCount(moveString);
        }

        public void RestartGame() 
        {
            NoBorderExCurrentGrid();
            _game.Restart();
            UpdateCurrentGrid();
            _view.HideWin();
            GenerateMoveCount();
            DetermineMoveType();
        }

        public void GameUndoMove()
        {
            NoBorderExCurrentGrid();
            _game.Undo();
            UpdateCurrentGrid();
            _view.HideWin();
            GenerateMoveCount();
            DetermineMoveType();
        }
    }
}
