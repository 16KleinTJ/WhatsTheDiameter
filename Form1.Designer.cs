namespace WhatsTheDiameter
{
    partial class Form1
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
            this.CircleInput = new System.Windows.Forms.TextBox();
            this.NewCircle = new System.Windows.Forms.Button();
            this.CircleCollection = new System.Windows.Forms.ListBox();
            this.SetRadius = new System.Windows.Forms.Button();
            this.ShowArray = new System.Windows.Forms.Button();
            this.circleData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CircleInput
            // 
            this.CircleInput.Location = new System.Drawing.Point(56, 43);
            this.CircleInput.Name = "CircleInput";
            this.CircleInput.Size = new System.Drawing.Size(347, 20);
            this.CircleInput.TabIndex = 0;
            // 
            // NewCircle
            // 
            this.NewCircle.Location = new System.Drawing.Point(457, 41);
            this.NewCircle.Name = "NewCircle";
            this.NewCircle.Size = new System.Drawing.Size(75, 23);
            this.NewCircle.TabIndex = 1;
            this.NewCircle.Text = "New circle";
            this.NewCircle.UseVisualStyleBackColor = true;
            this.NewCircle.Click += new System.EventHandler(this.NewCircle_Click);
            // 
            // CircleCollection
            // 
            this.CircleCollection.FormattingEnabled = true;
            this.CircleCollection.Location = new System.Drawing.Point(56, 93);
            this.CircleCollection.Name = "CircleCollection";
            this.CircleCollection.Size = new System.Drawing.Size(347, 277);
            this.CircleCollection.TabIndex = 2;
            this.CircleCollection.SelectedIndexChanged += new System.EventHandler(this.CircleCollection_SelectedIndexChanged);
            // 
            // SetRadius
            // 
            this.SetRadius.Location = new System.Drawing.Point(457, 93);
            this.SetRadius.Name = "SetRadius";
            this.SetRadius.Size = new System.Drawing.Size(75, 23);
            this.SetRadius.TabIndex = 3;
            this.SetRadius.Text = "Set Radius";
            this.SetRadius.UseVisualStyleBackColor = true;
            this.SetRadius.Click += new System.EventHandler(this.SetRadius_Click);
            // 
            // ShowArray
            // 
            this.ShowArray.Location = new System.Drawing.Point(457, 123);
            this.ShowArray.Name = "ShowArray";
            this.ShowArray.Size = new System.Drawing.Size(75, 23);
            this.ShowArray.TabIndex = 4;
            this.ShowArray.Text = "Show Array";
            this.ShowArray.UseVisualStyleBackColor = true;
            this.ShowArray.Click += new System.EventHandler(this.ShowArray_Click);
            // 
            // circleData
            // 
            this.circleData.AutoSize = true;
            this.circleData.Location = new System.Drawing.Point(457, 153);
            this.circleData.Name = "circleData";
            this.circleData.Size = new System.Drawing.Size(0, 13);
            this.circleData.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.circleData);
            this.Controls.Add(this.ShowArray);
            this.Controls.Add(this.SetRadius);
            this.Controls.Add(this.CircleCollection);
            this.Controls.Add(this.NewCircle);
            this.Controls.Add(this.CircleInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CircleInput;
        private System.Windows.Forms.Button NewCircle;
        private System.Windows.Forms.ListBox CircleCollection;
        private System.Windows.Forms.Button SetRadius;
        private System.Windows.Forms.Button ShowArray;
        private System.Windows.Forms.Label circleData;
    }
}

