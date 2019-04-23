using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loni_X_PRG252_Toinette_Oberholzer_P1
{
    public partial class Form1 : Form
    {
        DataAccess access = new DataAccess();
        Jets jets = new Jets();
        EnemyCamp enCamp = new EnemyCamp();
        Obstacle obstacles = new Obstacle();
        BindingSource bindsourse = new BindingSource();
        List<Jets> jetsList = new List<Jets>();
        List<EnemyCamp> enCampList = new List<EnemyCamp>();
        List<Obstacle> obstacleList = new List<Obstacle>();
        public Form1()
        {
            InitializeComponent();
        }
        public void HideLabels()
        {
            lblSpy.Hide();
            lblFighter.Hide();
            lblBomber.Hide();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            enCampList = access.ReadCamp();
            bindsourse.DataSource = enCampList;
            dgvCamp.DataSource = bindsourse;
            HideLabels();
        }

        private void cmbJet_SelectedIndexChanged(object sender, EventArgs e)
        {
            HideLabels();
            jetsList = access.ReadJets();
            lblBase.Visible = true;

            if (cmbJet.SelectedIndex == 0)
            {
                foreach (Jets item in jetsList)
                {
                    if (item.JetName.ToString().Equals("SPY"))
                    {
                        lblSpy.Show();
                        lblBase.Top = lblSpy.Top;
                        lblBase.Left = lblSpy.Left;
                        txtJSpeed.Text = item.JetSpeed.ToString();
                        txtJAlt.Text = item.JetAlt.ToString();
                        txtJCam.Text = item.JetCam.ToString();
                        txtJGun.Text = item.JetGun.ToString();
                        txtJAmmo.Text = item.JetAmmo.ToString();
                        txtJBomb.Text = item.JetBomb.ToString();
                        txtJDamage.Text = item.JetDamage.ToString();
                        txtJFuel.Text = item.JetFuel.ToString();
                    }
                }      
           }
           else if (cmbJet.SelectedIndex == 1)
           {
               foreach (Jets item in jetsList)
               {
                   if (item.JetName.ToString().Equals("FIGHTER"))
                    {
                        lblFighter.Show();
                        lblBase.Top = lblFighter.Top;
                        lblBase.Left = lblFighter.Left;
                        txtJSpeed.Text = item.JetSpeed.ToString();
                        txtJAlt.Text = item.JetAlt.ToString();
                        txtJCam.Text = item.JetCam.ToString();
                        txtJGun.Text = item.JetGun.ToString();
                        txtJAmmo.Text = item.JetAmmo.ToString();
                        txtJBomb.Text = item.JetBomb.ToString();
                        txtJDamage.Text = item.JetDamage.ToString();
                        txtJFuel.Text = item.JetFuel.ToString();
                    }
                }
            }
            else if (cmbJet.SelectedIndex == 2)
            {
                foreach (Jets item in jetsList)
                {
                    if (item.JetName.ToString().Equals("BOMBER"))
                    {
                        lblBomber.Show();
                        lblBase.Top = lblBomber.Top;
                        lblBase.Left = lblBomber.Left;
                        txtJSpeed.Text = item.JetSpeed.ToString();
                        txtJAlt.Text = item.JetAlt.ToString();
                        txtJCam.Text = item.JetCam.ToString();
                        txtJGun.Text = item.JetGun.ToString();
                        txtJAmmo.Text = item.JetAmmo.ToString();
                        txtJBomb.Text = item.JetBomb.ToString();
                        txtJDamage.Text = item.JetDamage.ToString();
                        txtJFuel.Text = item.JetFuel.ToString();
                    }
                }
            }
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            bool homeBase = false;
            bool enemyBase = true;
            bool done = true;
            int fuel, damage;
            
            if (cmbJet.SelectedIndex == 0) 
            {
                fuel = int.Parse(txtJFuel.Text);
                damage = int.Parse(txtJDamage.Text);
                while (done)
                {
                if (enemyBase == true)
                {
                    if (lblEnemyBase.Top < lblSpy.Top)
                    {
                        lblSpy.Top = lblSpy.Top - 9;
                        fuel -= 40 ;
                        txtJFuel.Text = fuel.ToString();
                    }

                    if (lblEnemyBase.Left > lblSpy.Left)
                    {
                        lblSpy.Left = lblSpy.Left + 9;
                            fuel-=40;
                            txtJFuel.Text = fuel.ToString();
                        }

                    if (lblEnemyBase.Left < lblSpy.Left)
                    {
                        lblSpy.Left = lblSpy.Left - 9;
                            fuel-=40;
                            txtJFuel.Text = fuel.ToString();
                        }

                    if (lblEnemyBase.Top > lblSpy.Top)
                    {
                        lblSpy.Top = lblSpy.Top + 19;
                            fuel-=40;
                            txtJFuel.Text = fuel.ToString();
                        }


                    if (lblEnemyBase.Top > lblSpy.Top - 9 && lblEnemyBase.Left < lblSpy.Left + 9 && lblEnemyBase.Left > lblSpy.Left - 9 && lblEnemyBase.Top < lblSpy.Top + 9)
                    {
                        enemyBase = false;
                        homeBase = true;
                    }
                }

                if (homeBase == true)
                {
                    if (lblBase.Top < lblSpy.Top)
                    {
                        lblSpy.Top = lblSpy.Top - 9;
                            fuel-=50;
                            txtJFuel.Text = fuel.ToString();
                        }

                    if (lblBase.Left > lblSpy.Left)
                    {
                        lblSpy.Left = lblSpy.Left + 9;
                            fuel-=50;
                            txtJFuel.Text = fuel.ToString();
                        }

                    if (lblBase.Left < lblSpy.Left)
                    {
                        lblSpy.Left = lblSpy.Left - 9;
                            fuel-=50;
                            txtJFuel.Text = fuel.ToString();
                        }

                    if (lblBase.Top > lblSpy.Top)
                    {
                        lblSpy.Top = lblSpy.Top + 9;
                            fuel-=50;
                            txtJFuel.Text = fuel.ToString();
                        }

                    if (lblBase.Top > lblSpy.Top - 9 && lblBase.Left < lblSpy.Left + 9 && lblBase.Left > lblSpy.Left - 9 && lblBase.Top < lblSpy.Top + 9)
                    {
                            done = false;

                            damage = damage - random.Next(0,48);
                            txtJDamage.Text = damage.ToString();

                            MessageBox.Show("Simulation Complete");
                    }
                }
              } 
            }
            else if (cmbJet.SelectedIndex == 1)
            {
                fuel = int.Parse(txtJFuel.Text);
                damage = int.Parse(txtJDamage.Text);
                while (done)
                {
                    if (enemyBase == true)
                    {
                        if (lblEnemyBase.Top < lblFighter.Top)
                        {
                            lblFighter.Top = lblFighter.Top - 5;
                            fuel -= 5;
                            txtJFuel.Text = fuel.ToString();
                        }

                        if (lblEnemyBase.Left > lblSpy.Left)
                        {
                            lblFighter.Left = lblFighter.Left + 5;
                            fuel -= 5;
                            txtJFuel.Text = fuel.ToString();
                        }

                        if (lblEnemyBase.Left < lblSpy.Left)
                        {
                            lblFighter.Left = lblFighter.Left - 5;
                            fuel -= 5;
                            txtJFuel.Text = fuel.ToString();
                        }

                        if (lblEnemyBase.Top > lblSpy.Top)
                        {
                            lblFighter.Top = lblFighter.Top + 5;
                            fuel -= 5;
                            txtJFuel.Text = fuel.ToString();
                        }
                        if (lblEnemyBase.Top > lblFighter.Top - 5 && lblEnemyBase.Left < lblFighter.Left + 5 && lblEnemyBase.Left > lblFighter.Left - 5 && lblEnemyBase.Top < lblFighter.Top + 5)
                        {
                            enemyBase = false;
                            homeBase = true;
                        }
                    }

                    if (homeBase == true)
                    {
                        if (lblBase.Top < lblFighter.Top)
                        {
                            lblFighter.Top = lblFighter.Top - 5;
                            fuel -= 7;
                            txtJFuel.Text = fuel.ToString();
                        }

                        if (lblBase.Left > lblFighter.Left)
                        {
                            lblFighter.Left = lblFighter.Left + 5;
                            fuel -= 7;
                            txtJFuel.Text = fuel.ToString();
                        }

                        if (lblBase.Left < lblFighter.Left)
                        {
                            lblFighter.Left = lblFighter.Left - 5;
                            fuel -= 7;
                            txtJFuel.Text = fuel.ToString();
                        }

                        if (lblBase.Top > lblFighter.Top)
                        {
                            lblFighter.Top = lblFighter.Top + 5;
                            fuel -= 7;
                            txtJFuel.Text = fuel.ToString();
                        }

                        if (lblBase.Top > lblFighter.Top - 5 && lblBase.Left < lblFighter.Left + 5 && lblBase.Left > lblFighter.Left - 5 && lblBase.Top < lblFighter.Top + 5)
                        {
                            done = false;
                            damage = damage - random.Next(0, 120);
                            txtJDamage.Text = damage.ToString();
                            MessageBox.Show("Simulation Complete");
                        }
                    }
                }
            }
            else if (cmbJet.SelectedIndex == 2)
            {
                fuel = int.Parse(txtJFuel.Text);
                damage = int.Parse(txtJDamage.Text);
                while (done)
                {
                    if (enemyBase == true)
                    {
                        if (lblEnemyBase.Top < lblBomber.Top)
                        {
                            lblBomber.Top = lblBomber.Top - 3;
                            fuel --;
                            txtJFuel.Text = fuel.ToString();
                        }

                        if (lblEnemyBase.Left > lblSpy.Left)
                        {
                            lblBomber.Left = lblBomber.Left + 3;
                            fuel --;
                            txtJFuel.Text = fuel.ToString();
                        }

                        if (lblEnemyBase.Left < lblSpy.Left)
                        {
                            lblBomber.Left = lblBomber.Left - 3;
                            fuel --;
                            txtJFuel.Text = fuel.ToString();
                        }

                        if (lblEnemyBase.Top > lblSpy.Top)
                        {
                            lblBomber.Top = lblBomber.Top + 3;
                            fuel --;
                            txtJFuel.Text = fuel.ToString();
                        }


                        if (lblEnemyBase.Top > lblBomber.Top - 3 && lblEnemyBase.Left < lblBomber.Left + 3 && lblEnemyBase.Left > lblBomber.Left - 3 && lblEnemyBase.Top < lblBomber.Top + 3)
                        {
                            enemyBase = false;
                            homeBase = true;
                        }
                    }

                    if (homeBase == true)
                    {
                        if (lblBase.Top < lblBomber.Top)
                        {
                            lblBomber.Top = lblBomber.Top - 3;
                            fuel -= 3;
                            txtJFuel.Text = fuel.ToString();
                        }

                        if (lblBase.Left > lblBomber.Left)
                        {
                            lblBomber.Left = lblBomber.Left + 3;
                            fuel -= 3;
                            txtJFuel.Text = fuel.ToString();
                        }

                        if (lblBase.Left < lblBomber.Left)
                        {
                            lblBomber.Left = lblBomber.Left - 3;
                            fuel -= 3;
                            txtJFuel.Text = fuel.ToString();
                        }

                        if (lblBase.Top > lblBomber.Top)
                        {
                            lblBomber.Top = lblBomber.Top + 3;
                            fuel -= 3;
                            txtJFuel.Text = fuel.ToString();
                        }

                        if (lblBase.Top > lblBomber.Top - 3 && lblBase.Left < lblBomber.Left + 3 && lblBase.Left > lblBomber.Left - 3 && lblBase.Top < lblBomber.Top + 3)
                        {
                            done = false;
                            damage = damage - random.Next(0, 190);
                            txtJDamage.Text = damage.ToString();
                            MessageBox.Show("Simulation Complete");
                        }
                    }
                }
            }
        }
    }
}
