using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle15
{
    public partial class PuzzleArea : Form
    {
        public PuzzleArea()
        {
            InitializeComponent();
            InitializePuzzleArea();
            InitializeBlocks();
        }

        private void InitializePuzzleArea()
        {
            this.Text = "Puzzle15";
            this.ClientSize = new System.Drawing.Size(500, 500);
        }

        private void InitializeBlocks()
        {
            int blockCount = 1;
            PuzzleBlock block;
            for (int row = 0; row < 5; row++){
                for (int col = 0; col < 5; col++)
                {
                    block = new PuzzleBlock();
                    block.Top = row * 84;
                    block.Left = col * 84;
                    block.Text = blockCount.ToString();
                    blockCount++;
                    this.Controls.Add(block);
                }
            }
        }

    }
}
