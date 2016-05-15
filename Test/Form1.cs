using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaximaSharp;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace Test
{
    public partial class Form1 : Form
    {
        //Coordinates
        int wCartesian;
        int hCartesian;
        int centerX;
        int centerY;
        List<Point> pointsR;
        List<Point> pointsK;
        Point centerP;
        int cellSize = 10;

        double magnitud;
        double alfa;
        double compX;
        double compY;
        double SumX = 0;
        double SumY = 0;
        double Res = 0;
        private double alfaRes;
        private double compResX = 0;
        private double compResY = 0;

        //Counters
        int xs = 1;
        int ys = 1;
        private bool mode;

        //Graphics
        Graphics g;
        Bitmap bm;
        Pen pSmoke = new Pen(Color.WhiteSmoke);
        Pen pGainsboro = new Pen(Color.Gainsboro);
        Pen pWhite = new Pen(Color.White);
        Pen pGreen = new Pen(Color.FromArgb(72, 165, 112));
        Pen pRed = new Pen(Color.FromArgb(214, 55, 85));
        Brush bBlack = new SolidBrush(Color.Black);
        Brush bGainsboro = new SolidBrush(Color.FromArgb(51, 55, 66));
        private string modeH;
        private string modeV;
        private SaveFileDialog saveDialog;
        private bool solved;
        private string modeMain;

        public Form1()
        {
            InitializeComponent();
            #region
            this.Size = new Size(916, 534);
            this.StartPosition = FormStartPosition.CenterScreen;
            bm = new Bitmap(400, 400);
            g = pnlCartesian.CreateGraphics();
            wCartesian = pnlCartesian.Width;
            hCartesian = pnlCartesian.Height;
            centerP = new Point(wCartesian / 2, hCartesian / 2);
            centerX = wCartesian / 2;
            centerY = hCartesian / 2;
            RelocateUI();
            lblTitle.Text = "Resultant";
            modeMain = "Resultant";
            pGreen.Width = 2;
            pRed.Width = 2;
            txtMagnitud.Focus();
            pointsR = new List<Point>();
            pointsK = new List<Point>();
            modeH = "center";
            modeV = "center";
            DrawCartesian(centerP.X, centerP.Y);
            pnlEntries.Visible = true;
            pnlKinematic.Visible = false;

            //Expression<Func<double, double>> f2 = x => 3 * Math.Pow(x, 2) + 2 * x + Math.Pow(Math.Cos(x), 2) + Math.Pow(Math.Sin(x), 2);
            //Expression<Func<double, double>> f3 = x => 3 * Math.Pow(x, 2) + 2 * x + Math.Pow(Math.Cos(x), 2);
            //Expression<Func<double, double>> g2 = x => 2 * x + 20 * 2;
            //Expression<Func<double, double, double>> h2 = (y, z) => y + z;

            //var expr = Maxima.ToExpression("double, double", "x", "3 * x ^ 2 + 5 * x - 1");
            //MessageBox.Show(string.Format("{0}\n{1}", expr, expr.Differentiate()));
            #endregion

        }

        private void RelocateUI()
        {
            pnlEntries.Size = new Size(240, 400);
            pnlEntries.Location = new Point((pnlUIEntry.Width - 240) / 2, (pnlUIEntry.Height - 400) / 2);
            pnlKinematic.Size = new Size(240, 400);
            pnlKinematic.Location = new Point((pnlUIEntry.Width - 240) / 2, (pnlUIEntry.Height - 400) / 2);
            pnlCart.Location = new Point((pnlUICartesian.Width - 400) / 2, (pnlUICartesian.Height - 400) / 2);
        }

        private void pnlCartesian_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bm, Point.Empty);
            //DrawCartesian(centerP.X, centerP.Y);
        }

        private void DrawCartesian(int xaxis, int yaxis)
        {
            using (g = Graphics.FromImage(bm))
            {
                g.Clear(Color.White);
                //Grid
                for (int y = 0; y * cellSize < wCartesian + 2; y++)
                {
                    g.DrawLine(pSmoke, 0, y * cellSize, wCartesian, y * cellSize);
                }
                for (int x = 0; x * cellSize < hCartesian - 2; x++)
                {
                    g.DrawLine(pSmoke, x * cellSize, 0, x * cellSize, hCartesian);
                }
                //Axis
                centerP = new Point(xaxis, yaxis);
                g.DrawLine(pGainsboro, 0, centerP.Y, wCartesian, centerP.Y); //X
                g.DrawLine(pGainsboro, centerP.X, 0, centerP.X, hCartesian);//Y
                Rectangle rect = new Rectangle(new Point(centerP.X - 2, centerP.Y - 2), new Size(4, 4));
                g.FillRectangle(bBlack, rect);
                ////Origin
                //g.DrawString("0", new Font("Lato", 6f), bGainsboro, centerP.X + 4, centerP.Y);
                g.Dispose();
            }
            //pnlCartesian.Invalidate();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            RelocateUI();
        }

        private void btnNav_Click(object sender, EventArgs e)
        {
        }

        private void ColorButtons(Control control, Button btn)
        {
            foreach (var c in control.Controls)
            {
                if (c is Button) ((Button)c).BackColor = Color.FromArgb(51, 55, 66);
            }
            btn.BackColor = Color.FromArgb(41, 44, 53);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (!mode)
            {
                #region
                try
                {
                    magnitud = double.Parse(txtMagnitud.Text);
                    alfa = double.Parse(txtAlfa.Text);
                    compX = magnitud * (Math.Cos((Math.PI / 180) * (alfa)));
                    compY = magnitud * (Math.Sin((Math.PI / 180) * (alfa)));

                    //Draw Magnitude
                    Point pointA = new Point(centerP.X + (int)compX, centerP.Y - (int)compY);
                    pointsR.Add(pointA);
                    RedrawScene(centerP, pointsR);

                    //Sumatory
                    SumX = SumX + compX;
                    SumY = SumY + compY;
                    Res = Math.Sqrt(Math.Pow(SumX, 2) + Math.Pow(SumY, 2));

                    if (SumX != 0 && SumY != 0)
                    {
                        alfaRes = (Math.Atan(SumY / SumX) / (Math.PI / 180));
                    }

                    //Print results
                    PrintText();
                }
                catch (Exception)
                {
                    //MessageBox.Show(exep.ToString());
                }
                #endregion
            }
            else
            {
                #region
                try
                {
                    magnitud = double.Parse(txtMagnitud.Text);
                    compX = double.Parse(txtX.Text);
                    compY = double.Parse(txtY.Text);
                    alfa = (Math.Atan(compX / compY) / (Math.PI / 180));

                    //Draw Magnitude
                    Point pointA = new Point(centerP.X + (int)compX, centerP.Y - (int)compY);
                    pointsR.Add(pointA);
                    RedrawScene(centerP, pointsR);

                    //Sumatory
                    SumX = SumX + compX;
                    SumY = SumY + compY;
                    Res = Math.Sqrt(Math.Pow(SumX, 2) + Math.Pow(SumY, 2));

                    if (SumX != 0 && SumY != 0)
                    {
                        alfaRes = (Math.Atan(SumY / SumX) / (Math.PI / 180));
                    }

                    //Print results
                    PrintText();

                }
                catch (Exception exep)
                {
                    //MessageBox.Show("Asegurate de estar en el modo correcto.", "Error!");
                    MessageBox.Show(exep.Message.ToString());
                }
                #endregion
            }
        }

        private void PrintText()
        {
            if (!mode)
            {
                txtRes.Text = string.Format("{0}", Math.Round(Res, 4));
                txtAngulo.Text = string.Format("{0}", Math.Round(alfaRes, 4));
                txtX.Text = string.Format("{0}", Math.Round(compX, 4));
                txtY.Text = string.Format("{0}", Math.Round(compY, 4));
                txtSumX.Text = string.Format("{0}", Math.Round(SumX, 4));
                txtSumY.Text = string.Format("{0}", Math.Round(SumY, 4));

                if (xs < 8)
                {
                    lblResult2.Text = lblResult2.Text + string.Format("• X{0}: {1:000}  Y{2}: {3:000}\n", xs, Math.Round(compX, 2), ys, Math.Round(compY, 2));
                    lblResult.Text = lblResult.Text + string.Format("• F{0}: {1:000}N  A{2}: {3}°\n", xs, int.Parse(txtMagnitud.Text), ys, int.Parse(txtAlfa.Text));
                }
                xs++;
                ys++;

                txtAlfa.Clear();
                txtMagnitud.Clear();
                txtMagnitud.Focus();
            }
            else
            {
                txtAlfa.Text = string.Format("{0}", Math.Round(alfa, 4));
                txtRes.Text = string.Format("{0}", Math.Round(Res, 4));
                txtAngulo.Text = string.Format("{0}", Math.Round(alfaRes, 4));
                //txtX.Text = string.Format("{0}", Math.Round(compX, 4));
                //txtY.Text = string.Format("{0}", Math.Round(compY, 4));
                txtSumX.Text = string.Format("{0}", Math.Round(SumX, 4));
                txtSumY.Text = string.Format("{0}", Math.Round(SumY, 4));

                if (xs < 8)
                {
                    lblResult2.Text = lblResult2.Text + string.Format("• X{0}: {1:000}  Y{2}: {3:000}\n", xs, Math.Round(compX, 2), ys, Math.Round(compY, 2));
                    lblResult.Text = lblResult.Text + string.Format("• F{0:00}: {1:000}N  A{2}: {3}°\n", xs, int.Parse(txtMagnitud.Text), ys, Math.Round(alfa, 0));
                }
                xs++;
                ys++;

                txtX.Clear();
                txtY.Clear();
                txtMagnitud.Clear();
                txtMagnitud.Focus();
            }
        }

        private void RedrawScene(Point centerP, List<Point> points)
        {
            int f = 1;
            DrawCartesian(centerP.X, centerP.Y);
            using (g = Graphics.FromImage(bm))
            {
                foreach (Point pt in points)
                {
                    g.DrawLine(pGreen, centerP, pt);
                    Rectangle rectPoint = new Rectangle(new Point(pt.X - 2, pt.Y - 2), new Size(4, 4));
                    g.FillRectangle(bBlack, rectPoint);
                    //Display pionts
                    int px = pt.X - centerP.X;
                    int py = pt.Y - centerP.Y;
                    if (px > 0)
                    {
                        g.DrawString(string.Format("F{2}({0:00}, {1:00})", px, py * -1, f), new Font("Lato", 6f), bGainsboro, pt.X + 4, pt.Y);
                    }
                    else
                    {
                        g.DrawString(string.Format("F{2}({0:00}, {1:00})", px, py * -1, f), new Font("Lato", 6f), bGainsboro, pt.X - 50, pt.Y + 2);
                    }

                    f++;
                }
                //Center
                Rectangle rect2 = new Rectangle(new Point(centerP.X - 2, centerP.Y - 2), new Size(4, 4));
                g.FillRectangle(bBlack, rect2);
                g.Dispose();
            }
            pnlCartesian.Invalidate();

        }

        private void RedrawPoints(Point centerP, List<Point> points)
        {
            DrawCartesian(centerP.X, centerP.Y);
            using (g = Graphics.FromImage(bm))
            {
                Point lastpt = new Point() ;
                if (points.Count() != 0)
                {
                    lastpt = points[0];
                }
                try
                {
                    foreach (Point pt in points)
                    {
                        g.DrawLine(pGreen, lastpt, pt);
                        lastpt = pt;
                        //Display pionts
                        int px = pt.X - centerP.X;
                        int py = pt.Y - centerP.Y;
                        g.DrawString(string.Format("({0:00}, {1:00})", px / 10, py * -1), new Font("Lato", 6f), bGainsboro, pt.X + 4, pt.Y);

                    }

                    foreach (Point pt in points)
                    {
                        Rectangle rectPoint = new Rectangle(new Point(pt.X - 2, pt.Y - 2), new Size(4, 4));
                        g.FillRectangle(bGainsboro, rectPoint);
                    }
                }
                catch(Exception)
                {

                }

                //Center
                Rectangle rect2 = new Rectangle(new Point(centerP.X - 2, centerP.Y - 2), new Size(4, 4));
                g.FillRectangle(bGainsboro, rect2);
                g.Dispose();
            }
            pnlCartesian.Invalidate();

        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            if (lblResult.Text.Length > 1)
            {
                SolveRes();
                btnRes.Enabled = false;
                btnDraw.Enabled = false;
                solved = true;
                btnNew.Focus();
            }
            else
            {
                MyNewMessageBox m = new MyNewMessageBox("OK", "Add forces!");
                m.ShowDialog();
            }
        }

        private void SolveRes()
        {
            #region
            using (g = Graphics.FromImage(bm))
            {

                    compResX = Res * (Math.Cos(((Math.PI) / 180) * (alfaRes)));
                    compResY = Res * (Math.Sin(((Math.PI) / 180) * (alfaRes)));
                if (SumX >= 0)
                {
                    if (SumY > 0)
                    {
                        Point pointA = new Point(centerP.X + (int)compResX, centerP.Y - (int)compResY);
                        g.DrawLine(pRed, centerP, new Point(centerP.X + (int)compResX, centerP.Y - (int)compResY));
                        Rectangle rect = new Rectangle(new Point((centerP.X + (int)compResX) - 2, (centerP.Y - (int)compResY) - 2), new Size(4, 4));
                        g.FillRectangle(bBlack, rect);
                        g.DrawString(string.Format("R({0:00}, {1:00})", compResX, compResY), new Font("Lato", 6f), bGainsboro, centerP.X + (int)compResX + 4, centerP.Y - (int)compResY);
                        //Bitmap myBitmap = new Bitmap(400, 400, g);
                        //pnlCartesian.BackgroundImage = myBitmap;
                    }
                    else
                    {
                        g.DrawLine(pRed, centerP, new Point(centerP.X + (int)compResX, centerP.Y - (int)compResY));
                        Point pointA = new Point(centerP.X + (int)compResX, centerP.Y - (int)compResY);
                        Rectangle rect = new Rectangle(new Point((centerP.X + (int)compResX) - 2, (centerP.Y - (int)compResY) - 2), new Size(4, 4));
                        g.FillRectangle(bBlack, rect);
                        g.DrawString(string.Format("R({0:00}, {1:00})", compResX, compResY), new Font("Lato", 6f), bGainsboro, centerP.X + (int)compResX + 4, centerP.Y - (int)compResY);
                    }
                }
                else
                {
                    if (SumY > 0)
                    {
                        txtAngulo.Text = string.Format("{0}", (int)alfaRes + 180);
                        g.DrawLine(pRed, centerP, new Point(centerP.X - (int)compResX, centerP.Y + (int)compResY));
                        Rectangle rect = new Rectangle(new Point((centerP.X - (int)compResX) - 2, (centerP.Y + (int)compResY) - 2), new Size(4, 4));
                        g.FillRectangle(bBlack, rect);
                        g.DrawString(string.Format("R({0:00}, {1:00})", compResX * -1, compResY * -1), new Font("Lato", 6f), bGainsboro, centerP.X - (int)compResX - 40, centerP.Y + (int)compResY + 2);
                    }
                    else
                    {
                        txtAngulo.Text = string.Format("{0}", (int)alfaRes + 180);
                        g.DrawLine(pRed, centerP, new Point(centerP.X - (int)compResX, centerP.Y + (int)compResY));
                        Rectangle rect = new Rectangle(new Point((centerP.X - (int)compResX) - 2, (centerP.Y + (int)compResY) - 2), new Size(4, 4));
                        g.FillRectangle(bBlack, rect);
                        g.DrawString(string.Format("R({0:00}, {1:00})", compResX * -1, compResY * -1), new Font("Lato", 6f), bGainsboro, centerP.X - (int)compResX + 4, centerP.Y + (int)compResY);
                    }
                }
                g.Dispose();
            }
            pnlCartesian.Invalidate();
            #endregion
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MyNewMessageBox m = new MyNewMessageBox("Yes", "No", "Save?");
            DialogResult result = m.ShowDialog();
            if (result == DialogResult.OK)
            {
                Rectangle bounds = this.Bounds;
                Bitmap bmap = new Bitmap(bounds.Width, bounds.Height);
                using (Graphics g2 = Graphics.FromImage(bmap))
                {
                    g2.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }

                saveDialog = new SaveFileDialog();
                saveDialog.FileName = lblTitle.Text;
                saveDialog.DefaultExt = ".png";
                saveDialog.Filter = "PNG images (*.png)|*.png";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileName = saveDialog.FileName;
                    if (!System.IO.Path.HasExtension(fileName) || System.IO.Path.GetExtension(fileName) != ".png")
                    {
                        fileName = fileName + ".png";
                    }
                    bmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
            else
            {
            }

            ClearPanelEntries();
        }

        private void ClearPanelEntries()
        {

            ClearText(tlpEntry);
            lblResult.Text = "";
            lblResult2.Text = "";
            //txtAlfa.Clear();
            //txtMagnitud.Clear();
            //txtX.Clear();
            //txtY.Clear();
            //txtSumX.Clear();
            //txtSumY.Clear();
            //txtRes.Clear();
            //txtAngulo.Clear();
            using (g = Graphics.FromImage(bm))
            {
                g.Clear(Color.White);
            }
            pnlCartesian.Refresh();
            DrawCartesian(centerP.X, centerP.Y);
            pnlCartesian.Invalidate();

            magnitud = 0;
            alfa = 0;
            compX = 0;
            compY = 0;
            SumX = 0;
            SumY = 0;
            Res = 0;
            xs = 1;
            ys = 1;
            alfaRes = 0;
            pointsR.Clear();
            pointsR = new List<Point>();
            btnDraw.Enabled = true;
            btnRes.Enabled = true;
            solved = false;

            txtMagnitud.Focus();

        }

        private void ClearPanelKinetic()
        {
            using (g = Graphics.FromImage(bm))
            {
                g.Clear(Color.White);
            }
            pnlCartesian.Refresh();
            DrawCartesian(centerP.X, centerP.Y);
            pnlCartesian.Invalidate();
            
            pointsK.Clear();
            pointsK = new List<Point>();

        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            if (!mode)
            {
                btnMode.Text = "X | Y";
                txtAlfa.ReadOnly = true;
                txtX.ReadOnly = false;
                txtY.ReadOnly = false;
                mode = true;
            }
            else
            {
                btnMode.Text = "F | A";
                txtAlfa.ReadOnly = false;
                txtX.ReadOnly = true;
                txtY.ReadOnly = true;
                mode = false;
            }
        }

        private void btnResultant_Click(object sender, EventArgs e)
        {
            tlpSelected.Controls.Add(pnlSelect, 0, 0);
            ColorButtons(tlpNav, btnResultant);
            lblTitle.Text = "Resultant";
            modeMain = "Resultant";
            ShowPanel(pnlEntries);
            txtMagnitud.Focus();

            RedrawScene(centerP, pointsR);
            if(solved)
            {
                SolveRes();
            }
        }

        private void btnEquilib_Click(object sender, EventArgs e)
        {
            tlpSelected.Controls.Add(pnlSelect, 0, 1);
            ColorButtons(tlpNav, btnEquilib);
            lblTitle.Text = "Equilibrant";
        }

        private void btnKinematic_Click(object sender, EventArgs e)
        {
            tlpSelected.Controls.Add(pnlSelect, 0, 2);
            ColorButtons(tlpNav, btnKinematic);
            lblTitle.Text = "Kinematic";
            modeMain = "Kinematic";
            ShowPanel(pnlKinematic);
            txtEQ.Focus();

            RedrawPoints(centerP, pointsK);
        }

        private void ShowPanel(Panel pnl)
        {

            pnlEntries.Visible = false;
            pnlKinematic.Visible = false;

            pnl.Visible = true;
        }

        private void btnCartCenter_Click(object sender, EventArgs e)
        {
            if (modeH != "center" || modeV != "center")
            {
                centerP = new Point(wCartesian / 2, wCartesian / 2);

                #region
                if (modeH == "left" && modeV == "center")
                {
                    modeH = "center";
                    modeV = "center";
                    for (int i = 0; i < pointsR.Count(); i++)
                    {
                        pointsR[i] = new Point(pointsR[i].X + 200, pointsR[i].Y);
                    }
                    for (int i = 0; i < pointsK.Count(); i++)
                    {
                        pointsK[i] = new Point(pointsK[i].X + 200, pointsK[i].Y);
                    }
                }
                if (modeH == "left" && modeV == "up")
                {
                    modeH = "center";
                    modeV = "center";
                    for (int i = 0; i < pointsR.Count(); i++)
                    {
                        pointsR[i] = new Point(pointsR[i].X + 200, pointsR[i].Y + 200);
                    }
                    for (int i = 0; i < pointsK.Count(); i++)
                    {
                        pointsK[i] = new Point(pointsK[i].X + 200, pointsK[i].Y + 200);
                    }
                }
                if (modeH == "left" && modeV == "down")
                {
                    modeH = "center";
                    modeV = "center";
                    for (int i = 0; i < pointsR.Count(); i++)
                    {
                        pointsR[i] = new Point(pointsR[i].X + 200, pointsR[i].Y - 200);
                    }
                    for (int i = 0; i < pointsK.Count(); i++)
                    {
                        pointsK[i] = new Point(pointsK[i].X + 200, pointsK[i].Y - 200);
                    }
                }
                if (modeH == "center" && modeV == "up")
                {
                    modeH = "center";
                    modeV = "center";
                    for (int i = 0; i < pointsR.Count(); i++)
                    {
                        pointsR[i] = new Point(pointsR[i].X, pointsR[i].Y + 200);
                    }
                    for (int i = 0; i < pointsK.Count(); i++)
                    {
                        pointsK[i] = new Point(pointsK[i].X, pointsK[i].Y + 200);
                    }
                }
                if (modeH == "center" && modeV == "down")
                {
                    modeH = "center";
                    modeV = "center";
                    for (int i = 0; i < pointsK.Count(); i++)
                    {
                        pointsK[i] = new Point(pointsK[i].X, pointsK[i].Y - 200);
                    }
                    for (int i = 0; i < pointsR.Count(); i++)
                    {
                        pointsR[i] = new Point(pointsR[i].X, pointsR[i].Y - 200);
                    }
                }
                if (modeH == "right" && modeV == "center")
                {
                    modeH = "center";
                    modeV = "center";
                    for (int i = 0; i < pointsK.Count(); i++)
                    {
                        pointsK[i] = new Point(pointsK[i].X - 200, pointsK[i].Y);
                    }
                    for (int i = 0; i < pointsR.Count(); i++)
                    {
                        pointsR[i] = new Point(pointsR[i].X - 200, pointsR[i].Y);
                    }
                }
                if (modeH == "right" && modeV == "up")
                {
                    modeH = "center";
                    modeV = "center";
                    for (int i = 0; i < pointsK.Count(); i++)
                    {
                        pointsK[i] = new Point(pointsK[i].X - 200, pointsK[i].Y + 200);
                    }
                    for (int i = 0; i < pointsR.Count(); i++)
                    {
                        pointsR[i] = new Point(pointsR[i].X - 200, pointsR[i].Y + 200);
                    }
                }
                if (modeH == "right" && modeV == "down")
                {
                    modeH = "center";
                    modeV = "center";
                    for (int i = 0; i < pointsR.Count(); i++)
                    {
                        pointsR[i] = new Point(pointsR[i].X - 200, pointsR[i].Y - 200);
                    }
                    for (int i = 0; i < pointsK.Count(); i++)
                    {
                        pointsK[i] = new Point(pointsK[i].X - 200, pointsK[i].Y - 200);
                    }
                }
                #endregion

                if (modeMain == "Kinematic")
                {
                    RedrawPoints(centerP, pointsK);
                }
                else if (modeMain == "Resultant")
                {
                    RedrawScene(centerP, pointsR);
                    if (solved)
                    {
                        try
                        {
                            SolveRes();
                        }
                        catch (Exception) { }
                    }
                }
            }
        }

        private void btnCartLeft_Click(object sender, EventArgs e)
        {
            if (modeH != "left")
            {
                centerP = new Point(0, centerP.Y);

                #region
                if (modeH == "center")
                {
                    modeH = "left";
                    for (int i = 0; i < pointsR.Count(); i++)
                    {
                        pointsR[i] = new Point(pointsR[i].X - 200, pointsR[i].Y);
                    }
                    for (int i = 0; i < pointsK.Count(); i++)
                    {
                        pointsK[i] = new Point(pointsK[i].X - 200, pointsK[i].Y);
                    }
                }
                if (modeH == "right")
                {
                    modeH = "left";
                    for (int i = 0; i < pointsR.Count(); i++)
                    {
                        pointsR[i] = new Point(pointsR[i].X - 400, pointsR[i].Y);
                    }
                    for (int i = 0; i < pointsK.Count(); i++)
                    {
                        pointsK[i] = new Point(pointsR[i].X - 400, pointsK[i].Y);
                    }
                }
                #endregion

                if (modeMain == "Kinematic")
                {
                    RedrawPoints(centerP, pointsK);
                }
                else if(modeMain == "Resultant")
                {
                    RedrawScene(centerP, pointsR);
                    if (solved)
                    {
                        try
                        {
                            SolveRes();
                        }
                        catch (Exception) { }
                    }
                }
            }
        }

        private void btnCartUp_Click(object sender, EventArgs e)
        {
            if (modeV != "up")
            {
                centerP = new Point(centerP.X, 0);

                #region
                if (modeV == "down")
                {
                    modeV = "up";
                    for (int i = 0; i < pointsR.Count(); i++)
                    {
                        pointsR[i] = new Point(pointsR[i].X, pointsR[i].Y - 400);
                    }
                    for (int i = 0; i < pointsK.Count(); i++)
                    {
                        pointsK[i] = new Point(pointsK[i].X, pointsK[i].Y - 400);
                    }
                }
                else if (modeV == "center")
                {
                    modeV = "up";
                    for (int i = 0; i < pointsK.Count(); i++)
                    {
                        pointsK[i] = new Point(pointsK[i].X, pointsK[i].Y - 200);
                    }
                    for (int i = 0; i < pointsR.Count(); i++)
                    {
                        pointsR[i] = new Point(pointsR[i].X, pointsR[i].Y - 200);
                    }
                }
                #endregion

                if (modeMain == "Kinematic")
                {
                    RedrawPoints(centerP, pointsK);
                }
                else if (modeMain == "Resultant")
                {
                    RedrawScene(centerP, pointsR);
                    if (solved)
                    {
                        try
                        {
                            SolveRes();
                        }
                        catch (Exception) { }
                    }
                }
            }
        }

        private void btnCartDown_Click(object sender, EventArgs e)
        {
            if (modeV != "down")
            {
                centerP = new Point(centerP.X, 400);
                #region
                if (modeV == "up")
                {
                    modeV = "down";
                    for (int i = 0; i < pointsK.Count(); i++)
                    {
                        pointsK[i] = new Point(pointsK[i].X, pointsK[i].Y + 400);
                    }
                    for (int i = 0; i < pointsR.Count(); i++)
                    {
                        pointsR[i] = new Point(pointsR[i].X, pointsR[i].Y + 400);
                    }
                }
                else if (modeV == "center")
                {
                    modeV = "down";
                    for (int i = 0; i < pointsK.Count(); i++)
                    {
                        pointsK[i] = new Point(pointsK[i].X, pointsK[i].Y + 200);
                    }
                    for (int i = 0; i < pointsR.Count(); i++)
                    {
                        pointsR[i] = new Point(pointsR[i].X, pointsR[i].Y + 200);
                    }
                }
                #endregion

                if (modeMain == "Kinematic")
                {
                    RedrawPoints(centerP, pointsK);
                }
                else if (modeMain == "Resultant")
                {
                    RedrawScene(centerP, pointsR);
                    if (solved)
                    {
                        try
                        {
                            SolveRes();
                        }
                        catch (Exception) { }
                    }
                }
            }
        }

        private void btnCartH_Click(object sender, EventArgs e)
        {
            if (modeH != "center")
            {
                centerP = new Point(200, centerP.Y);

                #region
                if (modeH == "right")
                {
                    modeH = "center";
                    for (int i = 0; i < pointsR.Count(); i++)
                    {
                        pointsR[i] = new Point(pointsR[i].X - 200, pointsR[i].Y);
                    }
                    for (int i = 0; i < pointsK.Count(); i++)
                    {
                        pointsK[i] = new Point(pointsK[i].X - 200, pointsK[i].Y);
                    }
                }
                if (modeH == "left")
                {
                    modeH = "center";
                    for (int i = 0; i < pointsR.Count(); i++)
                    {
                        pointsR[i] = new Point(pointsR[i].X + 200, pointsR[i].Y);
                    }
                    for (int i = 0; i < pointsK.Count(); i++)
                    {
                        pointsK[i] = new Point(pointsK[i].X + 200, pointsK[i].Y);
                    }
                }
                #endregion

                if (modeMain == "Kinematic")
                {
                    RedrawPoints(centerP, pointsK);
                }
                else if (modeMain == "Resultant")
                {
                    RedrawScene(centerP, pointsR);
                    if (solved)
                    {
                        try
                        {
                            SolveRes();
                        }
                        catch (Exception) { }
                    }
                }
            }
        }

        private void btnCartRight_Click(object sender, EventArgs e)
        {
            if (modeH != "right")
            {
                centerP = new Point(400, centerP.Y);

                #region
                if (modeH == "center")
                {
                    modeH = "right";
                    for (int i = 0; i < pointsK.Count(); i++)
                    {
                        pointsK[i] = new Point(pointsK[i].X + 200, pointsK[i].Y);
                    }
                    for (int i = 0; i < pointsR.Count(); i++)
                    {
                        pointsR[i] = new Point(pointsR[i].X + 200, pointsR[i].Y);
                    }
                }
                if (modeH == "left")
                {
                    modeH = "right";
                    for (int i = 0; i < pointsR.Count(); i++)
                    {
                        pointsR[i] = new Point(pointsR[i].X + 400, pointsR[i].Y);
                    }
                    for (int i = 0; i < pointsK.Count(); i++)
                    {
                        pointsK[i] = new Point(pointsK[i].X + 400, pointsK[i].Y);
                    }
                }
                #endregion

                if (modeMain == "Kinematic")
                {
                    RedrawPoints(centerP, pointsK);
                }
                else if (modeMain == "Resultant")
                {
                    RedrawScene(centerP, pointsR);
                    if (solved)
                    {
                        try
                        {
                            SolveRes();
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
            }
        }

        private void btnCartV_Click(object sender, EventArgs e)
        {
            if (modeV != "center")
            {
                centerP = new Point(centerP.X, 200);

                #region
                if (modeV == "up")
                {
                    modeV = "center";
                    for (int i = 0; i < pointsR.Count(); i++)
                    {
                        pointsR[i] = new Point(pointsR[i].X, pointsR[i].Y + 200);
                    }
                    for (int i = 0; i < pointsK.Count(); i++)
                    {
                        pointsK[i] = new Point(pointsK[i].X, pointsK[i].Y + 200);
                    }
                }
                if (modeV == "down")
                {
                    modeV = "center";
                    for (int i = 0; i < pointsK.Count(); i++)
                    {
                        pointsK[i] = new Point(pointsK[i].X, pointsK[i].Y - 200);
                    }
                    for (int i = 0; i < pointsR.Count(); i++)
                    {
                        pointsR[i] = new Point(pointsR[i].X, pointsR[i].Y - 200);
                    }
                }
                #endregion


                if (modeMain == "Kinematic")
                {
                    RedrawPoints(centerP, pointsK);
                }
                else if (modeMain == "Resultant")
                {
                    RedrawScene(centerP, pointsR);
                    if (solved)
                    {
                        try
                        {
                            SolveRes();
                        }
                        catch (Exception) { }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //string filesName = System.IO.Path.GetTempPath() + DateTime.Now.ToString() + ".png";
            Rectangle bounds = this.Bounds;
            Bitmap bmap = new Bitmap(bounds.Width, bounds.Height);
            using (Graphics g2 = Graphics.FromImage(bmap))
            {
                g2.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
            }

            #region
            /*
            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics graphics = Graphics.FromImage(bitmap as Image);
            graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
            */
            #endregion

            saveDialog = new SaveFileDialog();
            saveDialog.FileName = lblTitle.Text;
            saveDialog.DefaultExt = ".png";
            saveDialog.Filter = "PNG images (*.png)|*.png";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = saveDialog.FileName;
                var fileName2 = saveDialog.FileName;
                if (!System.IO.Path.HasExtension(fileName) || System.IO.Path.GetExtension(fileName) != ".png")
                {
                    fileName = fileName + ".png";
                    fileName2 = fileName2 + ".png";
                }
                //bm.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                bmap.Save(fileName2, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MyNewMessageBox m = new MyNewMessageBox("Yes", "No", "Exit?");
            DialogResult result = m.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Application.Exit();
                this.Close();
            }
            else
            {
                txtMagnitud.Focus();
            }
        }

        private void btnSolveEQ_Click(object sender, EventArgs e)
        {
            ClearText2(tlpKinematic);
            try
            {
                string textt = txtEQ.Text;

                //3 * x ^ 2 + 5 * x - 1

                //
                var exprEQ = Maxima.ToExpression("double, double", "x", textt);

                var exprInitialPos = exprEQ.At(0).ToString();

                var exprVel = exprEQ.Differentiate().ToString();
                var exprVelinit = exprEQ.Differentiate().At(0).ToString();

                var exprAcel = exprEQ.Differentiate().Differentiate().ToString();
                var exprAcelinit = exprEQ.Differentiate().Differentiate().At(0).ToString();
                
                txtVelocity.Text = exprVel.Substring(5) + " m/s";
                txtAcceleration.Text = exprAcel.Substring(5) + " m/s²";

                lblResKin0.Text = "d(0) =  " + exprInitialPos + " m" +
                    "\nv(0) =   " + exprVelinit + " m/s" +
                    "\na(0) = " + exprAcelinit + " m/s²";
                lblResKin0.SelectAll();
                lblResKin0.SelectionAlignment = HorizontalAlignment.Center;

                try
                {
                    //3*x^2+2*x+3
                    double seconds = double.Parse(txtSeconds.Text);
                    double seconds2 = double.Parse(txtSeconds2.Text);
                    var exprVelins = exprEQ.Differentiate().At(seconds).ToString();
                    var exprAcelins = exprEQ.Differentiate().Differentiate().At(seconds).ToString();
                    var exprVelins2 = exprEQ.Differentiate().At(seconds2).ToString();
                    var exprAcelins2 = exprEQ.Differentiate().Differentiate().At(seconds2).ToString();
                    var distance = exprEQ.At(seconds);
                    var distance2 = exprEQ.At(seconds2);

                    double dist = double.Parse(distance.ToString());
                    double dist2 = double.Parse(distance2.ToString());
                    double velins = double.Parse(exprVelins.ToString());
                    double velin2 = double.Parse(exprVelins2.ToString());

                    double exprVelaverage = ((dist2 - dist) / (seconds2 - seconds));
                    double exprAcelaverage = ((velin2 - velins) / (seconds2 - seconds));

                    lblResKin0.Text = lblResKin0.Text +
                        "\rv̄= " + exprVelaverage.ToString() + " m/s" +
                        "\rā = " + exprAcelaverage.ToString() + " m/s²";
                    lblResKin0.SelectAll();
                    lblResKin0.SelectionAlignment = HorizontalAlignment.Center;

                    //lblResKin3.Clear();
                    //lblResKin3.AppendLine("\r");
                    //lblResKin3.AppendLine("\rv̄ = " + exprVelaverage.ToString() + " m / s");
                    //lblResKin3.AppendLine("\rā = " + exprAcelaverage.ToString() + " m/s²");

                    lblResKin.Text = "    v(" + seconds.ToString() + ") =  " + exprVelins + " m/s" +
                        "\n    a(" + seconds.ToString() + ") =  " + exprAcelins + " m/s²" +
                        "\n    d(" + seconds.ToString() + ") =  " + distance + " m";
                    lblResKin.SelectAll();
                    lblResKin.SelectionAlignment = HorizontalAlignment.Left;

                    lblResKin2.Text = "    v(" + seconds2.ToString() + ") =  " + exprVelins2 + " m/s" +
                        "\n    a(" + seconds2.ToString() + ") =  " + exprAcelins2 + " m/s²" +
                        "\n    d(" + seconds2.ToString() + ") =  " + distance2 + " m";
                }
                catch(Exception)
                {

                    lblResKin0.Text = "\nd(0) =  " + exprInitialPos + " m" +
                        "\nv(0) =   " + exprVelinit + " m/s" +
                        "\na(0) = " + exprAcelinit + " m/s²";
                    lblResKin0.SelectAll();
                    lblResKin0.SelectionAlignment = HorizontalAlignment.Center;
                    txtSeconds.Focus();
                }

                pointsK.Clear();
                for(int i = 0; i <= 40; i++)
                {
                    double num = double.Parse(exprEQ.At(i).ToString());
                    //int num2 = Convert.ToInt32(num.Substring(0, num.IndexOf('.') > 0 ? num.IndexOf('.') + 1 : num.Length)) * 10;
                    Point pointB = new Point(centerP.X + i * 10, centerP.Y - (int)num);
                    //string number = i.ToString();
                    pointsK.Add(pointB);

                }
                RedrawPoints(centerP, pointsK);
            }
            catch(Exception)
            {
                MyNewMessageBox m = new MyNewMessageBox("OK", "Invalid expression!");
                m.ShowDialog();
                txtEQ.SelectAll();
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Activate();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            MyNewMessageBox m = new MyNewMessageBox("Yes", "No", "Save?");
            DialogResult result = m.ShowDialog();
            if (result == DialogResult.OK)
            {
                Rectangle bounds = this.Bounds;
                Bitmap bmap = new Bitmap(bounds.Width, bounds.Height);
                using (Graphics g2 = Graphics.FromImage(bmap))
                {
                    g2.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
                }

                saveDialog = new SaveFileDialog();
                saveDialog.FileName = lblTitle.Text;
                saveDialog.DefaultExt = ".png";
                saveDialog.Filter = "PNG images (*.png)|*.png";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileName = saveDialog.FileName;
                    if (!System.IO.Path.HasExtension(fileName) || System.IO.Path.GetExtension(fileName) != ".png")
                    {
                        fileName = fileName + ".png";
                    }
                    bmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
            ClearText(tlpKinematic);
            pointsR.Clear();
            pointsR = new List<Point>();
            txtEQ.Focus();
            ClearPanelKinetic();
        }
        
        private void ClearText(Control control)
        {
            foreach (var c in control.Controls)
            {
                if (c is Control)
                {
                    ClearText((Control)c);
                }
                if (c is TextBox) ((TextBox)c).Text = "";
                if (c is TextBox) ((TextBox)c).Clear();
                if (c is RichTextBox) if (((RichTextBox)c).BackColor == Color.WhiteSmoke) ((RichTextBox)c).Text = "";
            }
        }

        private void ClearText2(Control control)
        {
            foreach (var c in control.Controls)
            {
                if (c is Control)
                {
                    ClearText2((Control)c);
                }
                if (c is RichTextBox) if (((RichTextBox)c).BackColor == Color.WhiteSmoke) ((RichTextBox)c).Text = "";
            }
        }

        private void btnPlot_Click(object sender, EventArgs e)
        {
            if (modeMain == "Kinematic")
            {
                string textt = txtEQ.Text;

                try
                {
                    if (textt.Contains("^"))
                    {
                        Regex pattern = new Regex(@"[\^]");
                        string txtt = pattern.Replace(textt, "**");
                        string str = @"plot " + txtt;

                        Maxima.GnuPlot(str);
                    }
                    else
                    {
                        string str = @"plot " + textt;
                        Maxima.GnuPlot(str);
                    }
                }
                catch(Exception exec)
                {
                    MyNewMessageBox m = new MyNewMessageBox("OK", "Error! Cannot plot this expression." + exec.ToString());
                    m.ShowDialog();
                }

            }
        }
    }

    public static class WinFormsExtensions
    {
        public static void AppendLine(this TextBox source, string value)
        {
            if (source.Text.Length == 0)
                source.Text = value;
            else
                source.AppendText("\r\n" + value);
        }
    }
}
