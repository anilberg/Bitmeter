using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitmeter
{
    public partial class Form1 : Form
    {
        int result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcResult()
        {
            result = 0;

            if (bit0checkBox.Checked)
            {
                result += 1;
            }

            if (bit1checkBox.Checked)
            {
                result += 2;
            }

            if (bit2checkBox.Checked)
            {
                result += 4;
            }

            if (bit3checkBox.Checked)
            {
                result += 8;
            }

            if (bit4checkBox.Checked)
            {
                result += 16;
            }

            if (bit5checkBox.Checked)
            {
                result += 32;
            }

            if (bit6checkBox.Checked)
            {
                result += 64;
            }

            if (bit7checkBox.Checked)
            {
                result += 128;
            }

            if (bit8checkBox.Checked)
            {
                result += 256;
            }

            if (bit9checkBox.Checked)
            {
                result += 512;
            }

            if (bit10checkBox.Checked)
            {
                result += 1024;
            }

            if (bit11checkBox.Checked)
            {
                result += 2048;
            }

            if (bit12checkBox.Checked)
            {
                result += 4096;
            }

            if (bit13checkBox.Checked)
            {
                result += (int) Math.Pow(2, 13);
            }

            if (bit14checkBox.Checked)
            {
                result += (int) Math.Pow(2, 14);
            }

            if (bit15checkBox.Checked)
            {
                result += (int) Math.Pow(2, 15);
            }

            if (bit16checkBox.Checked)
            {
                result += (int) Math.Pow(2, 16);
            }

            if (bit17checkBox.Checked)
            {
                result += (int) Math.Pow(2, 17);
            }

            if (bit18checkBox.Checked)
            {
                result += (int) Math.Pow(2, 18);
            }

            if (bit19checkBox.Checked)
            {
                result += (int) Math.Pow(2, 19);
            }

            if (bit20checkBox.Checked)
            {
                result += (int) Math.Pow(2, 20);
            }

            if (bit21checkBox.Checked)
            {
                result += (int) Math.Pow(2, 21);
            }

            if (bit22checkBox.Checked)
            {
                result += (int) Math.Pow(2, 22);
            }

            if (bit23checkBox.Checked)
            {
                result += (int) Math.Pow(2, 23);
            }

            if (bit24checkBox.Checked)
            {
                result += (int) Math.Pow(2, 24);
            }

            if (bit25checkBox.Checked)
            {
                result += (int) Math.Pow(2, 25);
            }

            if (bit26checkBox.Checked)
            {
                result += (int) Math.Pow(2, 26);
            }

            if (bit27checkBox.Checked)
            {
                result += (int) Math.Pow(2, 27);
            }

            if (bit28checkBox.Checked)
            {
                result += (int) Math.Pow(2, 28);
            }

            if (bit29checkBox.Checked)
            {
                result += (int) Math.Pow(2, 29);
            }

            if (bit30checkBox.Checked)
            {
                result += (int) Math.Pow(2, 30);
            }

            if (bit31checkBox.Checked)
            {
                result += (int) Math.Pow(2, 31);
            }

            hexValueTextBox.Text = "0x" + result.ToString("X8");
        }

        private void bit0checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit1checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit2checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit3checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit4checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit5checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit6checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit7checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit8checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit9checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit10checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit11checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit12checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit13checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit14checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit15checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit16checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit17checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit18checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit19checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit20checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit21checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit22checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit23checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit24checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit25checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit26checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit27checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit28checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit29checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit30checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void bit31checkBox_CheckedChanged(object sender, EventArgs e)
        {
            calcResult();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            bit0checkBox.Checked = false;
            bit1checkBox.Checked = false;
            bit2checkBox.Checked = false;
            bit3checkBox.Checked = false;

            bit4checkBox.Checked = false;
            bit5checkBox.Checked = false;
            bit6checkBox.Checked = false;
            bit7checkBox.Checked = false;

            bit8checkBox.Checked  = false;
            bit9checkBox.Checked  = false;
            bit10checkBox.Checked = false;
            bit11checkBox.Checked = false;

            bit12checkBox.Checked = false;
            bit13checkBox.Checked = false;
            bit14checkBox.Checked = false;
            bit15checkBox.Checked = false;

            bit16checkBox.Checked = false;
            bit17checkBox.Checked = false;
            bit18checkBox.Checked = false;
            bit19checkBox.Checked = false;

            bit20checkBox.Checked = false;
            bit21checkBox.Checked = false;
            bit22checkBox.Checked = false;
            bit23checkBox.Checked = false;

            bit24checkBox.Checked = false;
            bit25checkBox.Checked = false;
            bit26checkBox.Checked = false;
            bit27checkBox.Checked = false;

            bit28checkBox.Checked = false;
            bit29checkBox.Checked = false;
            bit30checkBox.Checked = false;
            bit31checkBox.Checked = false;

            result = 0;

            hexValueTextBox.Text = "0x" + result.ToString("X8");
        }
    }
}
