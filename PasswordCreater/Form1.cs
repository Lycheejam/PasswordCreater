﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordCreater {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Password pw = new Password();
            var s = pw.CharacterCreate();
            Console.WriteLine("\r\n結果");
            Console.Write(pw.PasswdCreate(8, s));
        }
    }
}