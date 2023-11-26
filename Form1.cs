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

        bool[] bitStates = new bool[32];

        CheckBox[] bitCheckBoxes;

        bool logicalShift = true;

        public Form1()
        {
            InitializeComponent();

            bitCheckBoxes = new CheckBox[] {bit0checkBox, bit1checkBox,
                                                       bit2checkBox, bit3checkBox,
                                                       bit4checkBox, bit5checkBox,
                                                       bit6checkBox, bit7checkBox,
                                                       bit8checkBox, bit9checkBox,
                                                       bit10checkBox, bit11checkBox,
                                                       bit12checkBox, bit13checkBox,
                                                       bit14checkBox, bit15checkBox,
                                                       bit16checkBox, bit17checkBox,
                                                       bit18checkBox, bit19checkBox,
                                                       bit20checkBox, bit21checkBox,
                                                       bit22checkBox, bit23checkBox,
                                                       bit24checkBox, bit25checkBox,
                                                       bit26checkBox, bit27checkBox,
                                                       bit28checkBox, bit29checkBox,
                                                       bit30checkBox, bit31checkBox};
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

        private void resetBitCheckBoxes()
        {
            for (int i = 0; i < 32; i++)
            {
                bitCheckBoxes[i].Checked = false;
            }

            calcResult();
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
            resetBitCheckBoxes();

            result = 0;

            hexValueTextBox.Text = "0x" + result.ToString("X8");
        }

        private void lshButton_Click(object sender, EventArgs e)
        {
            bitStates[0] = false;

            for (int i = 1; i < 32; i++)
            {

                bitStates[i] = bitCheckBoxes[i - 1].Checked;

            }

            resetBitCheckBoxes();

            for (int i = 0; i < 32; i++)
            {
                bitCheckBoxes[i].Checked = bitStates[i];
            }

            calcResult();
        }

        private void rshButton_Click(object sender, EventArgs e)
        {
            if(logicalShift)
            {
                bitStates[31] = false;
            }
            else
            {
                bitStates[31] = true;
            }
            

            for (int i = 30; i >= 0; i--)
            {

                bitStates[i] = bitCheckBoxes[i + 1].Checked;

            }

            resetBitCheckBoxes();

            for (int i = 0; i < 32; i++)
            {
                bitCheckBoxes[i].Checked = bitStates[i];
            }

            calcResult();
        }

        private void LShfradioButton_CheckedChanged(object sender, EventArgs e)
        {
            logicalShift = LShfradioButton.Checked;
        }

        private void AShfradioButton_CheckedChanged(object sender, EventArgs e)
        {
            logicalShift = !AShfradioButton.Checked;
        }
    }
}
