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
            this.Title.Location = new System.Drawing.Point(247, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(156, 24);
            this.Title.TabIndex = 0;
            this.Title.Text = "Calorie Counter";
            // 
            // ItemName
            // 
            this.ItemName.AutoSize = true;
            this.ItemName.Location = new System.Drawing.Point(46, 135);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(84, 18);
            this.ItemName.TabIndex = 1;
            this.ItemName.Text = "Item Name:";
            // 
            // Fat
            // 
            this.Fat.AutoSize = true;
            this.Fat.Location = new System.Drawing.Point(222, 187);
            this.Fat.Name = "Fat";
            this.Fat.Size = new System.Drawing.Size(70, 18);
            this.Fat.TabIndex = 2;
            this.Fat.Text = "Total Fat:";
            // 
            // Carbs
            // 
            this.Carbs.AutoSize = true;
            this.Carbs.Location = new System.Drawing.Point(146, 233);
            this.Carbs.Name = "Carbs";
            this.Carbs.Size = new System.Drawing.Size(146, 18);
            this.Carbs.TabIndex = 3;
            this.Carbs.Text = "Total Carbohydrates:";
            // 
            // Protein
            // 
            this.Protein.AutoSize = true;
            this.Protein.Location = new System.Drawing.Point(233, 277);
            this.Protein.Name = "Protein";
            this.Protein.Size = new System.Drawing.Size(59, 18);
            this.Protein.TabIndex = 4;
            this.Protein.Text = "Protein:";
            // 
            // Fiber
            // 
            this.Fiber.AutoSize = true;
            this.Fiber.Location = new System.Drawing.Point(146, 318);
            this.Fiber.Name = "Fiber";
            this.Fiber.Size = new System.Drawing.Size(151, 18);
            this.Fiber.TabIndex = 5;
            this.Fiber.Text = "Serving per container:";
            this.Fiber.Click += new System.EventHandler(this.Fiber_Click);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(136, 135);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(204, 24);
            this.nameInput.TabIndex = 6;
            this.nameInput.TextChanged += new System.EventHandler(this.nameInput_TextChanged);
            this.nameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameInput_KeyPress);
            // 
            // carbInput
            // 
            this.carbInput.Location = new System.Drawing.Point(315, 230);
            this.carbInput.Name = "carbInput";
            this.carbInput.Size = new System.Drawing.Size(214, 24);
            this.carbInput.TabIndex = 7;
            this.carbInput.TextChanged += new System.EventHandler(this.carbInput_TextChanged);
            this.carbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.carbInput_KeyPress);
            // 
            // proteinInput
            // 
            this.proteinInput.Location = new System.Drawing.Point(315, 277);
            this.proteinInput.Name = "proteinInput";
            this.proteinInput.Size = new System.Drawing.Size(214, 24);
            this.proteinInput.TabIndex = 8;
            this.proteinInput.TextChanged += new System.EventHandler(this.proteinInput_TextChanged);
            this.proteinInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.proteinInput_KeyPress);
            // 
            // fiberInput
            // 
            this.fiberInput.Location = new System.Drawing.Point(315, 318);
            this.fiberInput.Name = "fiberInput";
            this.fiberInput.Size = new System.Drawing.Size(214, 24);
            this.fiberInput.TabIndex = 9;
            this.fiberInput.TextChanged += new System.EventHandler(this.fiberInput_TextChanged);
            // 
            // fatInput
            // 
            this.fatInput.Location = new System.Drawing.Point(315, 184);
            this.fatInput.Name = "fatInput";
            this.fatInput.Size = new System.Drawing.Size(214, 24);
            this.fatInput.TabIndex = 10;
            this.fatInput.TextChanged += new System.EventHandler(this.fatInput_TextChanged);
            this.fatInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fatInput_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(195, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(334, 24);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dataEntry
            // 
            this.dataEntry.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.dataEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataEntry.Location = new System.Drawing.Point(268, 382);
            this.dataEntry.Name = "dataEntry";
            this.dataEntry.Size = new System.Drawing.Size(135, 43);
            this.dataEntry.TabIndex = 13;
            this.dataEntry.Text = "Enter Data";
            this.dataEntry.UseVisualStyleBackColor = false;
            this.dataEntry.Click += new System.EventHandler(this.dataEntry_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(488, 447);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(118, 39);
            this.Close.TabIndex = 14;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(75, 447);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(114, 41);
            this.clear.TabIndex = 15;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // CalorieIntake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(656, 500);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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

