using System;
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
            //Password pw = new Password();
            //var s = pw.CharacterCreate();
            //Console.WriteLine("\r\n結果");
            //Console.Write(pw.PasswdCreate(8, s));
        }

        private void CrePassRb_CheckedChanged(object sender, EventArgs e) {
            if (CrePassRbCustom.Checked == true) {
                //テキストボックスを使用可能に変更
                CrePassTbCustom.Enabled = true;
            } else if (CrePassRb10.Checked == true || 
                       CrePassRb20.Checked == true) {
                //テキストボックスを使用不可に変更
                CrePassTbCustom.Enabled = false;
            }
        }

        private void CharLenRb_CheckedChanged(object sender, EventArgs e) {
            if (CharLenRbCustom.Checked == true) {
                CharLenTbCustom.Enabled = true;
            } else if (CharLenRb8.Checked == true ||
                       CharLenRb16.Checked == true) {
                CharLenTbCustom.Enabled = false;
            }
        }
    }
}
