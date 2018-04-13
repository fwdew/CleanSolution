namespace CleanSolution
{
   partial class CleanForm
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
         if (disposing && (components != null)) {
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
         this.buttonClean = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // buttonClean
         // 
         this.buttonClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.buttonClean.Location = new System.Drawing.Point(31, 12);
         this.buttonClean.Name = "buttonClean";
         this.buttonClean.Size = new System.Drawing.Size(210, 61);
         this.buttonClean.TabIndex = 0;
         this.buttonClean.Text = "Clean";
         this.buttonClean.UseVisualStyleBackColor = true;
         this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
         // 
         // CleanForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(271, 87);
         this.Controls.Add(this.buttonClean);
         this.Name = "CleanForm";
         this.Text = "Clean Solution";
         this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.Button buttonClean;
   }
}

