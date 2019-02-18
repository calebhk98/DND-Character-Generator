using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dnd_Character_Creator {
	public partial class Form1 : Form {

		public class DNDRace {


			public static List<DNDRace> allRaces = new List<DNDRace>();
			public DNDRace() {
				DNDRace.allRaces.Add(this);
			}
			public void DNDRaceDescription() {
				bool WeaponTraining = false;
				bool ToolTraining = false;
				this.Descriptions = "Speed=" + this.Speed + "\n";
				#region Skill Bonuses
				if(this.StrengthBonus > 0) {
					this.Descriptions = this.Descriptions + "Strength: +" + this.StrengthBonus + " ";
				}
				if(this.DexterityBonus > 0) {
					this.Descriptions = this.Descriptions + "Dexterity: +" + this.DexterityBonus + " ";
				}
				if(this.ConstitutionBonus > 0) {
					this.Descriptions = this.Descriptions + "Constitution: +" + this.ConstitutionBonus + " ";
				}
				if(this.IntelligenceBonus > 0) {
					this.Descriptions = this.Descriptions + "Intelligence: +" + this.IntelligenceBonus + " ";
				}
				if(this.WisdomBonus > 0) {
					this.Descriptions = this.Descriptions + "Wisdom: +" + this.WisdomBonus + " ";
				}
				if(this.CharismaBonus > 0) {
					this.Descriptions = this.Descriptions + "Charisma: +" + this.CharismaBonus + " ";
				}
				#endregion
				if(this.DarkVision > 0) {
					this.Descriptions = this.Descriptions + "\nDarkVision " + this.DarkVision + " ft";
				}

				if(this.WeaponNumber > 0) {
					this.Descriptions = this.Descriptions + "\nWeapon Training: ";
					#region Weapon Training
					if(this.Weaponbattleaxe) {
						if(WeaponTraining) {
							this.Descriptions = this.Descriptions + ", ";
						}
						WeaponTraining = true;
						this.Descriptions = this.Descriptions + "Battle Axe";
					}
					if(this.Weaponhandaxe) {
						if(WeaponTraining) {
							this.Descriptions = this.Descriptions + ", ";
						}
						WeaponTraining = true;
						this.Descriptions = this.Descriptions + "Hand Axe";
					}
					if(this.Weaponwarhammer) {
						if(WeaponTraining) {
							this.Descriptions = this.Descriptions + ", ";
						}
						WeaponTraining = true;
						this.Descriptions = this.Descriptions + "War Hammer";
					}
					if(this.WeaponlightHammer) {
						if(WeaponTraining) {
							this.Descriptions = this.Descriptions + ", ";
						}
						WeaponTraining = true;
						this.Descriptions = this.Descriptions + "Light Hammer";
					}
					if(this.WeaponlongBow) {
						if(WeaponTraining) {
							this.Descriptions = this.Descriptions + ", ";
						}
						WeaponTraining = true;
						this.Descriptions = this.Descriptions + "Long Bow";
					}
					#endregion
				}

				if(this.ToolNumber > 0) {
					this.Descriptions = this.Descriptions + "\nTool Proficiency [" + this.ToolNumber + "]: ";
					#region Tool Training
					if(this.ToolBrewerssupplies) {
						if(ToolTraining) {
							this.Descriptions = this.Descriptions + ", ";
						}
						ToolTraining = true;
						this.Descriptions = this.Descriptions + "Brewer's supplies";
					}
					if(this.ToolMasonstools) {
						if(ToolTraining) {
							this.Descriptions = this.Descriptions + ", ";
						}
						ToolTraining = true;
						this.Descriptions = this.Descriptions + "Mason's supplies";
					}
					if(this.ToolSmithstools) {
						if(ToolTraining) {
							this.Descriptions = this.Descriptions + ", ";
						}
						ToolTraining = true;
						this.Descriptions = this.Descriptions + "Smith's supplies";
					}
					#endregion

				}

				this.Descriptions = this.Descriptions + "\n Features: " + this.FeatureNames + "\nLanguage: ";
				#region languages
				if(this.LanguagesCommon) {
					this.Descriptions = this.Descriptions + "Common";
				}
				if(this.LanguagesDwarfish) {
					this.Descriptions = this.Descriptions + ", Dwarvish";
				}
				if(this.LanguagesGnomish) {
					this.Descriptions = this.Descriptions + ", Gnomish";
				}
				#endregion
			}
			public String Name = "Common";
			public Image Look = Properties.Resources.Commoner;

			#region Skill Bonuses
			public int StrengthBonus = 0;
			public int DexterityBonus = 0;
			public int ConstitutionBonus = 0;
			public int IntelligenceBonus = 0;
			public int WisdomBonus = 0;
			public int CharismaBonus = 0;
			#endregion

			public string Size = "Medium";
			public int Speed = 30;
			public int FlyingSpeed = 0;
			public int SwimmingSpeed = 0;
			public int DarkVision = 0;

			public int baseAC = 10;

			#region Languages
			public bool LanguagesCommon = true;
			public bool LanguagesGnomish = false;
			public bool LanguagesDwarfish = false;
			public bool LanguagesElvish = false;

			#endregion


			#region WeaponProficiency
			public int WeaponNumber = 0;
			public bool WeaponlongBow = false;
			public bool Weaponbattleaxe = false;
			public bool Weaponhandaxe = false;
			public bool WeaponlightHammer = false;
			public bool Weaponwarhammer = false;
			#endregion
			#region SkillProficiency
			public int SkillNumber = 0;
			public bool SkillAcrobatics = false;
			public bool SkillAnimalHandling = false;
			public bool SkillArcana = false;
			public bool SkillAthletics = false;
			public bool SkillDeception = false;
			public bool SkillHistory = false;
			public bool SkillInsight = false;
			public bool SkillIntimiditation = false;
			public bool SkillInvestigation = false;
			public bool SkillMedicine = false;
			public bool SkillNature = false;
			public bool SkillPerception = false;
			public bool SkillPerfomance = false;
			public bool SkillPersuasion = false;
			public bool SkillReligion = false;
			public bool SkillSleightOfHand = false;
			public bool SkillStealth = false;
			public bool SkillSurvival = false;
			#endregion


			#region Armor
			public bool ArmorLight = false;
			public bool ArmorMedium = false;
			public bool ArmorHeavy = false;
			public bool ArmorShield = false;
			#endregion
			#region ToolProficiency 
			public int ToolNumber = 0;
			public bool ToolSmithstools = false;
			public bool ToolBrewerssupplies = false;
			public bool ToolMasonstools = false;
			#endregion
			public string Features = "";
			public string FeatureNames = "";
			public string Descriptions = "";
			public string Details = "";

			#region Resistances 
			public bool ResistancesPoison = false;
			#endregion

			#region svaingThrowAdvantage 
			public bool SavingPoisonAdv = false;
			public bool SavingCharmedAdv = false;

			#endregion
			//
		};
		public class DNDSubRace {
			public static List<DNDSubRace> allSubRaces = new List<DNDSubRace>();
			public DNDSubRace() {
				DNDSubRace.allSubRaces.Add(this);
			}
			public void DNDSubRaceDescription() {
				bool ArmorTraining = false;
				bool WeaponTraining = false;
				this.Details = "Benefits:\n";
				if(this.speed != this.MainRace.Speed) {
					this.Details = this.Details + "Speed: " + this.speed + "\n";
				}
				#region  AttributeBonuses
				if(this.StrengthBonus > 0) {
					this.Details = this.Details + "Strength: +" + this.StrengthBonus;
				}
				if(this.DexterityBonus > 0) {
					this.Details = this.Details + "Dexterity: +" + this.DexterityBonus;
				}
				if(this.ConstitutionBonus > 0) {
					this.Details = this.Details + "Constitution: +" + this.ConstitutionBonus;
				}
				if(this.IntelligenceBonus > 0) {
					this.Details = this.Details + "Intelligence: +" + this.IntelligenceBonus;
				}
				if(this.WisdomBonus > 0) {
					this.Details = this.Details + "Wisdom: +" + this.WisdomBonus;
				}
				if(this.CharismaBonus > 0) {
					this.Details = this.Details + "Charisma: +" + this.CharismaBonus;
				}
				#endregion
				if(this.extraLife > 0) {
					this.Details = this.Details + "\nExtra life per level: " + this.extraLife + "\n";
				}
				#region Armor
				if(this.ArmorLight | this.ArmorMedium | this.ArmorHeavy | this.ArmorShield) {
					this.Details = this.Details + "\nArmor Training: ";
					if(this.ArmorLight) {
						if(ArmorTraining) {
							this.Details = this.Details + ", ";
						}
						ArmorTraining = true;
						this.Details = this.Details + "Light Armor";
					}
					if(this.ArmorMedium) {
						if(ArmorTraining) {
							this.Details = this.Details + ", ";
						}
						ArmorTraining = true;
						this.Details = this.Details + "Medium Armor";
					}
					if(this.ArmorHeavy) {
						if(ArmorTraining) {
							this.Details = this.Details + ", ";
						}
						ArmorTraining = true;
						this.Details = this.Details + "Heavy Armor";
					}
					if(this.ArmorShield) {
						if(ArmorTraining) {
							this.Details = this.Details + ", ";
						}
						ArmorTraining = true;
						this.Details = this.Details + "Shield";
					}
				}


				#endregion
				#region Weapon

				if(this.WeaponNumber > 0) {
					this.Details = this.Details + "\nWeapon Training: ";
					#region Weapon Training
					if(this.Weaponbattleaxe) {
						if(WeaponTraining) {
							this.Details = this.Details + ", ";
						}
						WeaponTraining = true;
						this.Details = this.Details + "Battle Axe";
					}
					if(this.Weaponhandaxe) {
						if(WeaponTraining) {
							this.Details = this.Details + ", ";
						}
						WeaponTraining = true;
						this.Details = this.Details + "Hand Axe";
					}
					if(this.Weaponwarhammer) {
						if(WeaponTraining) {
							this.Details = this.Details + ", ";
						}
						WeaponTraining = true;
						this.Details = this.Details + "War Hammer";
					}
					if(this.WeaponlightHammer) {
						if(WeaponTraining) {
							this.Details = this.Details + ", ";
						}
						WeaponTraining = true;
						this.Details = this.Details + "Light Hammer";
					}
					if(this.WeaponLongBow) {
						if(WeaponTraining) {
							this.Details = this.Details + ", ";
						}
						WeaponTraining = true;
						this.Details = this.Details + "Long Bow";
					}
					if(this.WeaponShortBow) {
						if(WeaponTraining) {
							this.Details = this.Details + ", ";
						}
						WeaponTraining = true;
						this.Details = this.Details + "Short Bow";
					}
					if(this.WeaponLongSword) {
						if(WeaponTraining) {
							this.Details = this.Details + ", ";
						}
						WeaponTraining = true;
						this.Details = this.Details + "Long Sword";
					}
					if(this.WeaponShortSword) {
						if(WeaponTraining) {
							this.Details = this.Details + ", ";
						}
						WeaponTraining = true;
						this.Details = this.Details + "Short Sword";
					}

					#endregion
				}


				#endregion
				if(this.WizardCantrip > 0) {
					this.Details = this.Details + "\nWizard Cantrip:" + this.WizardCantrip;
				}
				if(this.ExtraLanguages > 0) {
					this.Details = this.Details + "\n Extra languages: " + this.ExtraLanguages;
				}


			}

			public String Name = "Common";
			public Image Look = Properties.Resources.Commoner;
			public DNDRace MainRace;
			public int extraLife = 0;
			public int ExtraLanguages = 0;
			public int WizardCantrip = 0;
			public int speed = 30;
			public string Features = "";
			public string FeatureNames = "";
			public string Details = "";

			#region Skill Bonuses
			public int StrengthBonus = 0;
			public int DexterityBonus = 0;
			public int ConstitutionBonus = 0;
			public int IntelligenceBonus = 0;
			public int WisdomBonus = 0;
			public int CharismaBonus = 0;
			#endregion
			#region Armor
			public bool ArmorLight = false;
			public bool ArmorMedium = false;
			public bool ArmorHeavy = false;
			public bool ArmorShield = false;
			#endregion
			#region WeaponProficiency
			public int WeaponNumber = 0;
			public bool WeaponLongBow = false;
			public bool WeaponShortBow = false;
			public bool Weaponbattleaxe = false;
			public bool Weaponhandaxe = false;
			public bool WeaponlightHammer = false;
			public bool Weaponwarhammer = false;
			public bool WeaponLongSword = false;
			public bool WeaponShortSword = false;
			#endregion

		}
		public class DNDClass {
			public string Name;
			public int HitDie = 8;
			public int HitDieAverage = 4;

			#region Proficiencies
						#region Armor
						public bool ArmorLight = false;
						public bool ArmorMedium = false;
						public bool ArmorHeavy = false;
						public bool ArmorShield = false;


						#endregion

						#region Weapon
						public bool WeaponsSimple = false;
						public bool WeaponsMartial = false;

						public bool WeaponsMelee = false;
						public bool WeaponsRanged = false;

						public bool WeaponsSimpleMelee = false;
						public bool WeaponsSimpleRanged = false;
						public bool WeaponsMartialMelee = false;
						public bool WeaponsMartialRanged = false;

			#endregion

			#region tools
			#endregion
			#region SavingThrows
			public bool SavingThrowStrength = false;
			public bool SavingThrowDexterity = false;
			public bool SavingThrowConstitution = false;
			public bool SavingThrowIntelligence = false;
			public bool SavingThrowWisdom = false;
			public bool SavingThrowCharisma = false;


			#endregion

			#region Skills
			public int numOfSkill = 0;
			public bool SkillAnimalhandling = false;
			public bool SkillAthletics = false;
			public bool SkillIntimidiation = false;
			public bool SkillNature = false;
			public bool SkillPerception = false;
			public bool SkillSurvival = false;


			public bool Skill = false;


			#endregion


			#endregion
			#region Equipment
			#endregion




		}
		#region Panels
		Panel Class_Screen = new Panel() {
			Location = new Point(11, 12),
			Size = new System.Drawing.Size(776, 319),
			Visible = false,
			Enabled = false
		};
		#endregion
		#region Labels

		Label ClassText = new Label() {
			Text="What Class are you?",
			Location=new Point(18,59),
			AutoSize=true,


		};

		#endregion

		#region CheckedListbox

		CheckedListBox Classes = new CheckedListBox() {
			Location = new Point(21,92),
			Size = new System.Drawing.Size(82, 139),
			


		};


		#endregion




		public Form1() {
			InitializeComponent();
			WhatToDo.SetItemChecked(0, true);
			#region Adding to Form

			this.Controls.Add(Class_Screen);
			#endregion
			setup();
		}
		private void setup() {
			#region Start Screen
			Start_Screen.Controls.Add(StartTitle);
			Start_Screen.Controls.Add(UserName);
			Start_Screen.Controls.Add(PlayerName);
			Start_Screen.Controls.Add(WhatToDo);
			Start_Screen.Controls.Add(WhatToDoText);
			Start_Screen.Controls.Add(TitleNextBtn);
			#endregion

			#region ClassScreen
			Class_Screen.Controls.Add(ClassText);
			Class_Screen.Controls.Add(Classes);



			#endregion


			#region Race Screen
			RaceScreen.Controls.Add(RaceTitle);
			RaceScreen.Controls.Add(Races);
			RaceScreen.Controls.Add(RaceText);
			#endregion
			#region Races

			/*
			 Dwarf
			Elf
	Halfling
	Human
	DragonBorn
	Gnome
	Half-Elf
	Half-Orc
	Tiefling
				 */
			

			#region Dwarf
			DNDRace Dwarf = new DNDRace() {
			Name = "Dwarf",
			ConstitutionBonus = 2,
			Features = "Stonecunning: Whenever you make a History check related to the origin of stonework, \n" +
					"you are considered proficient in the History skill and add double your proficiency bonus to the check, \n" +
					"instead of your normal proficiency bonus.",
			FeatureNames = "Stonecunning",
			Speed = 25,
			DarkVision = 60,
			ResistancesPoison = true,
			SavingPoisonAdv = true,
			WeaponNumber = 4,
			Weaponbattleaxe = true,
			Weaponhandaxe = true,
			WeaponlightHammer = true,
			Weaponwarhammer = true,
			ToolBrewerssupplies = true,
			ToolMasonstools = true,
			ToolSmithstools = true,
			LanguagesDwarfish = true,
			Look = Properties.Resources.Dwarf_1,
			Details = "Though they stand well under 5 feet tall, dwarves are so broad and compact that they can weigh as much as a human standing nearly two feet taller.\n" +
			"Dwarven skin ranges from deep brown to a paler hue tinged with red, but the most common shades are light brown or deep tan, like certain tones of earth. Their hair, worn long but in simple styles, is usually black, gray, or brown, though paler dwarves often have red hair. Male dwarves value their beards highly and groom them carefully." +
			"Dwarves can live to be more than 400 years old, so the oldest living dwarves often remember a very different world. They respect the traditions of their clans, tracing their ancestry back to the founding of their most ancient strongholds in the youth of the world, and don’t abandon those traditions lightly." +
			"Individual dwarves are determined and loyal, true to their word and decisive in action, sometimes to the point of stubbornness. Many dwarves have a strong sense of justice, and they are slow to forget wrongs they have suffered. A wrong done to one dwarf is a wrong done to the dwarf’s entire clan, so what begins as one dwarf’s hunt for vengeance can become a full-blown clan feud." +
			"They love the beauty and artistry of precious metals and fine jewelry, and in some dwarves this love festers into avarice. Whatever wealth they can’t find in their mountains, they gain through trade. They dislike boats, so enterprising humans and halflings frequently handle trade in dwarven goods along water routes." +
			"The chief unit of dwarven society is the clan, and dwarves highly value social standing. To be clanless is the worst fate that can befall a dwarf." +
			"Dwarves in other lands are typically artisans, especially weaponsmiths, armorers, and jewelers. Some become mercenaries or bodyguards, highly sought after for their courage and loyalty.",

			//Descriptions = DNDRaceDescription;

		};
		#endregion

		#region Elf
		 DNDRace Elf = new DNDRace() {
			Name = "Elf",
			DexterityBonus = 2,
			SkillPerception = true,
			DarkVision = 60,
			SavingCharmedAdv = true,
			LanguagesElvish = true,
			LanguagesCommon = true,
			Look = Properties.Resources.Elf,
			FeatureNames = "Fey Ancestry, and Trance",
			Features = "Fey Ancestry: You have advantage on saving throws against being charmed, and magic can’t put you to sleep." +
			"Trance: Elves don’t need to sleep. Instead, they meditate deeply, remaining semiconscious, for 4 hours a day. (The Common word for such meditation is “trance.”) While meditating, you can dream after a fashion; such dreams are actually mental exercises that have become reflexive through years of practice. After resting in this way, you gain the same benefit that a human does from 8 hours of sleep.",

			Details = "",

			//Descriptions = DNDRaceDescription;

		};
			#endregion


			#region Human
			DNDRace Human = new DNDRace() {
				Name = "Human",
				DexterityBonus = 2,
				SkillPerception = true,
				DarkVision = 60,
				SavingCharmedAdv = true,
				LanguagesElvish = true,
				LanguagesCommon = true,
				Look = Properties.Resources.Commoner,
				FeatureNames = "Fey Ancestry, and Trance",
				Features = "Fey Ancestry: You have advantage on saving throws against being charmed, and magic can’t put you to sleep." +
			   "Trance: Elves don’t need to sleep. Instead, they meditate deeply, remaining semiconscious, for 4 hours a day. (The Common word for such meditation is “trance.”) While meditating, you can dream after a fashion; such dreams are actually mental exercises that have become reflexive through years of practice. After resting in this way, you gain the same benefit that a human does from 8 hours of sleep.",

				Details = "",

				//Descriptions = DNDRaceDescription;

			};
			#endregion




			#endregion
			#region Subraces
			DNDSubRace HillDwarf = new DNDSubRace {
				MainRace = Dwarf,
				speed = 25,
				Name = "Hill Dwarf",
				Look = Properties.Resources.Hill_Dwarf,
				WisdomBonus = 1,
				extraLife = 1,
			};
			DNDSubRace MountainDwarf = new DNDSubRace {
				Name = "Mountain Dwarf",
				speed = 25,
				MainRace = Dwarf,
				StrengthBonus = 2,
				Look = Properties.Resources.mountaindwarf,
				ArmorLight = true,
				ArmorMedium = true
			};

			DNDSubRace HighElf = new DNDSubRace {
				Name = "High Elf",
				MainRace = Elf,
				IntelligenceBonus = 1,
				WeaponNumber = 4,
				WeaponLongBow = true,
				WeaponShortBow = true,
				Look = Properties.Resources.High_elf,
				WeaponLongSword = true,
				WeaponShortSword = true,
				ExtraLanguages = 1,
				WizardCantrip = 1,
			};
			DNDSubRace WoodElf = new DNDSubRace {
				Name = "Wood Elf",
				MainRace = Elf,
				Look = Properties.Resources.Wood_elf,
				WisdomBonus = 1,
				WeaponNumber = 4,
				WeaponLongBow = true,
				WeaponShortBow = true,
				WeaponLongSword = true,
				WeaponShortSword = true,
				speed = 35,
				FeatureNames = "Mask of the Wild",
				Features = "Mask of the Wild: You can attempt to hide even when you are only lightly obscured by foliage, heavy rain, falling snow, mist, and other natural phenomena."

			};

			#endregion
			#region Classes
			DNDClass Barbarian = new DNDClass() {
				Name = "Barbarian",
				HitDie = 12,
				HitDieAverage = 7,
				ArmorLight = true,
				ArmorMedium = true,
				ArmorShield = true,
				WeaponsSimple = true,
				WeaponsMartial = true,
				SavingThrowStrength = true,
				SavingThrowConstitution = true,
				numOfSkill = 2,
				SkillAnimalhandling=true,
				SkillAthletics=true,
				SkillIntimidiation=true,
				SkillNature=true,
				SkillPerception=true,
				SkillSurvival = true,

				


			};
			#endregion

			for(int i = 0; i < DNDRace.allRaces.Count; i++) {

				Races.Items.Insert(i, DNDRace.allRaces [i].Name);
			}

		}



		private void WhatToDo_ItemCheck( object sender, ItemCheckEventArgs e ) {

			for(int i = 0; i < WhatToDo.Items.Count; ++i)
				
				if(i != e.Index) {
					WhatToDo.SetItemChecked(i, false);
				}
		}

		private void changePage( int i ) {
			if(i == 0) {
				Start_Screen.Enabled = true;
				Start_Screen.Visible = true;
			}
			else {
				Start_Screen.Enabled = false;
				Start_Screen.Visible = false;
			}
			if(i == 1) {
				RaceScreen.Enabled = true;
				RaceScreen.Visible = true;
			}
			else {
				RaceScreen.Enabled = false;
				RaceScreen.Visible = false;
			}
			if(i == 2) {
				Class_Screen.Enabled = true;
				Class_Screen.Visible = true;
			}
			else {
				Class_Screen.Enabled = false;
				Class_Screen.Visible = false;
			}
		}

		private void TitleButton_Click( object sender, EventArgs e ) {
			changePage(0);

		}

		private void TitleNextBtn_Click( object sender, EventArgs e ) {
			int i = WhatToDo.CheckedItems.Count;
			for(i = 0; i < WhatToDo.Items.Count; i++) {
				if(WhatToDo.GetItemChecked(i)) {
					changePage(i+1);
				}
			}
			
		}

		private void RaceBtn_Click( object sender, EventArgs e ) {
			changePage(1);
		}

		private void Races_ItemCheck( object sender, ItemCheckEventArgs e ) {
			for(int i = 0; i < Races.Items.Count; ++i) {

				if(i != e.Index) {
					Races.SetItemChecked(i, false);
				}
			}
		}

		private void Races_SelectedIndexChanged( object sender, EventArgs e ) {
			for(int i = 0; i < Races.Items.Count; i++) {
				if(Races.GetItemCheckState(i) == CheckState.Checked) {

					DNDRace.allRaces [i].DNDRaceDescription();
					RaceBenefits.Text = DNDRace.allRaces[i].Descriptions;//This adds the sumary Text
					RaceDetails.Text = DNDRace.allRaces [i].Details;
					RacePic.Image = DNDRace.allRaces [i].Look;
						for(int j = SubRaces.Items.Count; j > 0; j--) {
							SubRaces.Items.RemoveAt(j - 1);
						}// This gets rid of all privitive Subraces

					for(int k = 0; k < DNDSubRace.allSubRaces.Count; k++) {
						if(DNDSubRace.allSubRaces[k].MainRace == DNDRace.allRaces[i]) {
							SubRaces.Items.Insert(SubRaces.Items.Count, DNDSubRace.allSubRaces[k].Name);//Insets the name of all the subraces that have the same parent
						}//Finds out if the subrace main is teh same as selected

					}//Goes through all ths subraces
					


					//SubRaces.Items.Insert(SubRaces.Items.Count, "Hill Dwarf");
						//SubRaces.Items.Insert(SubRaces.Items.Count, "Mountain Dwarf");

											

				}
			}
		}

		private void SubRaces_SelectedIndexChanged( object sender, EventArgs e ) {
			List<int>  SubraceNumber= new List<int>();//This will hold a list of the number of subraces
			//List<DNDSubRace> k = DNDSubRace.allSubRaces.Where(r => r.MainRace.Name == Races.SelectedItem).ToList(); //Testing ideas
			int selectedSubraceNumber = 0;//This is what number is selected

			for(int j = SubRaces.Items.Count - 1; j >= 0; j--) {
				if(SubRaces.GetItemCheckState(j) == CheckState.Checked) {
					selectedSubraceNumber = j;
					break;
				}
			}



			/*
			for(int i = 0; i < SubRaces.Items.Count; i++) {
				if(SubRaces.GetItemCheckState(i) == CheckState.Checked) {
					selectedSubraceNumber = i;	//This stores which was selected	
				}		//This finds out if it is selected		
			}//This goes through all the options
			
			Console.WriteLine("k is "+k);
			Console.WriteLine("k has " + k.Count);
			Console.WriteLine("k 1 is " + k[0].Name);
			Console.WriteLine("k 2 is " + k [1].Name);
			*/
			for(int i = 0; i < DNDSubRace.allSubRaces.Count; i++){
				if(DNDSubRace.allSubRaces[i].MainRace.Name == Races.SelectedItem) {
					SubraceNumber.Add(i);//This adds the number that the subrace is at
				}
			}	
			DNDSubRace.allSubRaces [SubraceNumber [selectedSubraceNumber]].DNDSubRaceDescription();
			SubRaceBenefits.Text = DNDSubRace.allSubRaces [SubraceNumber [selectedSubraceNumber]].Details;
			RacePic.Image= DNDSubRace.allSubRaces [SubraceNumber [selectedSubraceNumber]].Look;
		}

		private void SubRaces_ItemCheck( object sender, ItemCheckEventArgs e ) {
			for(int i = 0; i < SubRaces.Items.Count; ++i) {

				if(i != e.Index) {
					SubRaces.SetItemChecked(i, false);
				}
			}
		}

		private void ClassBtn_Click( object sender, EventArgs e ) {
			changePage(2);
		}
	}
}
