using static THA_W4_JESSICA_T.Form1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace THA_W4_JESSICA_T
{
    public partial class Form1 : Form
    {
        List<Team> teamList = new List<Team>();
        public class Player
        {
            public string playerName;
            public string playerNum;
            public string playerPos;
        }
        public class Team
        {
            public string teamName;
            public string teamCountry;
            public List<Player> PlayersList = new List<Player>();
        }
        public void updateListBoxPlayersData()
        {
            listBox_PlayerData.Items.Clear();
            listBox_PlayerData.Sorted = true;
            foreach (Team team in teamList)
            {
                if (team.teamName == comboBox_Team.SelectedItem.ToString())
                {
                    foreach (Player player in team.PlayersList)
                    {
                        listBox_PlayerData.Items.Add("(" + player.playerNum + ") " + player.playerName + ", " + player.playerPos);
                    }
                }
            }
        }

        public void updateListComboBoxCountry()
        {
            comboBox_Country.Items.Clear();
            foreach (Team hehe in teamList)
            {
                if (!comboBox_Country.Items.Contains(hehe.teamCountry))
                {
                    comboBox_Country.Items.Add(hehe.teamCountry);
                }
            }
        }

        public void updateListComboBoxTeam()
        {
            comboBox_Team.Items.Clear();
            foreach (Team hehe in teamList)
            {
                if (hehe.teamCountry == comboBox_Country.SelectedItem.ToString())
                {
                    comboBox_Team.Items.Add(hehe.teamName);
                }
            }

        }

        public Form1()
        {
            InitializeComponent();
            Team team1 = new Team();
            team1.teamName = "Real Madrid";
            team1.teamCountry = "Spain";
            team1.PlayersList.Add(new Player { playerName = "Karim Benzema", playerNum = "09", playerPos = "FW" });
            team1.PlayersList.Add(new Player { playerName = "Sergio Ramos", playerNum = "04", playerPos = "DF" });
            team1.PlayersList.Add(new Player { playerName = "Luka Modric", playerNum = "10", playerPos = "MF" });
            team1.PlayersList.Add(new Player { playerName = "Hazard", playerNum = "17", playerPos = "FW" });
            team1.PlayersList.Add(new Player { playerName = "Roberto Carlos", playerNum = "03", playerPos = "DF" });
            team1.PlayersList.Add(new Player { playerName = "Carvajal", playerNum = "02", playerPos = "DF" });
            team1.PlayersList.Add(new Player { playerName = "Zinedine Zidane", playerNum = "05", playerPos = "MF" });
            team1.PlayersList.Add(new Player { playerName = "Courtois", playerNum = "01", playerPos = "GK"});
            team1.PlayersList.Add(new Player { playerName = "Nacho", playerNum = "06", playerPos = "DF"});
            team1.PlayersList.Add(new Player { playerName = "Camavinga", playerNum = "12", playerPos = "MF"});
            team1.PlayersList.Add(new Player { playerName = "D. Ceballos", playerNum = "19", playerPos = "MF"});
            teamList.Add(team1);

            Team team2 = new Team();
            team2.teamName = "Barcelona";
            team2.teamCountry = "Spain";
            team2.PlayersList.Add(new Player { playerName = "Marc-Andre ter Stegen", playerNum = "01", playerPos = "GK" });
            team2.PlayersList.Add(new Player { playerName = "Ronald Araujo", playerNum = "04", playerPos = "DF" });
            team2.PlayersList.Add(new Player { playerName = "Andreas Christensen", playerNum = "15", playerPos = "DF" });
            team2.PlayersList.Add(new Player { playerName = "Marcos Alonso", playerNum = "17", playerPos = "DF" });
            team2.PlayersList.Add(new Player { playerName = "Jules Kounde", playerNum = "23", playerPos = "DF" });
            team2.PlayersList.Add(new Player { playerName = "Sergi Busquets", playerNum = "05", playerPos = "MF" });
            team2.PlayersList.Add(new Player { playerName = "Gavi", playerNum = "06", playerPos = "MF"});
            team2.PlayersList.Add(new Player { playerName = "Pedri", playerNum = "08", playerPos = "MF" });
            team2.PlayersList.Add(new Player { playerName = "Sergi Roberto", playerNum = "20", playerPos = "MF" });
            team2.PlayersList.Add(new Player { playerName = "Robert Lewandowski", playerNum = "09", playerPos = "FW" });
            team2.PlayersList.Add(new Player { playerName = "Anssumane Fati", playerNum = "11", playerPos = "FW" });
            teamList.Add(team2);

            Team team3 = new Team();
            team3.teamName = "Ulsan Hyundai";
            team3.teamCountry = "South Korea";
            team3.PlayersList.Add(new Player { playerName = "Su-hyeok Jo", playerNum = "01", playerPos = "GK" });
            team3.PlayersList.Add(new Player { playerName = "Chung Seung Hyung", playerNum = "15", playerPos = "DF" });
            team3.PlayersList.Add(new Player { playerName = "Lim Jeong Un", playerNum = "05", playerPos = "DF" });
            team3.PlayersList.Add(new Player { playerName = "Sang-hyeok Lee", playerNum = "04", playerPos = "DF"});
            team3.PlayersList.Add(new Player { playerName = "Kim Young-Gwon", playerNum = "19", playerPos = "DF" });
            team3.PlayersList.Add(new Player { playerName = "Park Yong-Woon", playerNum = "06", playerPos = "MF" });
            team3.PlayersList.Add(new Player { playerName = "Seong-Jun Kim", playerNum = "16", playerPos = "MF" });
            team3.PlayersList.Add(new Player { playerName = "Yoon-Gu Kang", playerNum = "30", playerPos = "MF" });
            team3.PlayersList.Add(new Player { playerName = "Hyung Min Shin", playerNum = "20", playerPos = "MF" });
            team3.PlayersList.Add(new Player { playerName = "Il-Lok Yun", playerNum = "07", playerPos = "FW" });
            team3.PlayersList.Add(new Player { playerName = "Si-young Jang", playerNum = "03", playerPos = "FW" });
            teamList.Add(team3);
            updateListComboBoxCountry();

        }
        private void comboBox_Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateListComboBoxTeam();
        }
        private void comboBox_Team_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateListBoxPlayersData();
        }

        private void button_Add1_Click(object sender, EventArgs e)
        {
            int cek = 0;
            Team teamm = new Team();

            if (!string.IsNullOrEmpty(textBox_TeamName.Text) && !string.IsNullOrEmpty(textBox_TeamCountry.Text) 
                && !string.IsNullOrEmpty(textBox_TeamCity.Text)) 
            {
                foreach (Team hoho in teamList)
                {               
                    if (hoho.teamName.ToString() == textBox_TeamName.Text)
                    {
                        cek = 1;
                    }
                }
                if (cek == 1)
                {
                    MessageBox.Show("Team already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {            
                    teamm.teamCountry = textBox_TeamCountry.Text;
                    teamm.teamName = textBox_TeamName.Text;
                    teamList.Add(teamm);
                    updateListComboBoxCountry();
                    textBox_TeamName.Clear();
                    textBox_TeamCountry.Clear();
                    textBox_TeamCity.Clear();
                }    
            }
            else
            {
                MessageBox.Show("Please fill all fields correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void button_Add2_Click(object sender, EventArgs e)
        {
            int cekk = 0;
            Team teamm = new Team();
            if (!string.IsNullOrEmpty(textBox_PlayerName.Text) && !string.IsNullOrEmpty(textBox_PlayerNumber.Text))
            {
                foreach (Team team in teamList)
                {
                    for (int i = 0; i < team.PlayersList.Count; i++)
                    {
                        if (team.PlayersList[i].playerName == textBox_PlayerName.Text)
                        {
                            cekk += 1;
                        }
                    }
                    for (int i = 0; i < team.PlayersList.Count; i++)
                    {
                        if (team.PlayersList[i].playerNum == textBox_PlayerNumber.Text)
                        {
                            cekk += 1;
                        }
                    }
                }
                if (cekk == 0)
                {
                    teamm.teamName = comboBox_Team.SelectedItem.ToString();
                    teamm.PlayersList.Add(new Player
                    {
                        playerName = textBox_PlayerName.Text,
                        playerNum = textBox_PlayerNumber.Text,
                        playerPos = comboBox_PlayerPosition.SelectedItem.ToString()
                    });
                    teamList.Add(teamm);
                    updateListBoxPlayersData();
                    textBox_PlayerName.Clear();
                    textBox_PlayerNumber.Clear();
                }
                else
                {
                    MessageBox.Show("Player name/number already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            Team teammm = new Team();
            if (listBox_PlayerData.Items.Count > 11) 
            {
                listBox_PlayerData.Items.RemoveAt(listBox_PlayerData.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Unable to remove player, must be at least 11 player", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


