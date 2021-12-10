using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

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
                        events.Add(SimulationModel.GetIndexOfActivity(activity));
                    }
                } while (initiatedActivitys.Count != 0);
                OutputModelState(modelEvents);
                SimulationModel.t0 += SimulationModel.dt;
                Thread.Sleep(Convert.ToInt32(SimulationModel.speed * 1000));
            }
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
    }

}
