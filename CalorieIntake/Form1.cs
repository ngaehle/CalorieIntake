using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieIntake
{
    public partial class CalorieIntake : Form
    {
        public CalorieIntake()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            nameInput.Clear();
            carbInput.Clear();
            fatInput.Clear();
            proteinInput.Clear();
            fiberInput.Clear();
        }
    }
}
