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

namespace activity_lookup_base_manufacture_modeling_lb1
{

    public partial class Form1 : Form
    {
        private int N1max = 120, N1 = 120, N2 = 20, N3 = 100, N4 = 80,
                    t1 = 60, t2 = 60, t3 = 60, t4 = 60,
                    t0 = 0, dt = 20,
                    M = 10,
                    tmax = 1800,      
            //  tmax = 30 * 24 * 60,
                    detailsTransAmount = 0;

        

        List<Component> K;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BeginImitation();
            dgvModelingProtocol.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            while (t0 < tmax)
            {
                string modelEvents = "";
                List<ExActivity> initiatedActivitys;
                do
                {
                    initiatedActivitys = GetInitiatedActivitys();
                    foreach (ExActivity exActivity in initiatedActivitys)
                    {
                        exActivity.algoritm();
                        modelEvents +=exActivity.ToString();

                    }
                } while (initiatedActivitys.Count != 0);
                OutputModelState(modelEvents);
                t0 += dt;
            }
        }

        private void BeginImitation()
        {
            K = new List<Component>(5);
            for (int i = 0; i < 5; i++){
                K.Add(new Component()
                {
                    activities = new List<ExActivity>()
                });
            }


            // K_1
            K[0].activities.Add(new ExActivity()
            {
                algoritm = () =>
                {
                    N1 -= N2;
                    SetInitiateTime(K[1], K[1].activities[0].tau);
                    K[0].t += t1;
                },
                tau = t1,
                IsInitiate = () => N1 >= N2,
                description = $"Цех получил {N2} комплектов деталей"
            });
            K[0].t = t1;


            // K_2
            K[1].activities.Add(new ExActivity() {
                algoritm = () => {
                    SetInitiateTime(K[3], K[3].activities[0].tau);
                    K[1].t = double.PositiveInfinity;
                },
                tau = t2,
                IsInitiate = () => N1 <= N3,
                description = $"Заявка на {N4} деталей сформирована"
            });

            // K_3
            K[2].activities.Add(new ExActivity()
            {
                algoritm = () =>
                {
                    N1 = N1max;
                    K[2].t = double.PositiveInfinity;
                },
                tau = t4,
                IsInitiate = () => N1 >= N1max,
                description =  $"{N1 - N1max} деталей отправлены обратно в цен. ск."
            });

            // K_4
            K[3].activities.Add(new ExActivity()
            {
                algoritm = () => { 
                    SetInitiateTime(K[4], K[4].activities[0].tau); 
                    K[3].t = double.PositiveInfinity; 
                },
                tau = t3,
                IsInitiate = () => true,
                description = $"{N4} деталей укомплектованы цен. ск."
            });

            // K_5
            K[4].activities.Add(new ExActivity() {
                algoritm = () => {
                    N1 += N4;
                    SetInitiateTime(K[3], K[3].activities[0].tau);
                    K[4].t = double.PositiveInfinity;
                },
                tau = t4,
                IsInitiate = () => true,
                description = $"{N4} деталей доставлены"
            });

        }

        private List<ExActivity> GetInitiatedActivitys()
        {
            List<ExActivity> initiatedActivities = new List<ExActivity>();
            while (true)
            {
                foreach (Component k in K)
                {
                    if (k.t <= t0)
                    {
                        foreach (ExActivity activity in k.activities)
                        {
                            if (activity.IsInitiate())
                            {
                                initiatedActivities.Add(activity);
                            }
                        }
                    }
                }
                return initiatedActivities;
            }
        }

        private void SetInitiateTime(Component K, double time) {
            double newTime = t0 + time;
            if(K.t > newTime)
                K.t = newTime; 
        }

        private void OutputModelState(string modelEvents)
        {
            int rowId = dgvModelingProtocol.Rows.Add();
            DataGridViewRow row = dgvModelingProtocol.Rows[rowId];

            row.Cells["colModelTime"].Value = t0.ToString();
            row.Cells["colN1"].Value = N1.ToString();
            row.Cells["ColModelEvent"].Value = modelEvents;

            int detailsOnRoad = 0;
            row.Cells["coldetailsOnRoad"].Value = "???";
            row.Cells["colGuildStatus"].Value = K[0].t + K[0].activities[0].tau > t0? "Работает": "Простаивает";


        }
    }

}
