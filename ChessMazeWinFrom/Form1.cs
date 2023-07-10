using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessMazeWinFrom
{
    public partial class FormMain : Form
    {
        private GameController _controller;

        public FormMain()
        {
            InitializeComponent();
        }

        public void SetController(GameController controller)
        {
            _controller = controller;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSmallGame smallGameChild = new FormSmallGame();
            smallGameChild.MdiParent = this;
            smallGameChild.SetController();
            // SmallGameChild.ChangeWidth();
            smallGameChild.Show();
            //if (formSmallGame.ShowDialog() == DialogResult.Abort)
            //{ 

            //}
        }

        private void x4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGame2 gameChild2 = new FormGame2();
            gameChild2.MdiParent = this;
            gameChild2.SetController();
            gameChild2.Show();
        }

        private void x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGame3 gameChild3 = new FormGame3();
            gameChild3.MdiParent = this;
            gameChild3.SetController();
            gameChild3.Show();
        }
    }
}
