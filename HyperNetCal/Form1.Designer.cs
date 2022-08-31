namespace HyperNetCal
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
            this.tickets = new System.Windows.Forms.TextBox();
            this.cal = new System.Windows.Forms.Button();
            this.Ranking = new System.Windows.Forms.ListView();
            this.val = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tickets
            // 
            this.tickets.Location = new System.Drawing.Point(12, 12);
            this.tickets.Multiline = true;
            this.tickets.Name = "tickets";
            this.tickets.Size = new System.Drawing.Size(149, 402);
            this.tickets.TabIndex = 0;
            // 
            // cal
            // 
            this.cal.Location = new System.Drawing.Point(192, 199);
            this.cal.Name = "cal";
            this.cal.Size = new System.Drawing.Size(75, 23);
            this.cal.TabIndex = 2;
            this.cal.Text = "Cal";
            this.cal.UseVisualStyleBackColor = true;
            this.cal.Click += new System.EventHandler(this.cal_Click);
            // 
            // Ranking
            // 
            this.Ranking.Location = new System.Drawing.Point(306, 12);
            this.Ranking.Name = "Ranking";
            this.Ranking.Size = new System.Drawing.Size(140, 402);
            this.Ranking.TabIndex = 3;
            this.Ranking.UseCompatibleStateImageBehavior = false;
            this.Ranking.View = System.Windows.Forms.View.List;
            this.Ranking.SelectedIndexChanged += new System.EventHandler(this.Ranking_SelectedIndexChanged);
            // 
            // val
            // 
            this.val.AutoSize = true;
            this.val.Location = new System.Drawing.Point(306, 426);
            this.val.Name = "val";
            this.val.Size = new System.Drawing.Size(0, 15);
            this.val.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.val);
            this.Controls.Add(this.Ranking);
            this.Controls.Add(this.cal);
            this.Controls.Add(this.tickets);
            this.Name = "Form1";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tickets;
        private Button cal;
        private ListView Ranking;
        private Label val;
    }
}