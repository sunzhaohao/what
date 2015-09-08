namespace Lists
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxSelected = new System.Windows.Forms.ListBox();
            this.checkedListBoxPossibleValue = new System.Windows.Forms.CheckedListBox();
            this.buttonMove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSelected
            // 
            this.listBoxSelected.FormattingEnabled = true;
            this.listBoxSelected.ItemHeight = 12;
            this.listBoxSelected.Location = new System.Drawing.Point(325, 22);
            this.listBoxSelected.Name = "listBoxSelected";
            this.listBoxSelected.Size = new System.Drawing.Size(197, 292);
            this.listBoxSelected.TabIndex = 0;
            // 
            // checkedListBoxPossibleValue
            // 
            this.checkedListBoxPossibleValue.CheckOnClick = true;
            this.checkedListBoxPossibleValue.FormattingEnabled = true;
            this.checkedListBoxPossibleValue.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine"});
            this.checkedListBoxPossibleValue.Location = new System.Drawing.Point(12, 22);
            this.checkedListBoxPossibleValue.Name = "checkedListBoxPossibleValue";
            this.checkedListBoxPossibleValue.Size = new System.Drawing.Size(193, 292);
            this.checkedListBoxPossibleValue.TabIndex = 1;
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(229, 153);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(75, 23);
            this.buttonMove.TabIndex = 2;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 326);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.checkedListBoxPossibleValue);
            this.Controls.Add(this.listBoxSelected);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSelected;
        private System.Windows.Forms.CheckedListBox checkedListBoxPossibleValue;
        private System.Windows.Forms.Button buttonMove;
    }
}

