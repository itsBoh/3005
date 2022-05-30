using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _3005
{
    public partial class Team : Form
    {
        public Team()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;

        DataTable dtTeam = new DataTable();
        DataTable dtPlayer1 = new DataTable();
        DataTable dtPlayer2 = new DataTable();
        DataTable dtMatch = new DataTable();
        int PosisiSekarang = 0;
        private void Team_Load(object sender, EventArgs e)
        {
            sqlQuery = "select t.team_id, t.team_name, m.manager_name, n.nation, t.home_stadium, t.city, t.capacity from team t left join manager m on t.manager_id = m.manager_id left join nationality n on m.nationality_id = n.nationality_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            Update(0);
        }

        public void Update(int Posisi)
        {
            lbNamaTeam.Text = dtTeam.Rows[Posisi][1].ToString();
            lbManager.Text = dtTeam.Rows[Posisi][2].ToString() + " (" + dtTeam.Rows[Posisi][3] + ")";
            lbSatidum.Text = dtTeam.Rows[Posisi][4].ToString() + ", " + dtTeam.Rows[Posisi][5] + "("+ dtTeam.Rows[Posisi][6] +")";

            dtPlayer1.Clear();
            sqlQuery = "select p.player_name, sum(if(d.`type` = 'GO', +1, 0)) + sum(if(d.`type` = 'GP', +1, 0)) as GO, sum(if(d.`type` = 'GP', +1, 0)) as GP from player p left join dmatch d on p.player_id = d.player_id where p.team_id = '"+ dtTeam.Rows[Posisi][0] +"' group by 1 order by 2 desc;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer1);
            lbTopScorer.Text = dtPlayer1.Rows[0][0] + " " + dtPlayer1.Rows[0][1] + "(" + dtPlayer1.Rows[0][2] + ")";

            dtPlayer2.Clear();
            sqlQuery = "select p.player_name, sum(if(d.`type` = 'CY', +1, 0)) + sum(if(d.`type` = 'CR', +3, 0)) as poin, sum(if(d.`type` = 'CY', +1, 0)) as CY, sum(if(d.`type` = 'CR', +1, 0)) as CR from player p left join dmatch d on p.player_id = d.player_id where p.team_id = '" + dtTeam.Rows[Posisi][0] + "' group by 1 order by 2 desc;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer2);
            lbWorst.Text = dtPlayer2.Rows[0][0] + ", " + dtPlayer2.Rows[0][2] + " Yellow Card and " + dtPlayer2.Rows[0][3] + " Red Card";

            dtMatch.Clear();
            sqlQuery = "select m.match_date, if(m.team_home = '" + dtTeam.Rows[Posisi][0] + "', 'HOME', 'AWAY') as 'HOME / AWAY', concat('vs ', if(m.team_home = '" + dtTeam.Rows[Posisi][0] + "', t2.team_name, t.team_name)) as lawan, if(m.team_home = '" + dtTeam.Rows[Posisi][0] + "', concat(m.goal_home, '-',m.goal_away),concat(m.goal_away, '-',m.goal_home)) as score from `match` m left join team t on m.team_home = t.team_id left join team t2 on m.team_away = t2.team_id where m.team_home = '" + dtTeam.Rows[Posisi][0] + "' or m.team_away = '" + dtTeam.Rows[Posisi][0] + "'order by 1 desc limit 5;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMatch);
            dtgvMatch.DataSource = dtMatch;

            PosisiSekarang = Posisi;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            PosisiSekarang = 0;
            Update(PosisiSekarang);
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang > 0)
            {
                PosisiSekarang--;
                Update(PosisiSekarang);
            }
            else
                MessageBox.Show("Data Sudah Data Pertama");
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang < dtTeam.Rows.Count - 1)
            {
                PosisiSekarang++;
                Update(PosisiSekarang);
            }
            else
                MessageBox.Show("Data Sudah Data Terakhir");
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            PosisiSekarang = dtTeam.Rows.Count - 1;
            Update(PosisiSekarang);
        }
    }
}
