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
            //プロパティ取得（使用文字, パスワード長, 生成個数）
            Parameter para = new Parameter();
            

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

        private Parameter GetParameter() {
            Parameter p = new Parameter();

            //使用記号
            //大文字
            if (UppercaseCB.Checked == true) {
                p.Uppercase = true;
            } else {
                p.Uppercase = false;
            }
            //小文字
            if (LowercaseCB.Checked == true) {
                p.Lowercase = true;
            } else {
                p.Lowercase = false;
            }
            //数字
            if (NumbersCB.Checked == true) {
                p.Numbers = true;
            } else {
                p.Numbers = false;
            }
            //記号
            if (SymbolsCB.Checked == true) {
                p.Symbols = true;
            } else {
                p.Symbols = false;
            }

            //パスワード長
            if (CharLenRb8.Checked == true) {
                p.CharLen = 8;
            } else if (CharLenRb16.Checked == true) {
                p.CharLen = 16;
            } else {
                //空白の場合の処理
                //デフォルト値を設定することで回避できる？
                p.CharLen = Convert.ToInt16(CharLenTbCustom.Text);
            }
            //生成個数
            if (CrePassRb10.Checked == true) {
                p.CrePass = 10;
            } else if (CrePassRb20.Checked == true) {
                p.CrePass = 20;
            } else {
                //空白の場合の処理
                p.CrePass = Convert.ToInt16(CrePassTbCustom.Text);
            }

            return p;
        }
    }
}
