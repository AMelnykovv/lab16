using System;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab16
{
    public partial class PaintForm : Form
    {
        private QuadrilateralStar star;

        public PaintForm()
        {
            InitializeComponent();
        }


        private void btnDraw_Click_1(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);

            // Створення об'єкта зірки з введеними значеннями
            star = new QuadrilateralStar(a, b);

            // Оновлення форми, щоб запустити метод OnPaint і перерисувати зірку
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Перевірка, чи існує об'єкт зірки
            if (star != null)
            {
                // Малювання зірки на PictureBox
                star.Draw(e.Graphics); 
            }
        }

    }
}
