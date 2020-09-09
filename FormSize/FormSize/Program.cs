﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormSize
{
    class Program : Form
    {
        static void Main(string[] args)
        {
            Program form = new Program();
            form.Width = 300;
            form.Height = 200;
            form.MouseDown += new MouseEventHandler(form_MouseDown);
            Application.Run(form);
        }
        static void form_MouseDown(object sender, MouseEventArgs e)
        {
            Form form = (Form)sender;
            int oldWidth = form.Width;
            int oldHeight = form.Height;
            if(e.Button == MouseButtons.Left)
            {
                if (oldWidth < oldHeight)
                {
                    form.Width = oldWidth;
                    form.Height = oldHeight;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (oldWidth < oldHeight)
                {
                    form.Width = oldWidth;
                    form.Height = oldHeight;
                }
            }
            Console.WriteLine($"Width : {form.Width}, Height : {form.Height}");
        }
    }
}
