﻿namespace PasswordCreater {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.CreateButton = new System.Windows.Forms.Button();
            this.Characters = new System.Windows.Forms.GroupBox();
            this.UpeCharCB = new System.Windows.Forms.CheckBox();
            this.LowCharCB = new System.Windows.Forms.CheckBox();
            this.NumCharCB = new System.Windows.Forms.CheckBox();
            this.SymCharCB = new System.Windows.Forms.CheckBox();
            this.CharactersLen = new System.Windows.Forms.GroupBox();
            this.CharLen8 = new System.Windows.Forms.RadioButton();
            this.CharLen16 = new System.Windows.Forms.RadioButton();
            this.CharLenCustom = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GeneratePasswdCnt = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Characters.SuspendLayout();
            this.CharactersLen.SuspendLayout();
            this.GeneratePasswdCnt.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(12, 12);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(141, 53);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.Text = "パスワード生成";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Characters
            // 
            this.Characters.Controls.Add(this.SymCharCB);
            this.Characters.Controls.Add(this.NumCharCB);
            this.Characters.Controls.Add(this.LowCharCB);
            this.Characters.Controls.Add(this.UpeCharCB);
            this.Characters.Location = new System.Drawing.Point(12, 72);
            this.Characters.Name = "Characters";
            this.Characters.Size = new System.Drawing.Size(141, 116);
            this.Characters.TabIndex = 1;
            this.Characters.TabStop = false;
            this.Characters.Text = "使用文字";
            // 
            // UpeCharCB
            // 
            this.UpeCharCB.AutoSize = true;
            this.UpeCharCB.Location = new System.Drawing.Point(7, 19);
            this.UpeCharCB.Name = "UpeCharCB";
            this.UpeCharCB.Size = new System.Drawing.Size(92, 16);
            this.UpeCharCB.TabIndex = 0;
            this.UpeCharCB.Text = "英字(大文字)";
            this.UpeCharCB.UseVisualStyleBackColor = true;
            // 
            // LowCharCB
            // 
            this.LowCharCB.AutoSize = true;
            this.LowCharCB.Location = new System.Drawing.Point(7, 42);
            this.LowCharCB.Name = "LowCharCB";
            this.LowCharCB.Size = new System.Drawing.Size(92, 16);
            this.LowCharCB.TabIndex = 1;
            this.LowCharCB.Text = "英字(小文字)";
            this.LowCharCB.UseVisualStyleBackColor = true;
            // 
            // NumCharCB
            // 
            this.NumCharCB.AutoSize = true;
            this.NumCharCB.Location = new System.Drawing.Point(7, 65);
            this.NumCharCB.Name = "NumCharCB";
            this.NumCharCB.Size = new System.Drawing.Size(48, 16);
            this.NumCharCB.TabIndex = 2;
            this.NumCharCB.Text = "数字";
            this.NumCharCB.UseVisualStyleBackColor = true;
            // 
            // SymCharCB
            // 
            this.SymCharCB.AutoSize = true;
            this.SymCharCB.Location = new System.Drawing.Point(7, 88);
            this.SymCharCB.Name = "SymCharCB";
            this.SymCharCB.Size = new System.Drawing.Size(48, 16);
            this.SymCharCB.TabIndex = 3;
            this.SymCharCB.Text = "記号";
            this.SymCharCB.UseVisualStyleBackColor = true;
            // 
            // CharactersLen
            // 
            this.CharactersLen.Controls.Add(this.textBox1);
            this.CharactersLen.Controls.Add(this.CharLenCustom);
            this.CharactersLen.Controls.Add(this.CharLen16);
            this.CharactersLen.Controls.Add(this.CharLen8);
            this.CharactersLen.Location = new System.Drawing.Point(13, 194);
            this.CharactersLen.Name = "CharactersLen";
            this.CharactersLen.Size = new System.Drawing.Size(140, 92);
            this.CharactersLen.TabIndex = 2;
            this.CharactersLen.TabStop = false;
            this.CharactersLen.Text = "パスワード文字数";
            // 
            // CharLen8
            // 
            this.CharLen8.AutoSize = true;
            this.CharLen8.Location = new System.Drawing.Point(6, 19);
            this.CharLen8.Name = "CharLen8";
            this.CharLen8.Size = new System.Drawing.Size(53, 16);
            this.CharLen8.TabIndex = 0;
            this.CharLen8.TabStop = true;
            this.CharLen8.Text = "8文字";
            this.CharLen8.UseVisualStyleBackColor = true;
            // 
            // CharLen16
            // 
            this.CharLen16.AutoSize = true;
            this.CharLen16.Location = new System.Drawing.Point(6, 42);
            this.CharLen16.Name = "CharLen16";
            this.CharLen16.Size = new System.Drawing.Size(59, 16);
            this.CharLen16.TabIndex = 1;
            this.CharLen16.TabStop = true;
            this.CharLen16.Text = "16文字";
            this.CharLen16.UseVisualStyleBackColor = true;
            // 
            // CharLenCustom
            // 
            this.CharLenCustom.AutoSize = true;
            this.CharLenCustom.Location = new System.Drawing.Point(6, 65);
            this.CharLenCustom.Name = "CharLenCustom";
            this.CharLenCustom.Size = new System.Drawing.Size(47, 16);
            this.CharLenCustom.TabIndex = 2;
            this.CharLenCustom.TabStop = true;
            this.CharLenCustom.Text = "任意";
            this.CharLenCustom.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 19);
            this.textBox1.TabIndex = 3;
            // 
            // GeneratePasswdCnt
            // 
            this.GeneratePasswdCnt.Controls.Add(this.textBox2);
            this.GeneratePasswdCnt.Controls.Add(this.radioButton3);
            this.GeneratePasswdCnt.Controls.Add(this.radioButton2);
            this.GeneratePasswdCnt.Controls.Add(this.radioButton1);
            this.GeneratePasswdCnt.Location = new System.Drawing.Point(12, 292);
            this.GeneratePasswdCnt.Name = "GeneratePasswdCnt";
            this.GeneratePasswdCnt.Size = new System.Drawing.Size(141, 92);
            this.GeneratePasswdCnt.TabIndex = 3;
            this.GeneratePasswdCnt.TabStop = false;
            this.GeneratePasswdCnt.Text = "パスワード生成数";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(35, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "10";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(35, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "20";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "任意";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(60, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 19);
            this.textBox2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 390);
            this.Controls.Add(this.GeneratePasswdCnt);
            this.Controls.Add(this.CharactersLen);
            this.Controls.Add(this.Characters);
            this.Controls.Add(this.CreateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Characters.ResumeLayout(false);
            this.Characters.PerformLayout();
            this.CharactersLen.ResumeLayout(false);
            this.CharactersLen.PerformLayout();
            this.GeneratePasswdCnt.ResumeLayout(false);
            this.GeneratePasswdCnt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.GroupBox Characters;
        private System.Windows.Forms.CheckBox SymCharCB;
        private System.Windows.Forms.CheckBox NumCharCB;
        private System.Windows.Forms.CheckBox LowCharCB;
        private System.Windows.Forms.CheckBox UpeCharCB;
        private System.Windows.Forms.GroupBox CharactersLen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton CharLenCustom;
        private System.Windows.Forms.RadioButton CharLen16;
        private System.Windows.Forms.RadioButton CharLen8;
        private System.Windows.Forms.GroupBox GeneratePasswdCnt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

