using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopIt_engine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EngineLogic engine;

        private void Form1_Shown(object sender, EventArgs e)
        {
            engine = new EngineLogic();
            
        }
    }
}
