using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();

            #region Variables

            int formSizeW = this.Size.Width;
            int label1SizeW = label1.Size.Width;
            int label2SizeW = label2.Size.Width;
            int label3SizeW = label3.Size.Width;
            int btnSizeW = btnClose.Size.Width;

            #endregion
            #region Write to Console

            Console.WriteLine("Form Width " + formSizeW);
            Console.WriteLine("Label1 Width " + label1SizeW);
            Console.WriteLine("Label2 Width " + label2SizeW);
            Console.WriteLine("Label3 Width " + label3SizeW);
            Console.WriteLine("Button Width " + btnSizeW);

            #endregion
            #region Set Properties

            this.Width = label1SizeW + 100;
            label1.Location = new Point(50,33);
            label2.Location = new Point((formSizeW / 2) - (label2SizeW / 2), 57);
            label3.Location = new Point((formSizeW / 2) - (label3SizeW / 2), 73);
            btnClose.Location = new Point((formSizeW / 2) - (btnSizeW / 2), 92);
            #endregion
        }

        #region Form Interaction

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
