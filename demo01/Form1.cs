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
    public partial class GameTestEye : Form
    {
        public static int second = 15;
        public static int score = 0;
        public static int error = 0;
        Random r = new Random();
        int r1, r2, r3, rx, ry,x,level=2;


        public GameTestEye()
        {
            InitializeComponent();
        }


        // TẠO MẢNG NÚT VÀ SET COLOR 
        private void addMultiButton(int n)
        {
            // set color
           x = r.Next(0, 100);
           r1 = r.Next(0, 150);
           r2 = r.Next(0, 150);
           r3 = r.Next(0, 150);
           
           rx = r.Next(0,n - 1);
           ry = r.Next(0,n - 1);

           int top=0;
           int t = 0;

            // set arraybutton
            for (int i = 0; i < n; i++) 
            {
                int left = 0;
                for (int j = 0; j < n; j++)
                {
                    Button button1 = new Button()
                    {
                        Height = (PanelButton.Height/n)-2,Width = (PanelButton.Width/n)-2
                    };

                    if(i==rx && j == ry)
                    {
                        button1.BackColor = System.Drawing.Color.FromArgb(r1+x, r2+x, r3+x);
                    }
                    else
                    button1.BackColor = System.Drawing.Color.FromArgb(r1, r2, r3);
                    button1.Left = left;
                    left += button1.Width;
                    t = button1.Height;
                    button1.Top = top;
                    PanelButton.Controls.Add(button1);
                    button1.Click += Button1_Click;    
                }
                top += t;
            }
        }


        //SET SỰ KIỆN CHO NÚT KHI ĐÚNG VÀ SAI
        private void Button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if(button.BackColor == System.Drawing.Color.FromArgb(r1 + x, r2 + x, r3 + x))
            {
                second = 15;
                TimerBox.Text = second.ToString();
                score++;
                ScoreBox.Text = score.ToString();
                level++;
                PanelButton.Controls.Clear();
                addMultiButton(level);
            }
            else
            {
                error++;
                ErrorBox.Text = error.ToString();
                second-=3;

            }
        }


        // SỰ KIỆN ĐẾM NGƯỢC THỜI GIAN
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            addMultiButton(2);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (second > 0)
            {
                second--;
                TimerBox.Text = second.ToString();
            }
            else
            {
                timer1.Stop();
                showResult(score);
            }
        }

     
        // SHOW KẾT QUẢ 

        private void showResult(int score)  //Cụ thể hàm hiển thị kết quá
        {
            MessageBox.Show (  "Mắt bạn tinh như " + GetAnimal(score), "Congratulations!", MessageBoxButtons.OK);
            Application.Exit();
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
  

