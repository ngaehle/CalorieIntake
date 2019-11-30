namespace CalorieIntake
{
    partial class CalorieIntake
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
            this.Title = new System.Windows.Forms.Label();
            this.ItemName = new System.Windows.Forms.Label();
            this.Fat = new System.Windows.Forms.Label();
            this.Carbs = new System.Windows.Forms.Label();
            this.Protein = new System.Windows.Forms.Label();
            this.Fiber = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.carbInput = new System.Windows.Forms.TextBox();
            this.proteinInput = new System.Windows.Forms.TextBox();
            this.fiberInput = new System.Windows.Forms.TextBox();
            this.fatInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataEntry = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(523, 24);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(294, 42);
            this.Title.TabIndex = 0;
            this.Title.Text = "Calorie Counter";
            // 
            // ItemName
            // 
            this.ItemName.AutoSize = true;
            this.ItemName.Location = new System.Drawing.Point(162, 177);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(166, 33);
            this.ItemName.TabIndex = 1;
            this.ItemName.Text = "Item Name:";
            // 
            // Fat
            // 
            this.Fat.AutoSize = true;
            this.Fat.Location = new System.Drawing.Point(501, 249);
            this.Fat.Name = "Fat";
            this.Fat.Size = new System.Drawing.Size(138, 33);
            this.Fat.TabIndex = 2;
            this.Fat.Text = "Total Fat:";
            // 
            // Carbs
            // 
            this.Carbs.AutoSize = true;
            this.Carbs.Location = new System.Drawing.Point(352, 314);
            this.Carbs.Name = "Carbs";
            this.Carbs.Size = new System.Drawing.Size(287, 33);
            this.Carbs.TabIndex = 3;
            this.Carbs.Text = "Total Carbohydrates:";
            // 
            // Protein
            // 
            this.Protein.AutoSize = true;
            this.Protein.Location = new System.Drawing.Point(524, 374);
            this.Protein.Name = "Protein";
            this.Protein.Size = new System.Drawing.Size(115, 33);
            this.Protein.TabIndex = 4;
            this.Protein.Text = "Protein:";
            // 
            // Fiber
            // 
            this.Fiber.AutoSize = true;
            this.Fiber.Location = new System.Drawing.Point(549, 432);
            this.Fiber.Name = "Fiber";
            this.Fiber.Size = new System.Drawing.Size(90, 33);
            this.Fiber.TabIndex = 5;
            this.Fiber.Text = "Fiber:";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(334, 174);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(544, 40);
            this.nameInput.TabIndex = 6;
            // 
            // carbInput
            // 
            this.carbInput.Location = new System.Drawing.Point(664, 311);
            this.carbInput.Name = "carbInput";
            this.carbInput.Size = new System.Drawing.Size(214, 40);
            this.carbInput.TabIndex = 7;
            // 
            // proteinInput
            // 
            this.proteinInput.Location = new System.Drawing.Point(664, 374);
            this.proteinInput.Name = "proteinInput";
            this.proteinInput.Size = new System.Drawing.Size(214, 40);
            this.proteinInput.TabIndex = 8;
            // 
            // fiberInput
            // 
            this.fiberInput.Location = new System.Drawing.Point(664, 432);
            this.fiberInput.Name = "fiberInput";
            this.fiberInput.Size = new System.Drawing.Size(214, 40);
            this.fiberInput.TabIndex = 9;
            // 
            // fatInput
            // 
            this.fatInput.Location = new System.Drawing.Point(664, 246);
            this.fatInput.Name = "fatInput";
            this.fatInput.Size = new System.Drawing.Size(214, 40);
            this.fatInput.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(715, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(829, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(504, 40);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dataEntry
            // 
            this.dataEntry.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.dataEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataEntry.Location = new System.Drawing.Point(676, 512);
            this.dataEntry.Name = "dataEntry";
            this.dataEntry.Size = new System.Drawing.Size(183, 65);
            this.dataEntry.TabIndex = 13;
            this.dataEntry.Text = "Enter Data";
            this.dataEntry.UseVisualStyleBackColor = false;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(969, 600);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(183, 65);
            this.Close.TabIndex = 14;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(389, 600);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(183, 65);
            this.clear.TabIndex = 15;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // CalorieIntake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1385, 693);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.dataEntry);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fatInput);
            this.Controls.Add(this.fiberInput);
            this.Controls.Add(this.proteinInput);
            this.Controls.Add(this.carbInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.Fiber);
            this.Controls.Add(this.Protein);
            this.Controls.Add(this.Carbs);
            this.Controls.Add(this.Fat);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CalorieIntake";
            this.Text = "Calorie Intake";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label ItemName;
        private System.Windows.Forms.Label Fat;
        private System.Windows.Forms.Label Carbs;
        private System.Windows.Forms.Label Protein;
        private System.Windows.Forms.Label Fiber;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox carbInput;
        private System.Windows.Forms.TextBox proteinInput;
        private System.Windows.Forms.TextBox fiberInput;
        private System.Windows.Forms.TextBox fatInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button dataEntry;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button clear;
    }
}

