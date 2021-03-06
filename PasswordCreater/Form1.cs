﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            var para = GetParameter();

            var pwd = new Password();
            //文字列生成
            var sr = new StringBuilder();
            if (para.Uppercase) sr.Append(pwd.CreateUppercases());
            if (para.Lowercase) sr.Append(pwd.CreateLowercases());
            if (para.Numbers) sr.Append(pwd.CreateNumbers());
            if (para.Symbols) sr.Append(pwd.CreateSymbols());
            
            var pwdList = new List<string>();
            for (int i = 0; i < para.CrePass; i++) {
                pwdList.Add(pwd.CreatePasswd(para.CharLen, sr.ToString(),pwd.CreateRandomSeed()));
            }

            dgv.Columns.Clear();
            //カラム追加
            dgv.Columns.Add("pass", "パスワード");
            dgv.AllowUserToAddRows = false;
            //レコード追加
            foreach (var item in pwdList) {
                dgv.Rows.Add(item);
            }
        }

        private void CrePassRb_CheckedChanged(object sender, EventArgs e) {
            if (CrePassRbCustom.Checked == true) {
                //テキストボックスを使用可能に変更
                CrePassUp.Enabled = true;
            } else if (CrePassRb10.Checked == true || 
                       CrePassRb20.Checked == true) {
                //テキストボックスを使用不可に変更
                CrePassUp.Enabled = false;
            }
        }

        private void CharLenRb_CheckedChanged(object sender, EventArgs e) {
            if (CharLenRbCustom.Checked == true) {
                CharLenUp.Enabled = true;
            } else if (CharLenRb8.Checked == true ||
                       CharLenRb16.Checked == true) {
                CharLenUp.Enabled = false;
            }
        }

        private Parameter GetParameter() {
            Parameter p = new Parameter();

            //使用記号
            p.Uppercase = UppercaseCB.Checked;  //大文字
            p.Lowercase = LowercaseCB.Checked;  //小文字
            p.Numbers = NumbersCB.Checked;  //数字
            p.Symbols = SymbolsCB.Checked;  //記号

            //パスワード長
            if (CharLenRb8.Checked == true) {
                p.CharLen = 8;
            } else if (CharLenRb16.Checked == true) {
                p.CharLen = 16;
            } else {
                //空白の場合の処理
                //デフォルト値を設定することで回避できる？
                p.CharLen = Convert.ToInt32(CharLenUp.Value);
            }
            //生成個数
            if (CrePassRb10.Checked == true) {
                p.CrePass = 10;
            } else if (CrePassRb20.Checked == true) {
                p.CrePass = 20;
            } else {
                //空白の場合の処理
                p.CrePass = Convert.ToInt32(CrePassUp.Value);
            }

            return p;
        }

        private void CsvBtn_Click(object sender, EventArgs e) {
            sfd.Filter = "CSVファイル|*.csv";
            if (sfd.ShowDialog() == DialogResult.OK) {
                try {
                    StreamWriter swriter = new StreamWriter(new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write));

                    for (int i = 1; i < dgv.RowCount - 1; i++) {
                        swriter.WriteLine("\"" + dgv[0, i].Value + "\",");
                    }
                    swriter.Close();
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void TxtBtn_Click(object sender, EventArgs e) {
            sfd.Filter = "TXTファイル|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK) {
                try {
                    StreamWriter swriter = new StreamWriter(new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write));

                    for (int i = 1; i < dgv.RowCount - 1; i++) {
                        swriter.WriteLine(dgv[0, i].Value);
                    }
                    swriter.Close();
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
