namespace Dnd_Character_Creator {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.Start_Screen = new System.Windows.Forms.Panel();
			this.StartTitle = new System.Windows.Forms.Label();
			this.UserName = new System.Windows.Forms.Label();
			this.PlayerName = new System.Windows.Forms.TextBox();
			this.WhatToDoText = new System.Windows.Forms.Label();
			this.WhatToDo = new System.Windows.Forms.CheckedListBox();
			this.TitleButton = new System.Windows.Forms.Button();
			this.TitleNextBtn = new System.Windows.Forms.Button();
			this.RaceBtn = new System.Windows.Forms.Button();
			this.ClassBtn = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.RaceScreen = new System.Windows.Forms.Panel();
			this.button6 = new System.Windows.Forms.Button();
			this.RaceDetails = new System.Windows.Forms.TextBox();
			this.RacePic = new System.Windows.Forms.PictureBox();
			this.SubRaceBenefits = new System.Windows.Forms.Label();
			this.SubRaceBenefitsText = new System.Windows.Forms.Label();
			this.RaceBenefits = new System.Windows.Forms.Label();
			this.SubRaces = new System.Windows.Forms.CheckedListBox();
			this.RaceBenefitText = new System.Windows.Forms.Label();
			this.RaceText = new System.Windows.Forms.Label();
			this.Races = new System.Windows.Forms.CheckedListBox();
			this.RaceTitle = new System.Windows.Forms.Label();
			this.RaceScreen.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RacePic)).BeginInit();
			this.SuspendLayout();
			// 
			// Start_Screen
			// 
			this.Start_Screen.Location = new System.Drawing.Point(11, 12);
			this.Start_Screen.Name = "Start_Screen";
			this.Start_Screen.Size = new System.Drawing.Size(776, 319);
			this.Start_Screen.TabIndex = 0;
			// 
			// StartTitle
			// 
			this.StartTitle.AutoSize = true;
			this.StartTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StartTitle.Location = new System.Drawing.Point(261, 8);
			this.StartTitle.Name = "StartTitle";
			this.StartTitle.Size = new System.Drawing.Size(203, 29);
			this.StartTitle.TabIndex = 0;
			this.StartTitle.Text = "Character Creator";
			// 
			// UserName
			// 
			this.UserName.AutoSize = true;
			this.UserName.Location = new System.Drawing.Point(15, 59);
			this.UserName.Name = "UserName";
			this.UserName.Size = new System.Drawing.Size(101, 13);
			this.UserName.TabIndex = 1;
			this.UserName.Text = "What is your name?";
			// 
			// PlayerName
			// 
			this.PlayerName.Location = new System.Drawing.Point(122, 59);
			this.PlayerName.MaxLength = 20;
			this.PlayerName.Name = "PlayerName";
			this.PlayerName.Size = new System.Drawing.Size(124, 20);
			this.PlayerName.TabIndex = 3;
			this.PlayerName.Text = "Your name";
			this.PlayerName.WordWrap = false;
			// 
			// WhatToDoText
			// 
			this.WhatToDoText.AutoSize = true;
			this.WhatToDoText.Location = new System.Drawing.Point(18, 92);
			this.WhatToDoText.Name = "WhatToDoText";
			this.WhatToDoText.Size = new System.Drawing.Size(85, 13);
			this.WhatToDoText.TabIndex = 4;
			this.WhatToDoText.Text = "What to do first?";
			// 
			// WhatToDo
			// 
			this.WhatToDo.CheckOnClick = true;
			this.WhatToDo.FormattingEnabled = true;
			this.WhatToDo.Items.AddRange(new object[] {
            "Choose a Race",
            "Chose a Class",
            "Determine Ability Scores",
            "Describe your character",
            "Choose Equipment"});
			this.WhatToDo.Location = new System.Drawing.Point(21, 109);
			this.WhatToDo.Name = "WhatToDo";
			this.WhatToDo.Size = new System.Drawing.Size(139, 79);
			this.WhatToDo.TabIndex = 5;
			this.WhatToDo.ThreeDCheckBoxes = true;
			this.WhatToDo.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.WhatToDo_ItemCheck);
			// 
			// TitleButton
			// 
			this.TitleButton.Location = new System.Drawing.Point(11, 338);
			this.TitleButton.Name = "TitleButton";
			this.TitleButton.Size = new System.Drawing.Size(75, 45);
			this.TitleButton.TabIndex = 1;
			this.TitleButton.Text = "Title";
			this.TitleButton.UseVisualStyleBackColor = true;
			this.TitleButton.Click += new System.EventHandler(this.TitleButton_Click);
			// 
			// TitleNextBtn
			// 
			this.TitleNextBtn.Location = new System.Drawing.Point(695, 289);
			this.TitleNextBtn.Name = "TitleNextBtn";
			this.TitleNextBtn.Size = new System.Drawing.Size(75, 23);
			this.TitleNextBtn.TabIndex = 6;
			this.TitleNextBtn.Text = "Next";
			this.TitleNextBtn.UseVisualStyleBackColor = true;
			this.TitleNextBtn.Click += new System.EventHandler(this.TitleNextBtn_Click);
			// 
			// RaceBtn
			// 
			this.RaceBtn.Location = new System.Drawing.Point(93, 338);
			this.RaceBtn.Name = "RaceBtn";
			this.RaceBtn.Size = new System.Drawing.Size(75, 45);
			this.RaceBtn.TabIndex = 2;
			this.RaceBtn.Text = "Race";
			this.RaceBtn.UseVisualStyleBackColor = true;
			this.RaceBtn.Click += new System.EventHandler(this.RaceBtn_Click);
			// 
			// ClassBtn
			// 
			this.ClassBtn.Location = new System.Drawing.Point(175, 338);
			this.ClassBtn.Name = "ClassBtn";
			this.ClassBtn.Size = new System.Drawing.Size(75, 45);
			this.ClassBtn.TabIndex = 3;
			this.ClassBtn.Text = "Class";
			this.ClassBtn.UseVisualStyleBackColor = true;
			this.ClassBtn.Click += new System.EventHandler(this.ClassBtn_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(257, 338);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 45);
			this.button3.TabIndex = 4;
			this.button3.Text = "Ability Scores";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(339, 338);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 45);
			this.button4.TabIndex = 5;
			this.button4.Text = "Character";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(421, 338);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 45);
			this.button5.TabIndex = 6;
			this.button5.Text = "Equipment";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// RaceScreen
			// 
			this.RaceScreen.Controls.Add(this.button6);
			this.RaceScreen.Controls.Add(this.RaceDetails);
			this.RaceScreen.Controls.Add(this.RacePic);
			this.RaceScreen.Controls.Add(this.SubRaceBenefits);
			this.RaceScreen.Controls.Add(this.SubRaceBenefitsText);
			this.RaceScreen.Controls.Add(this.RaceBenefits);
			this.RaceScreen.Controls.Add(this.SubRaces);
			this.RaceScreen.Controls.Add(this.RaceBenefitText);
			this.RaceScreen.Controls.Add(this.RaceText);
			this.RaceScreen.Controls.Add(this.Races);
			this.RaceScreen.Controls.Add(this.RaceTitle);
			this.RaceScreen.Controls.Add(this.TitleNextBtn);
			this.RaceScreen.Controls.Add(this.WhatToDo);
			this.RaceScreen.Controls.Add(this.WhatToDoText);
			this.RaceScreen.Controls.Add(this.PlayerName);
			this.RaceScreen.Controls.Add(this.UserName);
			this.RaceScreen.Controls.Add(this.StartTitle);
			this.RaceScreen.Enabled = false;
			this.RaceScreen.Location = new System.Drawing.Point(11, 12);
			this.RaceScreen.Name = "RaceScreen";
			this.RaceScreen.Size = new System.Drawing.Size(776, 319);
			this.RaceScreen.TabIndex = 7;
			this.RaceScreen.Visible = false;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(252, 53);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(117, 31);
			this.button6.TabIndex = 17;
			this.button6.Text = "I don\'t know";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// RaceDetails
			// 
			this.RaceDetails.AcceptsReturn = true;
			this.RaceDetails.AcceptsTab = true;
			this.RaceDetails.Location = new System.Drawing.Point(566, 56);
			this.RaceDetails.MaxLength = 3276700;
			this.RaceDetails.Multiline = true;
			this.RaceDetails.Name = "RaceDetails";
			this.RaceDetails.ReadOnly = true;
			this.RaceDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.RaceDetails.Size = new System.Drawing.Size(204, 213);
			this.RaceDetails.TabIndex = 16;
			// 
			// RacePic
			// 
			this.RacePic.Image = global::Dnd_Character_Creator.Properties.Resources.Commoner;
			this.RacePic.Location = new System.Drawing.Point(443, 59);
			this.RacePic.Name = "RacePic";
			this.RacePic.Size = new System.Drawing.Size(117, 210);
			this.RacePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.RacePic.TabIndex = 15;
			this.RacePic.TabStop = false;
			// 
			// SubRaceBenefits
			// 
			this.SubRaceBenefits.Location = new System.Drawing.Point(125, 191);
			this.SubRaceBenefits.Name = "SubRaceBenefits";
			this.SubRaceBenefits.Size = new System.Drawing.Size(124, 109);
			this.SubRaceBenefits.TabIndex = 14;
			this.SubRaceBenefits.Text = "Unknown";
			// 
			// SubRaceBenefitsText
			// 
			this.SubRaceBenefitsText.AutoSize = true;
			this.SubRaceBenefitsText.Location = new System.Drawing.Point(122, 174);
			this.SubRaceBenefitsText.Name = "SubRaceBenefitsText";
			this.SubRaceBenefitsText.Size = new System.Drawing.Size(93, 13);
			this.SubRaceBenefitsText.TabIndex = 13;
			this.SubRaceBenefitsText.Text = "SubRace Benefits";
			// 
			// RaceBenefits
			// 
			this.RaceBenefits.Location = new System.Drawing.Point(255, 109);
			this.RaceBenefits.Name = "RaceBenefits";
			this.RaceBenefits.Size = new System.Drawing.Size(182, 191);
			this.RaceBenefits.TabIndex = 12;
			this.RaceBenefits.Text = "Unknown";
			// 
			// SubRaces
			// 
			this.SubRaces.CheckOnClick = true;
			this.SubRaces.FormattingEnabled = true;
			this.SubRaces.Items.AddRange(new object[] {
            "Default"});
			this.SubRaces.Location = new System.Drawing.Point(122, 92);
			this.SubRaces.Name = "SubRaces";
			this.SubRaces.Size = new System.Drawing.Size(124, 79);
			this.SubRaces.TabIndex = 11;
			this.SubRaces.ThreeDCheckBoxes = true;
			this.SubRaces.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.SubRaces_ItemCheck);
			this.SubRaces.SelectedIndexChanged += new System.EventHandler(this.SubRaces_SelectedIndexChanged);
			// 
			// RaceBenefitText
			// 
			this.RaceBenefitText.AutoSize = true;
			this.RaceBenefitText.Location = new System.Drawing.Point(263, 92);
			this.RaceBenefitText.Name = "RaceBenefitText";
			this.RaceBenefitText.Size = new System.Drawing.Size(74, 13);
			this.RaceBenefitText.TabIndex = 10;
			this.RaceBenefitText.Text = "Race Benefits";
			// 
			// RaceText
			// 
			this.RaceText.AutoSize = true;
			this.RaceText.Location = new System.Drawing.Point(18, 59);
			this.RaceText.Name = "RaceText";
			this.RaceText.Size = new System.Drawing.Size(106, 13);
			this.RaceText.TabIndex = 9;
			this.RaceText.Text = "What Race are you?";
			// 
			// Races
			// 
			this.Races.CheckOnClick = true;
			this.Races.FormattingEnabled = true;
			this.Races.Location = new System.Drawing.Point(21, 92);
			this.Races.Name = "Races";
			this.Races.Size = new System.Drawing.Size(82, 139);
			this.Races.TabIndex = 8;
			this.Races.ThreeDCheckBoxes = true;
			this.Races.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Races_ItemCheck);
			this.Races.SelectedIndexChanged += new System.EventHandler(this.Races_SelectedIndexChanged);
			// 
			// RaceTitle
			// 
			this.RaceTitle.AutoSize = true;
			this.RaceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RaceTitle.Location = new System.Drawing.Point(324, 8);
			this.RaceTitle.Name = "RaceTitle";
			this.RaceTitle.Size = new System.Drawing.Size(54, 24);
			this.RaceTitle.TabIndex = 7;
			this.RaceTitle.Text = "Race";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 395);
			this.Controls.Add(this.RaceScreen);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.ClassBtn);
			this.Controls.Add(this.RaceBtn);
			this.Controls.Add(this.TitleButton);
			this.Controls.Add(this.Start_Screen);
			this.Name = "Form1";
			this.Text = "Form1";
			this.RaceScreen.ResumeLayout(false);
			this.RaceScreen.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.RacePic)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel Start_Screen;
		private System.Windows.Forms.Label UserName;
		private System.Windows.Forms.Label StartTitle;
		private System.Windows.Forms.TextBox PlayerName;
		private System.Windows.Forms.CheckedListBox WhatToDo;
		private System.Windows.Forms.Label WhatToDoText;
		private System.Windows.Forms.Button TitleNextBtn;
		private System.Windows.Forms.Button TitleButton;
		private System.Windows.Forms.Button RaceBtn;
		private System.Windows.Forms.Button ClassBtn;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Panel RaceScreen;
		private System.Windows.Forms.Label RaceTitle;
		private System.Windows.Forms.Label RaceText;
		private System.Windows.Forms.CheckedListBox Races;
		private System.Windows.Forms.Label RaceBenefits;
		private System.Windows.Forms.CheckedListBox SubRaces;
		private System.Windows.Forms.Label RaceBenefitText;
		private System.Windows.Forms.Label SubRaceBenefitsText;
		private System.Windows.Forms.PictureBox RacePic;
		private System.Windows.Forms.Label SubRaceBenefits;
		private System.Windows.Forms.TextBox RaceDetails;
		private System.Windows.Forms.Button button6;
	}
}

