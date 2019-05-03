using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using static System.Drawing.Color;

namespace Connect_Four
{
	public partial class GameForm : Form
	{
		SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.DropMusic);
		Button[,] Holes = new Button[7, 6];
		bool RedTurn = true;
		bool BlueTurn = false;
		int ArrowPos;
		public GameForm()
		{
			InitializeComponent();
			Holes[0, 0] = R0C0;
			Holes[0, 1] = R0C1;
			Holes[0, 2] = R0C2;
			Holes[0, 3] = R0C3;
			Holes[0, 4] = R0C4;
			Holes[0, 5] = R0C5;

			Holes[1, 0] = R1C0;
			Holes[1, 1] = R1C1;
			Holes[1, 2] = R1C2;
			Holes[1, 3] = button14;
			Holes[1, 4] = button28;
			Holes[1, 5] = button3;

			Holes[2, 0] = button45;
			Holes[2, 1] = button34;
			Holes[2, 2] = button20;
			Holes[2, 3] = button13;
			Holes[2, 4] = button27;
			Holes[2, 5] = button4;

			Holes[3, 0] = button46;
			Holes[3, 1] = button33;
			Holes[3, 2] = button19;
			Holes[3, 3] = button12;
			Holes[3, 4] = button26;
			Holes[3, 5] = button5;

			Holes[4, 0] = button47;
			Holes[4, 1] = button32;
			Holes[4, 2] = button18;
			Holes[4, 3] = button11;
			Holes[4, 4] = button25;
			Holes[4, 5] = button6;

			Holes[5, 0] = button48;
			Holes[5, 1] = button31;
			Holes[5, 2] = button17;
			Holes[5, 3] = button10;
			Holes[5, 4] = button24;
			Holes[5, 5] = button7;

			Holes[6, 0] = button37;
			Holes[6, 1] = button30;
			Holes[6, 2] = button16;
			Holes[6, 3] = button9;
			Holes[6, 4] = button23;
			Holes[6, 5] = button8;

			soundPlayer.PlayLooping();

			gameloop();
		}
		private async void gameloop()
		{
			while (true)
			{
				await Task.Delay(50);

				if (chk_AI.Checked == true && RedTurn==false)
				{
					AutoMove();
					RedTurn = true;
				}
			}
		}
		private void button44_Click(object sender, EventArgs e)
		{
			SettingPanel.Visible = true;
		}

		private void R1_clicked(object sender, EventArgs e)
		{
			FillRows(0);
		}

		private void FillRows(int row) //Update status
		{
			for (int i = 0; i < 6; i++)
			{
				if (Holes[row, i].Enabled == true)
				{
					if (RedTurn == true)
					{
						Holes[row, i].BackColor = Color.Red;
						Holes[row, i].Enabled = false;
					}
					else
					{
						Holes[row, i].BackColor = Color.Blue;
						Holes[row, i].Enabled = false;
					}
					if (CheckWin(row, i))
					{
						if (RedTurn == true)
						{
							MessageBox.Show("Red Won!");
							BtnClear_Click_1(null, null);
						}
						else if (RedTurn == false)
						{
							MessageBox.Show("Blue Won!");
							BtnClear_Click_1(null, null);
						}
					}
					RedTurn = !RedTurn;
					break;
				}
			}
			if (CheckDraw())
			{
				MessageBox.Show("It's a draw!");
				BtnClear_Click_1(null, null);
			}
		}
		bool CheckDraw()
		{
			for(int row = 0; row < 7; row++)
			{
				for (int i = 0; i < 6; i++)
				{
					if (Holes[row, i].BackColor != Color.Blue && Holes[row, i].BackColor != Color.Red && Holes[row, i].BackColor == Color.FromKnownColor(KnownColor.Control))
					{
						return false;
					}
				}
			}
			return true;
		}
		private void R2_click(object sender, EventArgs e)
		{
			FillRows(1);
		}

		private void R3_click(object sender, EventArgs e)
		{
			FillRows(2);
		}

		private void R4_click(object sender, EventArgs e)
		{
			FillRows(3);
		}

		private void R5_click(object sender, EventArgs e)
		{
			FillRows(4);
		}

		private void ApplyButton_Click(object sender, EventArgs e)
		{
			switch (comboBox1.Text)
			{
				case "Black":
					Board.BackColor = Color.Black;
					break;
				case "White":
					Board.BackColor = Color.White;
					break;
			}
			if (cb_Music.Checked == true)
			{
				soundPlayer.Stop();
			}
			else
			{
				soundPlayer.PlayLooping();
			}

			SettingPanel.Visible = false;
		}

		private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void R6_click(object sender, EventArgs e)
		{
			FillRows(5);
		}

		private void R7_click(object sender, EventArgs e)
		{
			FillRows(6);
		}

