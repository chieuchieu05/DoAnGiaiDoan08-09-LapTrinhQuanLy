namespace QuanLyCuaHangTraSua.Forms
{
    partial class Hashfrm
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
            btnHash = new Button();
            SuspendLayout();
            // 
            // btnHash
            // 
            btnHash.Location = new Point(333, 133);
            btnHash.Name = "btnHash";
            btnHash.Size = new Size(94, 29);
            btnHash.TabIndex = 0;
            btnHash.Text = "hash";
            btnHash.UseVisualStyleBackColor = true;
            btnHash.Click += btnHash_Click;
            // 
            // Hashfrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHash);
            Name = "Hashfrm";
            Text = "Hashfrm";
            Load += Hashfrm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnHash;
    }
}