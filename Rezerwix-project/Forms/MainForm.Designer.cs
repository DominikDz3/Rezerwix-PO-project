namespace Rezerwix_project.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelView;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelView = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelView
            // 
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1024, 700);
            this.panelView.TabIndex = 0;
            //
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 700);
            this.Controls.Add(this.panelView);
            this.Name = "MainForm";
            this.Text = "Rezerwix";
            this.ResumeLayout(false);
        }
    }
}
