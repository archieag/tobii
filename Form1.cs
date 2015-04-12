using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActivatableElements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Program.EyeXHost.Connect(_behaviorMap1);
            behaviorMap1.Add(_button1, new EyeXFramework.ActivatableBehavior(OnButton1Activated));
        }
            // Handle the activated event from the EyeX Engine to trigger a click
        private void OnButton1Activated(object sender, EventArgs e)
        {
            _button1.PerformClick();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
