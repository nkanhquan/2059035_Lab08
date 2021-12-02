﻿using System;
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
    public partial class uscClock : UserControl
    {
        private int mm, ss, ms;
        private int _mmBegin, _ssBegin;
        private bool flag;
 
        public delegate void uscEClock_ExitHandle();
        public event uscEClock_ExitHandle uscEClock_Exit;

        private void timer_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                ms++;
                if (ms >= 100)
                {
                    ms = 0;
                    ss++;
                }
                if (ss >= 60)
                {
                    ss = 0;
                    mm++;
                }
                if (mm >= 99)
                    mm = 0;
            }
            else
            {
                ms--;
                if (ms < 0)
                {
                    ms = 99;
                    ss--;
                }
                if (ss < 0)
                {
                    ss = 59;
                    mm--;
                }
                if (mm < 0)
                    mm = 99;
            }
            SetImage();

            if (!flag && mm == 0 && ss == 0 && ms == 0)
                uscEClock_Exit();
        }

        public int _mm
        {
            get
            {
                return _mmBegin;
            }
            set
            {
                if (value < 0)
                    _mmBegin = 0;
                else
                if (value > 99)
                    _mmBegin = 99;
                else
                    _mmBegin = value;
                mm1.Image = imageList.Images[_mmBegin / 10];
                mm2.Image = imageList.Images[_mmBegin % 10];
            }
        }

        public int _ss
        {
            get
            {
                return _ssBegin;
            }
            set
            {
                if (value < 0)
                    _ssBegin = 0;
                else
                    if (value > 60)
                    _ssBegin = 99;
                else
                    _ssBegin = value;
                ss1.Image = imageList.Images[_ssBegin / 10];
                ss2.Image = imageList.Images[_ssBegin % 10];
            }
        }

        public uscClock()
        {
            InitializeComponent();
            line1.Image = imageList.Images[10];
            line2.Image = imageList.Images[10];
            SetImage();
        }

        private void SetImage()
        {
            mm1.Image = imageList.Images[mm / 10];
            mm2.Image = imageList.Images[mm % 10];
            ss1.Image = imageList.Images[ss / 10];
            ss2.Image = imageList.Images[ss % 10];
            ms1.Image = imageList.Images[ms / 10];
            ms2.Image = imageList.Images[ms % 10];
        }

        public void Start()
        {
            timer.Enabled = true;
            flag = true;
            if (_mmBegin != 0)
            {
                mm = _mmBegin;
                flag = false;
            }
            if (_ssBegin != 0)
            {
                ss = _ssBegin;
                flag = false;
            }
        }

        public void Pause()
        {
            timer.Enabled = false;
        }

        private void SysTime_Tick(object sender, EventArgs e)
        {
            ms++;
            if (ms >= 60)
            {
                ms = 0;
                ss++;
            }
            if (ss >= 60)
            {
                ss = 0;
                mm++;
            }
            if (mm >= 24)
                mm = 0;
            SetImage();
        }

        public void Resume()
        {
            timer.Enabled = true;
        }

        public void Stop()
        {
            timer.Enabled = false;
            SysTime.Enabled = false;
            mm = ss = ms = 0;
            line1.Image = imageList.Images[10];
            line2.Image = imageList.Images[10];
            SetImage();
        }

        public void SystemTime()
        {
            timer.Enabled = false;
            SysTime.Enabled = true;
            mm = DateTime.Now.Hour;
            ss = DateTime.Now.Minute;
            ms = DateTime.Now.Second;
        }
    }
}
