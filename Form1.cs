using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graf_Duku
{
    public partial class Form1 : Form
    {
        int cell;
        int radius;
        int rad_ell;
        bool edit_flag = false;
        Color col_butt;
        List<int[]> coords = new List<int[]>();



        public Form1()
        {
            InitializeComponent();

            cell = pictureBox1.Width / 10;
            radius = cell / 2;
            rad_ell = radius / 2;        

            for (int i = cell; i < pictureBox1.Width; i+=cell)
            {
                for (int j = cell; j < pictureBox1.Height; j+=cell)
                {
                    coords.Add(new int[] {j , i});
                }
            }

            col_butt = edit_button.BackColor;
            pointName_textbox.Enabled = false;
            change_background();

        }

        private void edit_button_Click(object sender, EventArgs e) //режим добавления
        {
            if (edit_flag)
            {
                groupBox1.Enabled = true;
                pointName_textbox.Enabled = false;
                pointName_textbox.Clear();
                edit_button.BackColor = col_butt;
                edit_button.Text = "Начать";
                edit_flag = false;

            }

            else
            {
                groupBox1.Enabled = false;
                pointName_textbox.Enabled = true;
                edit_button.BackColor = Color.FromArgb(169, 169, 169);
                
                edit_button.Text = "Закончить";
                edit_flag = true;
            }

        }

        Dictionary<string, int[]> dict = new Dictionary<string, int[]>(); //координаты точек
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) //создание точек
        {

            if (edit_flag)
            {
                for (int i = 0; i < coords.Count(); i++)
                {
                    if ((e.X <= coords[i][0]+radius && e.Y <= coords[i][1]+radius) && (e.X > coords[i][0]-radius && e.Y > coords[i][1]-radius))
                    {
                        if (pointName_textbox.Text.Length != 0 && dict.ContainsKey(pointName_textbox.Text) == false)
                        { 

                            dict.Add(pointName_textbox.Text, coords[i]);
                            coords.RemoveAt(i);

                            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                            Graphics g = Graphics.FromImage(bmp);

                            foreach (var key in dict.Keys)
                            {
                                g.FillEllipse(Brushes.Black, new Rectangle(dict[key][0] - rad_ell / 2, dict[key][1] - rad_ell / 2, rad_ell, rad_ell));
                            }
                            foreach (var key in lines.Keys)
                            {
                                g.DrawLine(new Pen(Color.Black), new Point(dict[lines[key][0]][0], dict[lines[key][0]][1]), new Point(dict[lines[key][1]][0], dict[lines[key][1]][1]));
                            }
                            pictureBox1.Image = bmp;
                            g.Dispose();

                            combo_delete.Items.Add(pointName_textbox.Text);
                            combo_delete.SelectedIndex = 0;

                            combo1.Items.Add(pointName_textbox.Text);
                            combo1.SelectedIndex = 0;

                            combo2.Items.Add(pointName_textbox.Text);
                            combo2.SelectedIndex = 0;

                            combo_search.Items.Add(pointName_textbox.Text);
                            combo_search.SelectedIndex = 0;

                            change_background();
                        }
                    }
                    
                }
            }
        }

        private void button_delete1_MouseDown(object sender, MouseEventArgs e) //удаление точек
        {

            if (combo_delete.Items.Count > 0)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);

                coords.Add(dict[Convert.ToString(combo_delete.SelectedItem)]);
                dict.Remove(Convert.ToString(combo_delete.SelectedItem));

                var for_del = new List<string>();
                foreach(var item in lines.Keys)
                {
                    foreach (var it in lines[item])
                    {
                        if (it == Convert.ToString(combo_delete.SelectedItem))
                        {
                            for_del.Add(item);
                        }
                    }
                }
                foreach (var item in for_del)
                {
                    lines.Remove(item);
                }
                

                foreach (var key in lines.Keys)
                {
                    g.DrawLine(new Pen(Color.Black), new Point(dict[lines[key][0]][0], dict[lines[key][0]][1]), new Point(dict[lines[key][1]][0], dict[lines[key][1]][1]));
                }

                foreach (var item in dict.Keys)
                {
                    g.FillEllipse(Brushes.Black, new Rectangle(dict[item][0] - rad_ell / 2, dict[item][1] - rad_ell / 2, rad_ell, rad_ell));
                }

                pictureBox1.Image = bmp;
                g.Dispose();

                combo1.Items.Remove(combo_delete.SelectedItem);
                if (combo1.Items.Count > 0) { combo1.SelectedIndex = 0; }

                combo2.Items.Remove(combo_delete.SelectedItem);
                if (combo2.Items.Count != 0) { combo2.SelectedIndex = 0; }

                combo_search.Items.Remove(combo_delete.SelectedItem);
                if (combo_search.Items.Count != 0) { combo_search.SelectedIndex = 0; }

                combo_delete.Items.Remove(combo_delete.SelectedItem);
                if (combo_delete.Items.Count != 0) { combo_delete.SelectedIndex = 0; }

                change_background();

            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) //идентификаторы
        {
            change_background();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //сетка
        {
            change_background();
        }

        private void draw_maze(Bitmap bmp) //отрисовка сетки
        {
            
            Graphics g = Graphics.FromImage(bmp);
            Pen p = new Pen(Color.FromArgb(192, 192, 192), 1);
            for (int i = 0; i < cell; i++)
            {
                g.DrawLine(p, new Point((cell * (i + 1)), 0), new Point((cell * (i + 1)), pictureBox1.Height));
                g.DrawLine(p, new Point(0, (cell * (i + 1))), new Point(pictureBox1.Width, (cell * (i + 1))));
            }
            g.Dispose();
        }
        private void draw_ident(Bitmap bmp) //отрисовка идентификаторов
        {
            Graphics g = Graphics.FromImage(bmp);
            foreach (var item in dict.Keys)
            {
                g.DrawString(item, new Font("Calibri", 15), Brushes.Black, dict[item][0] - radius, dict[item][1] - radius);
            }
            g.Dispose();
        }
        private void change_background() //смена фона
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {           
                draw_maze(bmp);
                draw_ident(bmp);               
                pictureBox1.BackgroundImage = bmp;
            }
            if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                draw_maze(bmp);
                pictureBox1.BackgroundImage = bmp;
            }
            if (checkBox1.Checked == false && checkBox2.Checked == true)
            {
                draw_ident(bmp);
                pictureBox1.BackgroundImage = bmp;
            }
            if (checkBox1.Checked == false && checkBox2.Checked == false)
            {
                pictureBox1.BackgroundImage = bmp;
            }
        }

        Dictionary<string, string[]> lines = new Dictionary<string, string[]>(); //массив путей

        private bool Intersection(int[] a1, int[] a2, int[] b1, int[] b2) //проверка пересечения
        {
            int ax1 = a1[0]; int ay1 = a1[1]; int ax2 = a2[0]; int ay2= a2[1]; int bx1= b1[0]; int by1= b1[1]; int bx2= b2[0]; int by2 = b2[1];
            var v1 = (bx2 - bx1) * (ay1 - by1) - (by2 - by1) * (ax1 - bx1);
            var v2 = (bx2 - bx1) * (ay2 - by1) - (by2 - by1) * (ax2 - bx1);
            var v3 = (ax2 - ax1) * (by1 - ay1) - (ay2 - ay1) * (bx1 - ax1);
            var v4 = (ax2 - ax1) * (by2 - ay1) - (ay2 - ay1) * (bx2 - ax1);

            if ((v1 * v2 <= 0) && (v3 * v4 <= 0)) 
            { 
                if (a1 == b1 || a1 == b2 || a2==b1 || a2 == b2)
                {
                    return false;
                }
                else { return true; }
            }
            else 
            { return false; }
        }

        private void button_add_Click(object sender, EventArgs e) //создание путей
        {
            if ((Convert.ToString(combo1.SelectedItem) != Convert.ToString(combo2.SelectedItem)) && lines.ContainsKey(Convert.ToString(combo1.SelectedItem) + Convert.ToString(combo2.SelectedItem)) == false && lines.ContainsKey(Convert.ToString(combo2.SelectedItem) + Convert.ToString(combo1.SelectedItem)) == false)
            {
                bool flag = false; 
                foreach (var item in lines.Keys) //проверка на пересечение
                {
                    if ((Intersection(dict[Convert.ToString(combo1.SelectedItem)] , dict[Convert.ToString(combo2.SelectedItem)], dict[lines[item][0]] , dict[lines[item][1]]))==true)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag==false)
                {
                    lines.Add(Convert.ToString(combo1.SelectedItem) + Convert.ToString(combo2.SelectedItem), new string[] { Convert.ToString(combo1.SelectedItem), Convert.ToString(combo2.SelectedItem) });

                    Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    Graphics g = Graphics.FromImage(bmp);

                    foreach (var key in dict.Keys)
                    {
                        g.FillEllipse(Brushes.Black, new Rectangle(dict[key][0] - rad_ell / 2, dict[key][1] - rad_ell / 2, rad_ell, rad_ell));
                    }
                    foreach (var key in lines.Keys)
                    {
                        g.DrawLine(new Pen(Color.Black), new Point(dict[lines[key][0]][0], dict[lines[key][0]][1]), new Point(dict[lines[key][1]][0], dict[lines[key][1]][1]));
                    }
                    pictureBox1.Image = bmp;
                    g.Dispose();
                }
            }
            
        }

        private void button_delete2_Click(object sender, EventArgs e)
        {
            if ((Convert.ToString(combo1.SelectedItem) != Convert.ToString(combo2.SelectedItem)) && lines.ContainsKey(Convert.ToString(combo1.SelectedItem) + Convert.ToString(combo2.SelectedItem)) == true)
            {
                lines.Remove(Convert.ToString(combo1.SelectedItem) + Convert.ToString(combo2.SelectedItem));

                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(bmp);

                foreach (var key in dict.Keys)
                {
                    g.FillEllipse(Brushes.Black, new Rectangle(dict[key][0] - rad_ell / 2, dict[key][1] - rad_ell / 2, rad_ell, rad_ell));
                }
                foreach (var key in lines.Keys)
                {
                    g.DrawLine(new Pen(Color.Black), new Point(dict[lines[key][0]][0], dict[lines[key][0]][1]), new Point(dict[lines[key][1]][0], dict[lines[key][1]][1]));
                }
                pictureBox1.Image = bmp;
                g.Dispose();
            }
        }






        //new Rectangle(cell-radius/2, cell - radius / 2, radius, radius)

        //bool flag_podsos = false;
        //private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (edit_flag)
        //    {
        //        foreach (int[] item in coords)
        //        {
        //            if ((e.X <= item[2] + radius && e.Y <= item[3] + radius) && (e.X >= item[0] - radius && e.Y >= item[1] - radius))
        //            {
        //                if (flag_podsos == false)
        //                {
        //                    Cursor.Position = pictureBox1.PointToScreen(new Point(item[0], item[1]));

        //                    flag_podsos = true;
        //                }
        //            }
        //            else
        //            {
        //                flag_podsos = false;
        //            }
        //        }
        //    }

        //}

    }
}
