using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OIC_PBL
{
    public partial class _2_1コロナ対応画面1 : Form
    {
        public _2_1コロナ対応画面1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _2_4コロナ対応画面2 f1 = new _2_4コロナ対応画面2();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _2_5コロナ対応画面3 f1 = new _2_5コロナ対応画面3();
            f1.Show();
        }
    }
}
