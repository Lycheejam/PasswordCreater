namespace PasswordCreater {
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
            this.SymbolsCB = new System.Windows.Forms.CheckBox();
            this.NumbersCB = new System.Windows.Forms.CheckBox();
            this.LowercaseCB = new System.Windows.Forms.CheckBox();
            this.UppercaseCB = new System.Windows.Forms.CheckBox();
            this.CharactersLen = new System.Windows.Forms.GroupBox();
            this.CharLenTbCustom = new System.Windows.Forms.TextBox();
            this.CharLenRbCustom = new System.Windows.Forms.RadioButton();
            this.CharLenRb16 = new System.Windows.Forms.RadioButton();
            this.CharLenRb8 = new System.Windows.Forms.RadioButton();
            this.CrePassCustom = new System.Windows.Forms.GroupBox();
            this.CrePassTbCustom = new System.Windows.Forms.TextBox();
            this.CrePassRbCustom = new System.Windows.Forms.RadioButton();
            this.CrePassRb20 = new System.Windows.Forms.RadioButton();
            this.CrePassRb10 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Characters.SuspendLayout();
            this.CharactersLen.SuspendLayout();
            this.CrePassCustom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.Characters.Controls.Add(this.SymbolsCB);
            this.Characters.Controls.Add(this.NumbersCB);
            this.Characters.Controls.Add(this.LowercaseCB);
            this.Characters.Controls.Add(this.UppercaseCB);
            this.Characters.Location = new System.Drawing.Point(12, 72);
            this.Characters.Name = "Characters";
            this.Characters.Size = new System.Drawing.Size(141, 116);
            this.Characters.TabIndex = 1;
            this.Characters.TabStop = false;
            this.Characters.Text = "使用文字";
            // 
            // SymbolsCB
            // 
            this.SymbolsCB.AutoSize = true;
            this.SymbolsCB.Location = new System.Drawing.Point(7, 88);
            this.SymbolsCB.Name = "SymbolsCB";
            this.SymbolsCB.Size = new System.Drawing.Size(48, 16);
            this.SymbolsCB.TabIndex = 3;
            this.SymbolsCB.Text = "記号";
            this.SymbolsCB.UseVisualStyleBackColor = true;
            // 
            // NumbersCB
            // 
            this.NumbersCB.AutoSize = true;
            this.NumbersCB.Location = new System.Drawing.Point(7, 65);
            this.NumbersCB.Name = "NumbersCB";
            this.NumbersCB.Size = new System.Drawing.Size(48, 16);
            this.NumbersCB.TabIndex = 2;
            this.NumbersCB.Text = "数字";
            this.NumbersCB.UseVisualStyleBackColor = true;
            // 
            // LowercaseCB
            // 
            this.LowercaseCB.AutoSize = true;
            this.LowercaseCB.Location = new System.Drawing.Point(7, 42);
            this.LowercaseCB.Name = "LowercaseCB";
            this.LowercaseCB.Size = new System.Drawing.Size(92, 16);
            this.LowercaseCB.TabIndex = 1;
            this.LowercaseCB.Text = "英字(小文字)";
            this.LowercaseCB.UseVisualStyleBackColor = true;
            // 
            // UppercaseCB
            // 
            this.UppercaseCB.AutoSize = true;
            this.UppercaseCB.Location = new System.Drawing.Point(7, 19);
            this.UppercaseCB.Name = "UppercaseCB";
            this.UppercaseCB.Size = new System.Drawing.Size(92, 16);
            this.UppercaseCB.TabIndex = 0;
            this.UppercaseCB.Text = "英字(大文字)";
            this.UppercaseCB.UseVisualStyleBackColor = true;
            // 
            // CharactersLen
            // 
            this.CharactersLen.Controls.Add(this.CharLenTbCustom);
            this.CharactersLen.Controls.Add(this.CharLenRbCustom);
            this.CharactersLen.Controls.Add(this.CharLenRb16);
            this.CharactersLen.Controls.Add(this.CharLenRb8);
            this.CharactersLen.Location = new System.Drawing.Point(13, 194);
            this.CharactersLen.Name = "CharactersLen";
            this.CharactersLen.Size = new System.Drawing.Size(140, 92);
            this.CharactersLen.TabIndex = 2;
            this.CharactersLen.TabStop = false;
            this.CharactersLen.Text = "パスワード文字数";
            // 
            // CharLenTbCustom
            // 
            this.CharLenTbCustom.Enabled = false;
            this.CharLenTbCustom.Location = new System.Drawing.Point(59, 64);
            this.CharLenTbCustom.Name = "CharLenTbCustom";
            this.CharLenTbCustom.Size = new System.Drawing.Size(74, 19);
            this.CharLenTbCustom.TabIndex = 3;
            // 
            // CharLenRbCustom
            // 
            this.CharLenRbCustom.AutoSize = true;
            this.CharLenRbCustom.Location = new System.Drawing.Point(6, 65);
            this.CharLenRbCustom.Name = "CharLenRbCustom";
            this.CharLenRbCustom.Size = new System.Drawing.Size(47, 16);
            this.CharLenRbCustom.TabIndex = 2;
            this.CharLenRbCustom.Text = "任意";
            this.CharLenRbCustom.UseVisualStyleBackColor = true;
            this.CharLenRbCustom.CheckedChanged += new System.EventHandler(this.CharLenRb_CheckedChanged);
            // 
            // CharLenRb16
            // 
            this.CharLenRb16.AutoSize = true;
            this.CharLenRb16.Location = new System.Drawing.Point(6, 42);
            this.CharLenRb16.Name = "CharLenRb16";
            this.CharLenRb16.Size = new System.Drawing.Size(59, 16);
            this.CharLenRb16.TabIndex = 1;
            this.CharLenRb16.Text = "16文字";
            this.CharLenRb16.UseVisualStyleBackColor = true;
            this.CharLenRb16.CheckedChanged += new System.EventHandler(this.CharLenRb_CheckedChanged);
            // 
            // CharLenRb8
            // 
            this.CharLenRb8.AutoSize = true;
            this.CharLenRb8.Checked = true;
            this.CharLenRb8.Location = new System.Drawing.Point(6, 19);
            this.CharLenRb8.Name = "CharLenRb8";
            this.CharLenRb8.Size = new System.Drawing.Size(53, 16);
            this.CharLenRb8.TabIndex = 0;
            this.CharLenRb8.TabStop = true;
            this.CharLenRb8.Text = "8文字";
            this.CharLenRb8.UseVisualStyleBackColor = true;
            this.CharLenRb8.CheckedChanged += new System.EventHandler(this.CharLenRb_CheckedChanged);
            // 
            // CrePassCustom
            // 
            this.CrePassCustom.Controls.Add(this.CrePassTbCustom);
            this.CrePassCustom.Controls.Add(this.CrePassRbCustom);
            this.CrePassCustom.Controls.Add(this.CrePassRb20);
            this.CrePassCustom.Controls.Add(this.CrePassRb10);
            this.CrePassCustom.Location = new System.Drawing.Point(12, 292);
            this.CrePassCustom.Name = "CrePassCustom";
            this.CrePassCustom.Size = new System.Drawing.Size(141, 92);
            this.CrePassCustom.TabIndex = 3;
            this.CrePassCustom.TabStop = false;
            this.CrePassCustom.Text = "パスワード生成数";
            // 
            // CrePassTbCustom
            // 
            this.CrePassTbCustom.Enabled = false;
            this.CrePassTbCustom.Location = new System.Drawing.Point(60, 64);
            this.CrePassTbCustom.Name = "CrePassTbCustom";
            this.CrePassTbCustom.Size = new System.Drawing.Size(73, 19);
            this.CrePassTbCustom.TabIndex = 3;
            // 
            // CrePassRbCustom
            // 
            this.CrePassRbCustom.AutoSize = true;
            this.CrePassRbCustom.Location = new System.Drawing.Point(7, 65);
            this.CrePassRbCustom.Name = "CrePassRbCustom";
            this.CrePassRbCustom.Size = new System.Drawing.Size(47, 16);
            this.CrePassRbCustom.TabIndex = 2;
            this.CrePassRbCustom.Text = "任意";
            this.CrePassRbCustom.UseVisualStyleBackColor = true;
            this.CrePassRbCustom.CheckedChanged += new System.EventHandler(this.CrePassRb_CheckedChanged);
            // 
            // CrePassRb20
            // 
            this.CrePassRb20.AutoSize = true;
            this.CrePassRb20.Location = new System.Drawing.Point(7, 42);
            this.CrePassRb20.Name = "CrePassRb20";
            this.CrePassRb20.Size = new System.Drawing.Size(35, 16);
            this.CrePassRb20.TabIndex = 1;
            this.CrePassRb20.Text = "20";
            this.CrePassRb20.UseVisualStyleBackColor = true;
            this.CrePassRb20.CheckedChanged += new System.EventHandler(this.CrePassRb_CheckedChanged);
            // 
            // CrePassRb10
            // 
            this.CrePassRb10.AutoSize = true;
            this.CrePassRb10.Checked = true;
            this.CrePassRb10.Location = new System.Drawing.Point(7, 19);
            this.CrePassRb10.Name = "CrePassRb10";
            this.CrePassRb10.Size = new System.Drawing.Size(35, 16);
            this.CrePassRb10.TabIndex = 0;
            this.CrePassRb10.TabStop = true;
            this.CrePassRb10.Text = "10";
            this.CrePassRb10.UseVisualStyleBackColor = true;
            this.CrePassRb10.CheckedChanged += new System.EventHandler(this.CrePassRb_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(159, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(419, 372);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 390);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CrePassCustom);
            this.Controls.Add(this.CharactersLen);
            this.Controls.Add(this.Characters);
            this.Controls.Add(this.CreateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Characters.ResumeLayout(false);
            this.Characters.PerformLayout();
            this.CharactersLen.ResumeLayout(false);
            this.CharactersLen.PerformLayout();
            this.CrePassCustom.ResumeLayout(false);
            this.CrePassCustom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.GroupBox Characters;
        private System.Windows.Forms.CheckBox SymbolsCB;
        private System.Windows.Forms.CheckBox NumbersCB;
        private System.Windows.Forms.CheckBox LowercaseCB;
        private System.Windows.Forms.CheckBox UppercaseCB;
        private System.Windows.Forms.GroupBox CharactersLen;
        private System.Windows.Forms.TextBox CharLenTbCustom;
        private System.Windows.Forms.RadioButton CharLenRbCustom;
        private System.Windows.Forms.RadioButton CharLenRb16;
        private System.Windows.Forms.RadioButton CharLenRb8;
        private System.Windows.Forms.GroupBox CrePassCustom;
        private System.Windows.Forms.TextBox CrePassTbCustom;
        private System.Windows.Forms.RadioButton CrePassRbCustom;
        private System.Windows.Forms.RadioButton CrePassRb20;
        private System.Windows.Forms.RadioButton CrePassRb10;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

