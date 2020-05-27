using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace MoveCircle
{
    class Ball
    {
        //公開
        public int pitch;       //移動の割合

        //非公開
        private PictureBox pictureBox;  // 描画するPictureBox
        private Bitmap canvas;          // 描画するcanvas
        private Brush brushColor;       // 塗りつぶす色

        private int positionX;          // 横位置(X座標)
        private int positionY;          // 縦位置(Y座標)

        private int previousX;          // 以前の横位置(X座標)
        private int previousY;          // 以前の縦位置(Y座標)

        private int directionX;         // 移動方向(X座標)(+1 or -1)
        private int directionY;         // 移動方向(Y座標)(+1 or -1)

        private int radius;             // 円の半径
        private string kanji;           // 表示する漢字
        private string fontName;        // 表示する漢字のフォント名
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pb"></param>
        /// <param name="cv"></param>
        /// <param name="cl"></param>
        /// <param name="st"></param>
        public Ball(PictureBox pb, Bitmap cv, Brush cl, string st)
        {
            pictureBox = pb;        // 描画するPictureBox
            canvas     = cv;        // 描画するキャンバス
            brushColor = cl;        // 塗りつぶす色
            kanji      = st;        // 表示する漢字
            radius     = 40;         // 円の半径の初期設定
            pitch      = radius / 2; //移動の割合の初期設定(半径の半分)
            
            directionX = +1;        // 移動方法を +1 で初期設定
            directionY = +1;        // 移動方法を +1 で初期設定
            fontName = "HG教科書体"; // 漢字のフォント名の初期設定
        }

        /// <summary>
        /// 指定した位置にボールを書く
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void PutCircle(int x, int y)
        {
            //現在の位置を記憶
            positionX = x;
            positionY = y;

            using(Graphics g = Graphics.FromImage(canvas))
            {
                // 円をbrushColorで指定された色で描く
                g.FillEllipse(brushColor, x, y, radius * 2, radius * 2);

                // 文字列を描画する
                g.DrawString(kanji, new Font(fontName, radius),
                    Brushes.Black, x + 4, y + 12, new StringFormat());



            }
        }
        /// <summary>
        /// 指定した位置のボールを消す(白で描く)
        /// </summary>
        public void DeleteCircle()
        {
            //初めて呼ばれて以前の値が無い時
            if(previousX == 0)
            {

            }
        }
    }
}
