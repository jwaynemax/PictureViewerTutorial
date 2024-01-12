namespace PictureViewer
{
    partial class pictureForm
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
            tabelLayoutPanel = new TableLayoutPanel();
            pictureBox = new PictureBox();
            stretchCheckBox = new CheckBox();
            flowLayoutPanel = new FlowLayoutPanel();
            showButton = new Button();
            clearButton = new Button();
            backgroundButton = new Button();
            closeButton = new Button();
            openFileDialog = new OpenFileDialog();
            colorDialog = new ColorDialog();
            tabelLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            flowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tabelLayoutPanel
            // 
            tabelLayoutPanel.ColumnCount = 2;
            tabelLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tabelLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tabelLayoutPanel.Controls.Add(pictureBox, 0, 0);
            tabelLayoutPanel.Controls.Add(stretchCheckBox, 0, 1);
            tabelLayoutPanel.Controls.Add(flowLayoutPanel, 1, 1);
            tabelLayoutPanel.Dock = DockStyle.Fill;
            tabelLayoutPanel.Location = new Point(0, 0);
            tabelLayoutPanel.Name = "tabelLayoutPanel";
            tabelLayoutPanel.RowCount = 2;
            tabelLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tabelLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tabelLayoutPanel.Size = new Size(869, 607);
            tabelLayoutPanel.TabIndex = 0;
            tabelLayoutPanel.Paint += tableLayoutPanel_Paint;
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            tabelLayoutPanel.SetColumnSpan(pictureBox, 2);
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(863, 540);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            // 
            // stretchCheckBox
            // 
            stretchCheckBox.AutoSize = true;
            stretchCheckBox.Location = new Point(3, 549);
            stretchCheckBox.Name = "stretchCheckBox";
            stretchCheckBox.Size = new Size(63, 19);
            stretchCheckBox.TabIndex = 1;
            stretchCheckBox.Text = "Stretch";
            stretchCheckBox.UseVisualStyleBackColor = true;
            stretchCheckBox.CheckedChanged += stretchCheckBox_CheckedChanged;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.Controls.Add(showButton);
            flowLayoutPanel.Controls.Add(clearButton);
            flowLayoutPanel.Controls.Add(backgroundButton);
            flowLayoutPanel.Controls.Add(closeButton);
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel.Location = new Point(133, 549);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(733, 55);
            flowLayoutPanel.TabIndex = 2;
            // 
            // showButton
            // 
            showButton.AutoSize = true;
            showButton.Location = new Point(635, 3);
            showButton.Name = "showButton";
            showButton.Size = new Size(95, 25);
            showButton.TabIndex = 0;
            showButton.Text = "Show a picture";
            showButton.UseVisualStyleBackColor = true;
            showButton.Click += showButton_Click;
            // 
            // clearButton
            // 
            clearButton.AutoSize = true;
            clearButton.Location = new Point(525, 3);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(104, 25);
            clearButton.TabIndex = 1;
            clearButton.Text = "Clear the picture";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // backgroundButton
            // 
            backgroundButton.AutoSize = true;
            backgroundButton.Location = new Point(369, 3);
            backgroundButton.Name = "backgroundButton";
            backgroundButton.Size = new Size(150, 25);
            backgroundButton.TabIndex = 2;
            backgroundButton.Text = "Set the background color";
            backgroundButton.UseVisualStyleBackColor = true;
            backgroundButton.Click += backgroundButton_Click;
            // 
            // closeButton
            // 
            closeButton.AutoSize = true;
            closeButton.Location = new Point(288, 3);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 25);
            closeButton.TabIndex = 3;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            openFileDialog.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
            openFileDialog.Title = "Select a picture file";
            openFileDialog.FileOk += openFileDialog1_FileOk;
            // 
            // pictureForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 607);
            Controls.Add(tabelLayoutPanel);
            Name = "pictureForm";
            Text = "Picture Viewer";
            Load += pictureForm_Load;
            tabelLayoutPanel.ResumeLayout(false);
            tabelLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tabelLayoutPanel;
        private PictureBox pictureBox;
        private CheckBox stretchCheckBox;
        private FlowLayoutPanel flowLayoutPanel;
        private Button showButton;
        private Button clearButton;
        private Button backgroundButton;
        private Button closeButton;
        private OpenFileDialog openFileDialog;
        private ColorDialog colorDialog;
    }
}
