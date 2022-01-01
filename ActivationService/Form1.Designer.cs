
namespace ActivationService
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
            this.button1 = new System.Windows.Forms.Button();
            this.key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitKey = new System.Windows.Forms.Button();
            this.keyNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.keyNum)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Unique Keys";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(31, 73);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(212, 20);
            this.key.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(67, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Validate your keys";
            // 
            // submitKey
            // 
            this.submitKey.Location = new System.Drawing.Point(31, 115);
            this.submitKey.Name = "submitKey";
            this.submitKey.Size = new System.Drawing.Size(212, 23);
            this.submitKey.TabIndex = 3;
            this.submitKey.Text = "Validate";
            this.submitKey.UseVisualStyleBackColor = true;
            this.submitKey.Click += new System.EventHandler(this.submitKey_Click);
            // 
            // keyNum
            // 
            this.keyNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.keyNum.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.keyNum.Location = new System.Drawing.Point(99, 192);
            this.keyNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.keyNum.Name = "keyNum";
            this.keyNum.Size = new System.Drawing.Size(75, 29);
            this.keyNum.TabIndex = 4;
            this.keyNum.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "How many Keys to generate?";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "Regenerate Config";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 337);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keyNum);
            this.Controls.Add(this.submitKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.key);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Activation Service GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.keyNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitKey;
        private System.Windows.Forms.NumericUpDown keyNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}

