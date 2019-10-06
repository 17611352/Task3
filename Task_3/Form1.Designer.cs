namespace Task_3
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
            this.components = new System.ComponentModel.Container();
            this.Start_Button = new System.Windows.Forms.Button();
            this.Display_Group_Box = new System.Windows.Forms.GroupBox();
            this.Test_Display_Label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Pause_Button = new System.Windows.Forms.Button();
            this.Save_Game_Button = new System.Windows.Forms.Button();
            this.Load_Save_Game = new System.Windows.Forms.Button();
            this.Unit_Info_Display_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.Num_Of_Rounds = new System.Windows.Forms.Label();
            this.Num_Of_Units_InGame = new System.Windows.Forms.Label();
            this.Buildings_In_Game = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Map_Size_X_Control = new System.Windows.Forms.NumericUpDown();
            this.Map_Size_Y_Control = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Map_Size_X_Control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map_Size_Y_Control)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_Button
            // 
            this.Start_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Button.Location = new System.Drawing.Point(668, 44);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(86, 36);
            this.Start_Button.TabIndex = 0;
            this.Start_Button.Text = "Start";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Display_Group_Box
            // 
            this.Display_Group_Box.Location = new System.Drawing.Point(97, 77);
            this.Display_Group_Box.Name = "Display_Group_Box";
            this.Display_Group_Box.Size = new System.Drawing.Size(548, 516);
            this.Display_Group_Box.TabIndex = 2;
            this.Display_Group_Box.TabStop = false;
            this.Display_Group_Box.Text = "BattleField";
            // 
            // Test_Display_Label
            // 
            this.Test_Display_Label.AutoSize = true;
            this.Test_Display_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test_Display_Label.Location = new System.Drawing.Point(12, 52);
            this.Test_Display_Label.Name = "Test_Display_Label";
            this.Test_Display_Label.Size = new System.Drawing.Size(53, 20);
            this.Test_Display_Label.TabIndex = 3;
            this.Test_Display_Label.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Pause_Button
            // 
            this.Pause_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause_Button.Location = new System.Drawing.Point(668, 86);
            this.Pause_Button.Name = "Pause_Button";
            this.Pause_Button.Size = new System.Drawing.Size(86, 36);
            this.Pause_Button.TabIndex = 4;
            this.Pause_Button.Text = "Pause";
            this.Pause_Button.UseVisualStyleBackColor = true;
            this.Pause_Button.Click += new System.EventHandler(this.Pause_Button_Click);
            // 
            // Save_Game_Button
            // 
            this.Save_Game_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Game_Button.Location = new System.Drawing.Point(816, 23);
            this.Save_Game_Button.Name = "Save_Game_Button";
            this.Save_Game_Button.Size = new System.Drawing.Size(86, 57);
            this.Save_Game_Button.TabIndex = 5;
            this.Save_Game_Button.Text = "Save Game";
            this.Save_Game_Button.UseVisualStyleBackColor = true;
            // 
            // Load_Save_Game
            // 
            this.Load_Save_Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_Save_Game.Location = new System.Drawing.Point(816, 86);
            this.Load_Save_Game.Name = "Load_Save_Game";
            this.Load_Save_Game.Size = new System.Drawing.Size(86, 70);
            this.Load_Save_Game.TabIndex = 6;
            this.Load_Save_Game.Text = "Load Save Game";
            this.Load_Save_Game.UseVisualStyleBackColor = true;
            // 
            // Unit_Info_Display_RichTextBox
            // 
            this.Unit_Info_Display_RichTextBox.Location = new System.Drawing.Point(672, 202);
            this.Unit_Info_Display_RichTextBox.Name = "Unit_Info_Display_RichTextBox";
            this.Unit_Info_Display_RichTextBox.Size = new System.Drawing.Size(230, 325);
            this.Unit_Info_Display_RichTextBox.TabIndex = 7;
            this.Unit_Info_Display_RichTextBox.Text = "";
            // 
            // Num_Of_Rounds
            // 
            this.Num_Of_Rounds.AutoSize = true;
            this.Num_Of_Rounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Of_Rounds.Location = new System.Drawing.Point(291, 9);
            this.Num_Of_Rounds.Name = "Num_Of_Rounds";
            this.Num_Of_Rounds.Size = new System.Drawing.Size(146, 25);
            this.Num_Of_Rounds.TabIndex = 8;
            this.Num_Of_Rounds.Text = "Num of Rounds";
            // 
            // Num_Of_Units_InGame
            // 
            this.Num_Of_Units_InGame.AutoSize = true;
            this.Num_Of_Units_InGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_Of_Units_InGame.Location = new System.Drawing.Point(92, 9);
            this.Num_Of_Units_InGame.Name = "Num_Of_Units_InGame";
            this.Num_Of_Units_InGame.Size = new System.Drawing.Size(150, 25);
            this.Num_Of_Units_InGame.TabIndex = 10;
            this.Num_Of_Units_InGame.Text = "Units in Game : ";
            // 
            // Buildings_In_Game
            // 
            this.Buildings_In_Game.AutoSize = true;
            this.Buildings_In_Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buildings_In_Game.Location = new System.Drawing.Point(465, 9);
            this.Buildings_In_Game.Name = "Buildings_In_Game";
            this.Buildings_In_Game.Size = new System.Drawing.Size(180, 25);
            this.Buildings_In_Game.TabIndex = 11;
            this.Buildings_In_Game.Text = "Buildings in Game :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(970, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Map Size X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(970, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Map Size Y";
            // 
            // Map_Size_X_Control
            // 
            this.Map_Size_X_Control.Location = new System.Drawing.Point(1086, 68);
            this.Map_Size_X_Control.Name = "Map_Size_X_Control";
            this.Map_Size_X_Control.Size = new System.Drawing.Size(79, 22);
            this.Map_Size_X_Control.TabIndex = 14;
            // 
            // Map_Size_Y_Control
            // 
            this.Map_Size_Y_Control.Location = new System.Drawing.Point(1086, 102);
            this.Map_Size_Y_Control.Name = "Map_Size_Y_Control";
            this.Map_Size_Y_Control.Size = new System.Drawing.Size(79, 22);
            this.Map_Size_Y_Control.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(942, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Map Size Constraints (5 > x < 100) :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 605);
            this.Controls.Add(this.Test_Display_Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Map_Size_Y_Control);
            this.Controls.Add(this.Map_Size_X_Control);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buildings_In_Game);
            this.Controls.Add(this.Num_Of_Units_InGame);
            this.Controls.Add(this.Num_Of_Rounds);
            this.Controls.Add(this.Unit_Info_Display_RichTextBox);
            this.Controls.Add(this.Load_Save_Game);
            this.Controls.Add(this.Save_Game_Button);
            this.Controls.Add(this.Pause_Button);
            this.Controls.Add(this.Display_Group_Box);
            this.Controls.Add(this.Start_Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Map_Size_X_Control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map_Size_Y_Control)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.GroupBox Display_Group_Box;
        private System.Windows.Forms.Label Test_Display_Label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Pause_Button;
        private System.Windows.Forms.Button Save_Game_Button;
        private System.Windows.Forms.Button Load_Save_Game;
        private System.Windows.Forms.RichTextBox Unit_Info_Display_RichTextBox;
        private System.Windows.Forms.Label Num_Of_Rounds;
        private System.Windows.Forms.Label Num_Of_Units_InGame;
        private System.Windows.Forms.Label Buildings_In_Game;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Map_Size_X_Control;
        private System.Windows.Forms.NumericUpDown Map_Size_Y_Control;
        private System.Windows.Forms.Label label3;
    }
}

