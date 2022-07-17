
namespace EmployeeWF
{
    partial class Insert
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
            this.tb_fn = new System.Windows.Forms.TextBox();
            this.tb_ln = new System.Windows.Forms.TextBox();
            this.pos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bd = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_fn
            // 
            this.tb_fn.Location = new System.Drawing.Point(294, 151);
            this.tb_fn.Name = "tb_fn";
            this.tb_fn.Size = new System.Drawing.Size(248, 20);
            this.tb_fn.TabIndex = 0;
            // 
            // tb_ln
            // 
            this.tb_ln.Location = new System.Drawing.Point(294, 177);
            this.tb_ln.Name = "tb_ln";
            this.tb_ln.Size = new System.Drawing.Size(248, 20);
            this.tb_ln.TabIndex = 1;
            // 
            // pos
            // 
            this.pos.FormattingEnabled = true;
            this.pos.Location = new System.Drawing.Point(294, 203);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(248, 21);
            this.pos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Position";
            // 
            // bd
            // 
            this.bd.Location = new System.Drawing.Point(294, 230);
            this.bd.Mask = "0000-00-00";
            this.bd.Name = "bd";
            this.bd.Size = new System.Drawing.Size(65, 20);
            this.bd.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Birth Date";
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(403, 228);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(75, 23);
            this.done.TabIndex = 8;
            this.done.Text = "Confirm";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.done);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pos);
            this.Controls.Add(this.tb_ln);
            this.Controls.Add(this.tb_fn);
            this.Name = "Insert";
            this.Text = "Insert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_fn;
        private System.Windows.Forms.TextBox tb_ln;
        private System.Windows.Forms.ComboBox pos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox bd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button done;
    }
}