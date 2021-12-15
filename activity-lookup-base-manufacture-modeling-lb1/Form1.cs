using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Timers;
using System.Drawing;

namespace activity_lookup_base_manufacture_modeling_lb1
{

    public partial class Form1 : Form
    {         

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvModelingProtocol.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }

        private void OutputModelState(string modelEvents)
        {
            int rowId = dgvModelingProtocol.Rows.Add();
            DataGridViewRow row = dgvModelingProtocol.Rows[rowId];

            row.Cells["colModelTime"].Value = SimulationModel.t0.ToString();
            row.Cells["colN1"].Value = SimulationModel.N1.ToString();
            row.Cells["ColModelEvent"].Value = modelEvents;
            row.Cells["coldetailsOnRoad"].Value = SimulationModel.DeatilsOnRoad;
            row.Cells["colGuildStatus"].Value = SimulationModel.IsGuildWorking()? "Работает": "Простаивает";

            if (SimulationModel.speed > 0)
            {
               
                if (SimulationModel.IsGuildWorking())
                {
                    lbGuild.BackColor = System.Drawing.Color.LightGreen;
                    lbGuild.Text = "Цех" + Environment.NewLine + SimulationModel.DetailsInGuild().ToString() + " деталей осталось";
                }
                else
                    lbGuild.BackColor = System.Drawing.SystemColors.Control;
                lbGuild.Text = "Цех" + Environment.NewLine + SimulationModel.DetailsInGuild().ToString() + " деталей осталось";
                lbGuild.Refresh();

                if (SimulationModel.IsActivityActive(new int[] { 1, 2 })){
                    lbGuildStorage.BackColor = System.Drawing.Color.LightGreen;
                } else
                    lbGuildStorage.BackColor = System.Drawing.SystemColors.Control;
                lbGuildStorage.Text = "Цеховый склад\n" + SimulationModel.N1 + " деталей";
                lbGuildStorage.Refresh();

                if (SimulationModel.IsActivityActive(new int[] { 3, 4 }))
                {
                    lbCenterStorage.BackColor = System.Drawing.Color.LightGreen;
                }
                else
                    lbCenterStorage.BackColor = System.Drawing.SystemColors.Control;
                lbCenterStorage.Refresh();

                if (SimulationModel.IsActivityActive(4))
                {
                    lbIncomingCaret.Visible = true;
                    lbIncomingCaret.Text = SimulationModel.N4.ToString();
                    int difference = lbCenterStorage.Location.X - lbGuildStorage.Size.Width - lbGuildStorage.Location.X - lbIncomingCaret.Size.Width;
                    lbIncomingCaret.Location = new System.Drawing.Point(-20 + lbGuildStorage.Location.X + lbGuildStorage.Size.Width+5 + (int)(
                         difference / (SimulationModel.t4 / SimulationModel.dt) *
                        ((SimulationModel.activities[4].t - SimulationModel.t0)) / SimulationModel.dt), lbIncomingCaret.Location.Y);
                    lbIncomingCaret.Refresh();

                }
                else
                    lbIncomingCaret.Visible = false;

                if (SimulationModel.IsActivityActive(2))
                {
                    lbOutcomingCaret.Visible = true;
                    lbOutcomingCaret.Text = SimulationModel.outcoming.ToString();
                    int difference = lbCenterStorage.Location.X - lbGuildStorage.Size.Width - lbGuildStorage.Location.X - lbOutcomingCaret.Size.Width;
                    lbOutcomingCaret.Location = new System.Drawing.Point(lbGuildStorage.Location.X + lbGuildStorage.Size.Width + 5 + (int)(
                         difference - difference / (SimulationModel.t4 / SimulationModel.dt) *
                        ((SimulationModel.activities[2].t - SimulationModel.t0)) / SimulationModel.dt), lbOutcomingCaret.Location.Y);
                    lbOutcomingCaret.Refresh();
                }
                else
                    lbOutcomingCaret.Visible = false;

                dgvModelingProtocol.Refresh();
                dgvModelingProtocol.FirstDisplayedScrollingRowIndex = dgvModelingProtocol.RowCount - 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvModelingProtocol.Rows.Clear();
            SimulationModel.t0 = 0;
            SimulationModel.t1 = Convert.ToInt32(udt1.Value);
            SimulationModel.t2 = Convert.ToInt32(udt2.Value);
            SimulationModel.t3 = Convert.ToInt32(udt3.Value);
            SimulationModel.t4 = Convert.ToInt32(udt4.Value);

            SimulationModel.N1 = Convert.ToInt32(udN1.Value);
            SimulationModel.N1max = Convert.ToInt32(udN1.Value);
            SimulationModel.N2 = Convert.ToInt32(udN2.Value);
            SimulationModel.N3 = Convert.ToInt32(udN3.Value);
            SimulationModel.N4 = Convert.ToInt32(udN4.Value);

            SimulationModel.speed = Convert.ToInt32(udImmitationSpeed.Value);

            SimulationModel.InitiateActivitys();

            while (SimulationModel.t0 < SimulationModel.tmax)
            {
                string modelEvents = "";
                List<int> events = new List<int>();
                SimulationModel.events.Add(events);
                List<Activity> initiatedActivitys;
                do
                {
                    initiatedActivitys = SimulationModel.GetInitiatedActivitys();
                    foreach (Activity activity in initiatedActivitys)
                    {
                        modelEvents += activity.ToString();
                        activity.Invoke();
                        int index = SimulationModel.GetIndexOfActivity(activity);
                        events.Add(index); 
 
                    }
                } while (initiatedActivitys.Count != 0);
                OutputModelState(modelEvents);
                if (SimulationModel.IsGuildWorking())
                    SimulationModel.guildWorkingCount++;
                SimulationModel.t0 += SimulationModel.dt;
                SimulationModel.guildTotalLoad += SimulationModel.N1;
                Thread.Sleep(Convert.ToInt32((SimulationModel.speed * 1000)/4));
            }

            OutputModelIndicators();
            tabs.SelectedIndex = 1;
        }

        private void OutputModelIndicators()
        {
            lbAvgLoad.Text = SimulationModel.GetAvgGuildLoad().ToString();
            lbCost.Text = SimulationModel.GetDeatailsTransCost().ToString();
            lbProbobility.Text = SimulationModel.GetDowntimeProbability().ToString();
        }

        private void udN1_ValueChanged(object sender, EventArgs e)
        {
            SimulationModel.N1 = Convert.ToInt32(udN1.Value);
        }

        private void udN2_ValueChanged(object sender, EventArgs e)
        {
            SimulationModel.N2 = Convert.ToInt32(udN2.Value);
        }

        private void udN3_ValueChanged(object sender, EventArgs e)
        {
            SimulationModel.N3 = Convert.ToInt32(udN3.Value);
        }

        private void udN4_ValueChanged(object sender, EventArgs e)
        {
            SimulationModel.N4 = Convert.ToInt32(udN4.Value);
        }

        private void udt1_ValueChanged(object sender, EventArgs e)
        {
            SimulationModel.t1 = Convert.ToInt32(udt1.Value);
        }

        private void udt2_ValueChanged(object sender, EventArgs e)
        {
            SimulationModel.t2 = Convert.ToInt32(udt2.Value);
        }

        private void udt3_ValueChanged(object sender, EventArgs e)
        {
            SimulationModel.t3 = Convert.ToInt32(udt3.Value);
        }

        private void udt4_ValueChanged(object sender, EventArgs e)
        {
            SimulationModel.t4 = Convert.ToInt32(udt4.Value);
        }

        private void udImmitationSpeed_ValueChanged(object sender, EventArgs e)
        {
            SimulationModel.speed = Convert.ToInt32(udImmitationSpeed.Value);
        }

        private void tabIndicators_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
        }

        
    }

}
