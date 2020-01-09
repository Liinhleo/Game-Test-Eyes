using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo01
{
    public partial class FormKetQua : Form
    {
        public FormKetQua()
        {
            InitializeComponent();
        }

        private void FormKetQua_Load(object sender, EventArgs e)
        {

        }

        private string GetAnimal(int score)
        {
            if (score <= 4)
            {
                return "con dơi";
            }
            else if (score <= 9)
            {
                return "con chuột";
            }
            else if (score <= 14)
            {
                return "con chó";
            }
            else if (score <= 19)
            {
                return "con mèo";
            }
            else if (score <= 24)
            {
                return "con Hổ";
            }
            else return "con Chim Ưng";
        }
    }
}
