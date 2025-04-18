namespace DemandForecast // ← Исправил!
{
    partial class ForecastForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ForecastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ForecastForm";
            this.Text = "ForecastForm";
            this.Load += new System.EventHandler(this.ForecastForm_Load);
            this.ResumeLayout(false);
        }
    }
}
