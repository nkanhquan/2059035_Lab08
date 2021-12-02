using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise01
{
    public partial class useSetClock : UserControl
    {
        public int _mm
        {
            get
            {
                return (int)minute.Value;
            }
            set
            {
                if (value < 0)
                    minute.Value = 0;
                else
                    if (value > 99)
                    minute.Value = 99;
                else
                    minute.Value = value;
            }
        }

        public int _ss
        {
            get
            {
                return (int)second.Value;
            }
            set
            {
                if (value < 0)
                    second.Value = 0;
                else
                    if (value > 60)
                        second.Value = 99;
                    else
                        second.Value = value;
            }
        }

        public delegate void uscSetClock_ChangeHandle();
        public event uscSetClock_ChangeHandle uscSetClock_Change;

        public useSetClock()
        {
            InitializeComponent();
        }

        private void minute_ValueChanged(object sender, EventArgs e)
        {
            uscSetClock_Change();
        }

        private void second_ValueChanged(object sender, EventArgs e)
        {
            uscSetClock_Change();
        }
    }
}
