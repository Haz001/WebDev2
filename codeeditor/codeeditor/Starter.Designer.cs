namespace WebDev2
{
    partial class Starter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FE_btn = new System.Windows.Forms.Button();
            this.SE_btn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.HB_btn = new System.Windows.Forms.Button();
            this.S_btn = new System.Windows.Forms.Button();
            this.dragndroparea = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dragndroparea.SuspendLayout();
            this.SuspendLayout();
            // 
            // FE_btn
            // 
            this.FE_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FE_btn.Location = new System.Drawing.Point(0, 0);
            this.FE_btn.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.FE_btn.Name = "FE_btn";
            this.FE_btn.Size = new System.Drawing.Size(150, 50);
            this.FE_btn.TabIndex = 0;
            this.FE_btn.Text = "Full Edit";
            this.toolTip1.SetToolTip(this.FE_btn, "Edit the file fully");
            this.FE_btn.UseVisualStyleBackColor = true;
            this.FE_btn.Click += new System.EventHandler(this.FE_btn_Click);
            // 
            // SE_btn
            // 
            this.SE_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SE_btn.Location = new System.Drawing.Point(0, 50);
            this.SE_btn.Margin = new System.Windows.Forms.Padding(0);
            this.SE_btn.Name = "SE_btn";
            this.SE_btn.Size = new System.Drawing.Size(150, 50);
            this.SE_btn.TabIndex = 0;
            this.SE_btn.Text = "Section Edit";
            this.toolTip1.SetToolTip(this.SE_btn, "Edit the file in sections");
            this.SE_btn.UseVisualStyleBackColor = true;
            this.SE_btn.UseWaitCursor = true;
            // 
            // HB_btn
            // 
            this.HB_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HB_btn.Location = new System.Drawing.Point(0, 100);
            this.HB_btn.Margin = new System.Windows.Forms.Padding(0);
            this.HB_btn.Name = "HB_btn";
            this.HB_btn.Size = new System.Drawing.Size(150, 50);
            this.HB_btn.TabIndex = 0;
            this.HB_btn.Text = "Builder";
            this.toolTip1.SetToolTip(this.HB_btn, "Bad html builder");
            this.HB_btn.UseVisualStyleBackColor = true;
            this.HB_btn.UseWaitCursor = true;
            // 
            // S_btn
            // 
            this.S_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.S_btn.Location = new System.Drawing.Point(0, 150);
            this.S_btn.Margin = new System.Windows.Forms.Padding(0);
            this.S_btn.Name = "S_btn";
            this.S_btn.Size = new System.Drawing.Size(150, 50);
            this.S_btn.TabIndex = 0;
            this.S_btn.Text = "Settings";
            this.S_btn.UseVisualStyleBackColor = true;
            this.S_btn.UseWaitCursor = true;
            // 
            // dragndroparea
            // 
            this.dragndroparea.AllowDrop = true;
            this.dragndroparea.BackColor = System.Drawing.Color.DimGray;
            this.dragndroparea.Controls.Add(this.label1);
            this.dragndroparea.Location = new System.Drawing.Point(155, 25);
            this.dragndroparea.Name = "dragndroparea";
            this.dragndroparea.Size = new System.Drawing.Size(240, 170);
            this.dragndroparea.TabIndex = 1;
            this.dragndroparea.DragDrop += new System.Windows.Forms.DragEventHandler(this._DragDrop);
            this.dragndroparea.DragEnter += new System.Windows.Forms.DragEventHandler(this._DragEnter);
            this.dragndroparea.DragOver += new System.Windows.Forms.DragEventHandler(this._DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drag \'n\' Drop (working progress)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(155, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "WebDev2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(340, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.toolTip1.SetToolTip(this.button1, "Edit the file fully");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.close_clicked);
            // 
            // Starter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dragndroparea);
            this.Controls.Add(this.S_btn);
            this.Controls.Add(this.HB_btn);
            this.Controls.Add(this.SE_btn);
            this.Controls.Add(this.FE_btn);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Starter";
            this.Text = "Starter";
            this.Load += new System.EventHandler(this.Starter_Load);
            this.dragndroparea.ResumeLayout(false);
            this.dragndroparea.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FE_btn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button SE_btn;
        private System.Windows.Forms.Button HB_btn;
        private System.Windows.Forms.Button S_btn;
        private System.Windows.Forms.FlowLayoutPanel dragndroparea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}