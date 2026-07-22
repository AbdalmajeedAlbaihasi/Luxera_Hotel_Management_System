namespace HMSDesktop.User_Control
{
    partial class ucRoomTimeline
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewTimeline = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTimeline).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTimeline
            // 
            dataGridViewTimeline.AllowUserToAddRows = false;
            dataGridViewTimeline.AllowUserToDeleteRows = false;
            dataGridViewTimeline.BackgroundColor = Color.White;
            dataGridViewTimeline.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTimeline.Dock = DockStyle.Fill;
            dataGridViewTimeline.GridColor = Color.Turquoise;
            dataGridViewTimeline.Location = new Point(0, 0);
            dataGridViewTimeline.Name = "dataGridViewTimeline";
            dataGridViewTimeline.ReadOnly = true;
            dataGridViewTimeline.Size = new Size(915, 502);
            dataGridViewTimeline.TabIndex = 0;
            dataGridViewTimeline.CellClick += dataGridViewTimeline_CellClick;
            dataGridViewTimeline.CellContentClick += dataGridViewTimeline_CellContentClick;
            // 
            // ucRoomTimeline
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(dataGridViewTimeline);
            Name = "ucRoomTimeline";
            Size = new Size(915, 502);
            Load += ucRoomTimeline_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTimeline).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewTimeline;
    }
}
