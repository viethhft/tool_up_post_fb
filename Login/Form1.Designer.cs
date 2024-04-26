namespace Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Tool = new Button();
            btn_Done = new Button();
            SuspendLayout();
            // 
            // btn_Tool
            // 
            btn_Tool.Location = new Point(161, 98);
            btn_Tool.Name = "btn_Tool";
            btn_Tool.Size = new Size(150, 148);
            btn_Tool.TabIndex = 6;
            btn_Tool.Text = "Tool";
            btn_Tool.UseVisualStyleBackColor = true;
            btn_Tool.Click += btn_Tool_Click;
            // 
            // btn_Done
            // 
            btn_Done.Location = new Point(480, 98);
            btn_Done.Name = "btn_Done";
            btn_Done.Size = new Size(150, 148);
            btn_Done.TabIndex = 7;
            btn_Done.Text = "Done";
            btn_Done.UseVisualStyleBackColor = true;
            btn_Done.Click += btn_Done_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 372);
            Controls.Add(btn_Done);
            Controls.Add(btn_Tool);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ResumeLayout(false);
        }

        #endregion
        private Button btn_Tool;
        private Button btn_Done;
    }
}
