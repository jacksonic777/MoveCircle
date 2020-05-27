using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MoveCircle
{
    public partial class FormBallGame : Form
    {
        public FormBallGame()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormBallGame_Load(object sender, EventArgs e)
        {
            DrowCircleSelectPictureBox();
            DrowMainPictureBox();
        }
        /// <summary>
        /// 
        /// </summary>
        private void DrowCircleSelectPictureBox()
        {
            int height = selectPictureBox.Height;
            int width = selectPictureBox.Width;
            Bitmap selectCanvas = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(selectCanvas))
            {
                g.FillEllipse(Brushes.LightBlue, 0, 0, height, height);
                selectPictureBox.Image = selectCanvas;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void DrowMainPictureBox()
        {
            Bitmap canvas = new Bitmap(mainPictureBox.Width, mainPictureBox.Height);
            using(Graphics g = Graphics.FromImage(canvas))
            {
                g.DrawString("荻",
                            new Font("HG教科書体",
                            mainPictureBox.Height - mainPictureBox.Height / 4),
                            Brushes.Gray, 0, 0, new StringFormat());

                mainPictureBox.Image = canvas;
            }
        }

    }
}
