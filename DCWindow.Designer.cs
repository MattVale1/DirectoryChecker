namespace DirectoryChecker {
    partial class DCWindow {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            Btn_SelectFolders = new Button();
            Btn_CalculateSize = new Button();
            Label_Results = new Label();
            SuspendLayout();
            // 
            // Btn_SelectFolders
            // 
            Btn_SelectFolders.Location = new Point(12, 12);
            Btn_SelectFolders.Name = "Btn_SelectFolders";
            Btn_SelectFolders.Size = new Size(139, 23);
            Btn_SelectFolders.TabIndex = 0;
            Btn_SelectFolders.Text = "Select Folders";
            Btn_SelectFolders.UseVisualStyleBackColor = true;
            Btn_SelectFolders.Click += Btn_SelectFolders_Click;
            // 
            // Btn_CalculateSize
            // 
            Btn_CalculateSize.Location = new Point(157, 12);
            Btn_CalculateSize.Name = "Btn_CalculateSize";
            Btn_CalculateSize.Size = new Size(145, 23);
            Btn_CalculateSize.TabIndex = 1;
            Btn_CalculateSize.Text = "Calculate";
            Btn_CalculateSize.UseVisualStyleBackColor = true;
            Btn_CalculateSize.Click += Btn_CalculateSize_Click;
            // 
            // Label_Results
            // 
            Label_Results.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label_Results.ForeColor = Color.White;
            Label_Results.Location = new Point(12, 38);
            Label_Results.Name = "Label_Results";
            Label_Results.Size = new Size(776, 403);
            Label_Results.TabIndex = 2;
            Label_Results.Text = "FOLDER_PATH: 129563 bytes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 21, 21);
            ClientSize = new Size(800, 450);
            Controls.Add(Label_Results);
            Controls.Add(Btn_CalculateSize);
            Controls.Add(Btn_SelectFolders);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_SelectFolders;
        private Button Btn_CalculateSize;
        private Label Label_Results;
    }
}