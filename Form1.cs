using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonCrawl1_Fultze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Player player;
        private Creature foe1;
        private Creature foe2;
        private Room loaction;

        private void Form1_Load(object sender, EventArgs e)
        {
            player = new Player { HitPoints = 300 };
            playerHPLabel.Text = player.HitPoints.ToString();
            // location = new Room.FirstRoom();
            roomNameLabel.Text = loaction.roomName.ToString();

            foe1 = new Creature { HitPoints = 100 };
            creature1HPLabel.Text = foe1.HitPoints.ToString();
            foe2 = new Creature { HitPoints = 75 };
            creature2HPLabel.Text = foe2.HitPoints.ToString();

            label2.Text = "Foe1";
            label5.Text = "Foe2";

        }
        private void playerActionsListBox_SelectedIndexChanged(object sender, EventArgs e) { }

        private void playerAttackButton_Click(object sender, EventArgs e)
        {               /* ACTION */
            string action; // To hold the name of a action

            
            if (playerActionsListBox.SelectedIndex != -1)
            {
                // Get the selected action
                action = playerActionsListBox.SelectedItem.ToString();

                // Determine the action
                switch (action)
                {
                    case "Attack Foe1": 
                        player.attack(50, foe1);
                        creature1HPLabel.Text = foe1.HitPoints.ToString();
                        textBox1.Text += "You attacked " + Convert.ToString("foe1\n");
                        //backgroundLabel.Text += "You attacked " + Convert.ToString("foe1\n");
                        break;
                    case "Attack Foe2":
                        player.attack(50, foe2);
                        creature2HPLabel.Text = foe2.HitPoints.ToString();
                        textBox1.Text += "You attacked " + Convert.ToString("foe2\n");
                        break;
                    case "Use Item":
                        textBox1.Text += "Using a Item" + "\n";
                        break;
                    case "Run":
                        textBox1.Text += "Running" + "\n";
                        break;
                    case "Adavance":
                        backgroundLabel.Text = "Adavanceing to next room" + "\n";
                        break;
                }

            }
            else
            {
                // No button was selected.
                textBox1.Text += (" Select a move " + "\n");
                backgroundLabel.Text += (" Select a move " + "\n");
            }

            
            /*
            if (foe1.Alive() || !foe2.Alive())
            {
                foe1.attack(50, player);
                playerHPLabel.Text = player.HitPoints.ToString();
                textBox1.Text += Convert.ToString("foe1 attack you.\n");
                backgroundLabel.Text += Convert.ToString("foe1 attack you.\n");

                foe2.attack(50, player);
                playerHPLabel.Text = player.HitPoints.ToString();
                textBox1.Text += Convert.ToString("foe2 attack you.\n");
                backgroundLabel.Text += Convert.ToString("foe2 attack you.\n");
            }
            else
            {
                backgroundLabel.Text = "You killed the enemies.";
            }
            */
          
            
           
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Closes Application
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
