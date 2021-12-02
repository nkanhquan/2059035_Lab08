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
    public partial class EClockForm : Form
    {

        public EClockForm()
        {
            InitializeComponent();
            bt_Pause.Enabled = false;
            bt_Resume.Enabled = false;
            bt_Stop.Enabled = false;

            //Khai báo sự kiện cho các UserControl với Windows Form hiện tại --> Chụp trái banh 
            uscClock1.uscEClock_Exit += new uscClock.uscEClock_ExitHandle(uscClock1_uscEClock_Exit);
            useSetClock1.uscSetClock_Change += new useSetClock.uscSetClock_ChangeHandle(uscSetClock1_uscSetClock_Change);
        }

        void uscSetClock1_uscSetClock_Change()
        {
            uscClock1._mm = useSetClock1._mm;
            uscClock1._ss = useSetClock1._ss;
        }

        void uscClock1_uscEClock_Exit()
        {
            uscClock1.Stop();
            bt_Start.Enabled = true;
            bt_Pause.Enabled = false;
            bt_Resume.Enabled = false;
            bt_Stop.Enabled = false;
            useSetClock1.Enabled = true;
            useSetClock1._mm = useSetClock1._ss = 0;
            MessageBox.Show("Over time", "EClock Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void bt_Start_Click(object sender, EventArgs e)
        {
            uscClock1._mm = useSetClock1._mm;
            uscClock1._ss = useSetClock1._ss;
            uscClock1.Start();
            bt_Start.Enabled = false;
            bt_Pause.Enabled = true;
            bt_Stop.Enabled = true;
            useSetClock1.Enabled = false;
        }

        private void bt_Pause_Click(object sender, EventArgs e)
        {
            uscClock1.Pause();
            bt_Pause.Enabled = false;
            bt_Resume.Enabled = true;
            useSetClock1.Enabled = false;
        }

        private void bt_Resume_Click(object sender, EventArgs e)
        {
            uscClock1.Resume();
            bt_Pause.Enabled = true;
            bt_Resume.Enabled = false;
            useSetClock1.Enabled = false;
        }

        private void bt_Stop_Click(object sender, EventArgs e)
        {
            uscClock1.Stop();
            useSetClock1._mm = useSetClock1._ss = 0;
            bt_Start.Enabled = true;
            bt_Pause.Enabled = false;
            bt_Resume.Enabled = false;
            bt_Stop.Enabled = false;
            useSetClock1.Enabled = true;
        }

        private void btnSysTime_Click(object sender, EventArgs e)
        {
            uscClock1.SystemTime();
            bt_Start.Enabled = false;
            bt_Pause.Enabled = false;
            bt_Resume.Enabled = false;
            bt_Stop.Enabled = true;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EClock 's designed by \n Nguyen Duc Huy \n ndhuy@fit.hcmus.edu.vn", "Infomation of EClock", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