		private bool CheckWin(int x, int y)
		{
			if (y >= 3)
			{
				if (Holes[x, y - 3].BackColor == Holes[x, y].BackColor)
				{
					if (Holes[x, y - 2].BackColor == Holes[x, y].BackColor)
					{
						if (Holes[x, y - 1].BackColor == Holes[x, y].BackColor)
						{
							Holes[x,y].Text = "X";
							Holes[x,y].Font = new Font("Microsoft Sans Serif", 35);
							return true;
						}
					}
				}
			}
			for (int dy = -1; dy <= 1; dy++)
			{
				int nb = 0;
				for (int dx = 1; x + dx < 7 && y + dx * dy < 6 && y + dx * dy >= 0; dx++)
					if (Holes[x + dx, y + dx * dy].BackColor == Holes[x, y].BackColor)
					{
						nb++;
					}
					else
						break;
				for (var dx = -1; x + dx >= 0 && y + dx * dy < 6 && y + dx * dy >= 0; dx--)
					if (Holes[x + dx, y + dx * dy].BackColor == Holes[x, y].BackColor)
					{
						nb++;
					}
					else
						break;
				if (nb >= 3)
				{
					Holes[x, y].Text = "X";
					Holes[x, y].Font = new Font("Microsoft Sans Serif", 35);
					return true;
				}
			}
			return false;
		}
		private void BtnClear_Click_1(object sender, EventArgs e)
		{
			for (int y = 0; y < 6; y++)
			{
				for (int x = 0; x < 7; x++)
				{
					Holes[x, y].BackColor = FromKnownColor(KnownColor.Control);
					Holes[x, y].Enabled = true;
					Holes[x, y].Text = null;
				}
			}
		}

		private void Chk_AI_CheckedChanged(object sender, EventArgs e)
		{
			if (chk_AI.Checked == true)
			{
				BtnClear_Click_1(null, null);
				DialogResult Question = MessageBox.Show("Do You Want to Go First?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (DialogResult == DialogResult.Yes)
				{
					RedTurn = true;
				}
				else
				{
					RedTurn = false;					
				}
			}
			else
			{
				BtnClear_Click_1(null, null);
			}
		}
		public bool CheckRow(int row)
		{
			if (Holes[row, 5].BackColor != FromKnownColor(KnownColor.Control))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		private void AutoMove()
		{
			Random rnd = new Random();
			int r = 3;
			while (true)
			{
				if (CheckRow(r))
				{
					r = rnd.Next(7);
				}
				else
				{
					break;
				}
			}
			
			FillRows(r);
			RedTurn = !RedTurn;
		}
		private void SettingPanel_MouseDown(object sender, MouseEventArgs e)
		{

		}

		private void GameForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Shift && e.KeyCode == Keys.C)
			{
				if (chk_AI.Checked == true)
				{
					MessageBox.Show("Cleared the Board...\nStopped Playing Automatically!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					chk_AI.CheckState = CheckState.Unchecked;
				}
					BtnClear_Click_1(null, null);
			}
			if (e.Shift && e.KeyCode == Keys.Escape)
			{
				Application.Exit();
			}
			bool ArrowExists = false;
			if (e.KeyCode == Keys.D ||e.KeyCode == Keys.Right)
			{				
				for(int row = 0; row < 7; row++)
				{
					if (Holes[row, 5].Text != "↓")
					{

					}
					else
					{
						ArrowExists = true;
					}
				}
				if (!ArrowExists)
				{
					int r = 0;
					Holes[r, 5].Text = "↓";
					ArrowPos = 0;
				}
				else
				{
					//Moves Arrow;
					Holes[ArrowPos, 5].Text = "";
					if (ArrowPos >= 6)
					{
						ArrowPos = -1;
					}
					Holes[++ArrowPos, 5].Text = "↓";
				}
			}
			if (e.KeyCode == Keys.A||e.KeyCode==Keys.Left)
			{
				for (int row = 0; row < 7; row++)
				{
					if (Holes[row, 5].Text != "↓")
					{

					}
					else
					{
						ArrowExists = true;
					}
				}
				if (!ArrowExists)
				{
					Holes[6, 5].Text = "↓";
					ArrowPos = 6;
				}
				else
				{
					//Moves arrow leftward
					Holes[ArrowPos, 5].Text = "";
					if (ArrowPos <= 0)
					{
						ArrowPos = 7;
					}
					Holes[--ArrowPos, 5].Text = "↓";
				}
			}
			if (ArrowPos >= 0)
			{
				//Key press loop to drop piece
				if (Holes[ArrowPos, 5].Text == "↓" && e.KeyCode == Keys.S)
				{
					FillRows(ArrowPos);
				}
			}
			if (e.Control&&e.KeyCode == Keys.M)
			{
				if (!cb_Music.Checked)
				{
					cb_Music.CheckState = CheckState.Checked; ApplyButton_Click(null, null);
				}
				else
				{
					cb_Music.CheckState = CheckState.Unchecked; ApplyButton_Click(null, null);
				}
			}
		}

		private void GameForm_Load(object sender, EventArgs e)
		{
			FadeIn(this);
		}
		private async void FadeIn(Form o, int interval = 80)
		{
			//Object is not fully invisible. Fade it in
			while (o.Opacity < 1.0)
			{
				await Task.Delay(interval);
				o.Opacity += 0.05;
			}
			o.Opacity = 1; //make fully visible       
		}

		private async void FadeOut(Form o, int interval = 80)
		{
			//Object is fully visible. Fade it out
			while (o.Opacity > 0.0)
			{
				await Task.Delay(interval);
				o.Opacity -= 0.05;
			}
			o.Opacity = 0; //make fully invisible       
		}

		private async void GameForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			var t = true;
			e.Cancel = t;
			while(Opacity > 0.0)
			{
				await Task.Delay(80);
				Opacity -= 0.05;
			}
			var f = false;			
			Opacity = 0;
			e.Cancel = f;
			Application.Exit();
		}
	}
}