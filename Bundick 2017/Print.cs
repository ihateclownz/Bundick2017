using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bundick_2017
{
    public partial class Print : Form
    {
        public Main LogicalParent { get; set; }
        public Print()
        {
            Main main = new Main();
            InitializeComponent();


        }
    }
}
