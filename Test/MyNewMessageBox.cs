using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class MyNewMessageBox : Form
    {

        public Button buttony;
        public Button buttonn;
        private Color clrGreen = Color.FromArgb(72, 165, 112);
        private Color clrGains = Color.Gainsboro;
        private Color clrWhite = Color.White;
        private Color clrGrey = Color.FromArgb(51, 55, 66);

        public MyNewMessageBox(string no, string msg)
        {
            Button button2 = new Button();
            this.Size = new Size(440, 200);
            this.BackColor = clrGains;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Opacity = .95f;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.CancelButton = button2;

            button2.Text = no;
            button2.BackColor = clrGreen;
            button2.ForeColor = clrWhite;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderColor = clrGreen;
            button2.Font = new Font("Lato", 9);
            button2.Size = new Size(((this.Width / 12) * 4) - 2, ((this.Height / 12) * 2) - 2);
            button2.Location = new Point((this.Width / 12) * 4, (this.Height / 6) * 4);

            this.Controls.Add(button2);

            Panel p = new Panel();
            p.BackColor = clrWhite;
            p.Size = new Size(this.Width - 12, this.Height - 12);
            p.Location = new Point((this.Width - p.Width) / 2, (this.Height - p.Height) / 2);
            this.Controls.Add(p);

            Label lbN = new Label();
            lbN.Text = msg;
            lbN.Padding = new System.Windows.Forms.Padding(4, 20, 4, 4);
            lbN.Dock = DockStyle.Top;
            lbN.Size = new System.Drawing.Size(this.Width, 100);
            lbN.ForeColor = clrGrey;
            lbN.BorderStyle = BorderStyle.None;
            lbN.Font = new Font("Lato", 9);
            lbN.Location = new Point(12, 12);
            lbN.TextAlign = ContentAlignment.MiddleCenter;
            p.Controls.Add(lbN);


            this.SendToBack();
        }

        public MyNewMessageBox(string yes, string no, string msg)
        {
            buttony = new Button();
            buttonn = new Button();
            this.Size = new Size(440, 200);
            this.BackColor = clrGains;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Opacity = .95f;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.AcceptButton = buttony;
            this.CancelButton = buttonn;

            buttony.Text = yes;
            //buttony.FlatAppearance.MouseDownBackColor = clrw;
            //buttony.FlatAppearance.MouseOverBackColor = clrg;
            buttony.BackColor = clrGreen;
            buttony.ForeColor = clrWhite;
            buttony.FlatStyle = FlatStyle.Flat;
            buttony.FlatAppearance.BorderSize = 0;
            buttony.FlatAppearance.BorderColor = clrGreen;
            buttony.Font = new Font("Lato", 9);
            buttony.Size = new Size(((this.Width / 12) * 4) - 2, ((this.Height / 12) * 2) - 2);
            buttony.Location = new Point((this.Width / 12) * 2, (this.Height / 6) * 4);
            buttony.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Controls.Add(buttony);


            buttonn.Text = no;
            //buttonn.FlatAppearance.MouseDownBackColor = clrw;
            //buttonn.FlatAppearance.MouseOverBackColor = clrg;
            buttonn.BackColor = clrGreen;
            buttonn.ForeColor = clrWhite;
            buttonn.FlatStyle = FlatStyle.Flat;
            buttonn.FlatAppearance.BorderSize = 0;
            buttonn.FlatAppearance.BorderColor = clrGreen;
            buttonn.Font = new Font("Lato", 9);
            buttonn.Size = new Size(((this.Width / 12) * 4) - 2, ((this.Height / 12) * 2) - 2);
            buttonn.Location = new Point((this.Width / 12) * 6, (this.Height / 6) * 4);
            this.Controls.Add(buttonn);

            Panel p = new Panel();
            p.BackColor = clrWhite;
            p.Size = new Size(this.Width - 12, this.Height - 12);
            p.Location = new Point((this.Width - p.Width) / 2, (this.Height - p.Height) / 2);
            this.Controls.Add(p);

            Label lbN = new Label();
            lbN.Text = msg;
            lbN.Padding = new System.Windows.Forms.Padding(4, 20, 4, 4);
            lbN.Dock = DockStyle.Top;
            lbN.Size = new System.Drawing.Size(this.Width, 100);
            lbN.ForeColor = clrGrey;
            lbN.BorderStyle = BorderStyle.None;
            lbN.Font = new Font("Lato", 9);
            lbN.Location = new Point(12, 12);
            lbN.TextAlign = ContentAlignment.MiddleCenter;
            p.Controls.Add(lbN);

            this.SendToBack();
        }
    }
}
