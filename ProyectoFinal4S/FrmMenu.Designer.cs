
namespace ProyectoFinal4S.ProyectoFinal4S
{
    public partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && components is not null)
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            btnAPI = new System.Windows.Forms.Button();
            btnDataSet = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnAPI
            // 
            btnAPI.Font = new System.Drawing.Font("Yu Gothic", 11.25f);
            btnAPI.Location = new System.Drawing.Point(405, 116);
            btnAPI.Name = "btnAPI";
            btnAPI.Size = new System.Drawing.Size(124, 41);
            btnAPI.TabIndex = 0;
            btnAPI.Text = "NASA API";
            btnAPI.UseVisualStyleBackColor = true;
            btnAPI.Click += btnAPI_Click;
            // 
            // btnDataSet
            // 
            btnDataSet.Font = new System.Drawing.Font("Yu Gothic", 11.25f);
            btnDataSet.Location = new System.Drawing.Point(405, 183);
            btnDataSet.Name = "btnDataSet";
            btnDataSet.Size = new System.Drawing.Size(124, 36);
            btnDataSet.TabIndex = 1;
            btnDataSet.Text = "DATA SET";
            btnDataSet.UseVisualStyleBackColor = true;
            btnDataSet.Click += btnDataSet_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7f, 15f);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(822, 475);
            Controls.Add(btnDataSet);
            Controls.Add(btnAPI);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnAPI;
        private System.Windows.Forms.Button btnDataSet;
    }
}