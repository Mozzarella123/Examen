using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenProj
{
    public partial class Form1 : Form
    {
        public AppDbContext Context;
        public Form1()
        {
            InitializeComponent();
            Context = new AppDbContext();
            label1.Text = Context.Films.First().Title;
        }
    }
}
