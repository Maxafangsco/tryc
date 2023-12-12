namespace ExamPrep
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
            this.list_number_plate = new System.Windows.Forms.ListBox();
            this.generate_car = new System.Windows.Forms.Button();
            this.delete_car_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.add_new_car = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // list_number_plate
            // 
            this.list_number_plate.FormattingEnabled = true;
            this.list_number_plate.ItemHeight = 20;
            this.list_number_plate.Location = new System.Drawing.Point(107, 34);
            this.list_number_plate.Name = "list_number_plate";
            this.list_number_plate.Size = new System.Drawing.Size(364, 224);
            this.list_number_plate.TabIndex = 0;
            this.list_number_plate.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // generate_car
            // 
            this.generate_car.Location = new System.Drawing.Point(107, 319);
            this.generate_car.Name = "generate_car";
            this.generate_car.Size = new System.Drawing.Size(147, 47);
            this.generate_car.TabIndex = 1;
            this.generate_car.Text = "Generate Cars";
            this.generate_car.UseVisualStyleBackColor = true;
            this.generate_car.Click += new System.EventHandler(this.generate_car_Click);
            // 
            // delete_car_button
            // 
            this.delete_car_button.Location = new System.Drawing.Point(277, 319);
            this.delete_car_button.Name = "delete_car_button";
            this.delete_car_button.Size = new System.Drawing.Size(141, 47);
            this.delete_car_button.TabIndex = 2;
            this.delete_car_button.Text = "Delete car";
            this.delete_car_button.UseVisualStyleBackColor = true;
            this.delete_car_button.Click += new System.EventHandler(this.delete_car_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(547, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 26);
            this.textBox1.TabIndex = 3;
        
            // 
            // add_new_car
            // 
            this.add_new_car.Location = new System.Drawing.Point(547, 314);
            this.add_new_car.Name = "add_new_car";
            this.add_new_car.Size = new System.Drawing.Size(196, 56);
            this.add_new_car.TabIndex = 4;
            this.add_new_car.Text = "Add New Car";
            this.add_new_car.UseVisualStyleBackColor = true;
            this.add_new_car.Click += new System.EventHandler(this.add_new_car_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(547, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(241, 26);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(547, 136);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(241, 26);
            this.textBox3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.add_new_car);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.delete_car_button);
            this.Controls.Add(this.generate_car);
            this.Controls.Add(this.list_number_plate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_number_plate;
        private System.Windows.Forms.Button generate_car;
        private System.Windows.Forms.Button delete_car_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button add_new_car;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

