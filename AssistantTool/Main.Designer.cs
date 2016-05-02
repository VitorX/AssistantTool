namespace AssistantTool
{
    partial class Main
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
            this.btnHide = new System.Windows.Forms.Button();
            this.txtWindowHandler = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAutoRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(181, 43);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(90, 23);
            this.btnHide.TabIndex = 0;
            this.btnHide.Text = "Hide/Show";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // txtWindowHandler
            // 
            this.txtWindowHandler.Location = new System.Drawing.Point(66, 44);
            this.txtWindowHandler.Name = "txtWindowHandler";
            this.txtWindowHandler.Size = new System.Drawing.Size(100, 21);
            this.txtWindowHandler.TabIndex = 1;
            this.txtWindowHandler.Text = "657702";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Handler:";
            // 
            // btnAutoRun
            // 
            this.btnAutoRun.Location = new System.Drawing.Point(40, 104);
            this.btnAutoRun.Name = "btnAutoRun";
            this.btnAutoRun.Size = new System.Drawing.Size(75, 23);
            this.btnAutoRun.TabIndex = 3;
            this.btnAutoRun.Text = "AutoRun";
            this.btnAutoRun.UseVisualStyleBackColor = true;
            this.btnAutoRun.Click += new System.EventHandler(this.btnAutoRun_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 262);
            this.Controls.Add(this.btnAutoRun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWindowHandler);
            this.Controls.Add(this.btnHide);
            this.Name = "Main";
            this.Text = "AssistantTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.TextBox txtWindowHandler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAutoRun;
    }
}

