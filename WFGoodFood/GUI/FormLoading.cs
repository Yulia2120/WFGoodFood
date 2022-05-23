using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFGoodFood.GUI
{
    public partial class FormLoading : Form
    {
        Timer timer1 = new Timer();
        Timer timer2 = new Timer();
        int plus = 2;
        public FormLoading()
        {
            InitializeComponent();
        }
        // pnlMove function
        void Slide(object sender, EventArgs e)
        {
            panMove.Left += 2;
            if(panMove.Left > 257)
            {
                panMove.Left = 0;
            }
            if(panMove.Left < 0)
            {
                plus = 2;
            }
        }
        //FormLoading Event
        private void FormLoading_Load(object sender, EventArgs e)
        {
            //timer Event
            timer1.Tick += new EventHandler(Slide);
            timer1.Interval = 10;
            timer1.Start();

            timer2.Tick += new EventHandler(CloseForm);
            timer2.Interval = 5000;
            timer2.Start();
        }

        void CloseForm(object sender, EventArgs e)
        {
            Close();
            //Hide();
            //(LoginForm log = new LoginForm();
        }

        
    }
}
