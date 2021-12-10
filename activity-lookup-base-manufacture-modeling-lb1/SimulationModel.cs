using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity_lookup_base_manufacture_modeling_lb1
{
    static class SimulationModel
    {
        public static double speed = 0;
        public static int N1max, N2, N3, N4, N1,
                   t1, t2, t3, t4,
                   M,
                   tmax, t0, dt,
                   detailsTransAmount;

        private static int detailsOnRoad;
        private static int outcoming = 0, incoming = 0;
        private static bool guildWorking = false;
        public static List<List<int>> events = new List<List<int>>();
        public static int DeatilsOnRoad
        {
            get 
            {
                return incoming + outcoming;
            }
            set
            {
                detailsOnRoad = value;
            }
        }
        
        private static List<Activity> activities;
       
        static SimulationModel()
        {
            dt = 20;
            M = 10;
            // tmax = 30 * 24 * 60;
            tmax = 2000;
        }

        static public List<Activity> GetInitiatedActivitys()
        {
            List<Activity> initiatedActivities = new List<Activity>();
            foreach (Activity activity in activities)
            {
                if (activity.t <= t0)
                {
                    if (activity.IsInitiate())
                        initiatedActivities.Add(activity);
                    else
                    {
                        activity.DropTime();
                    }
                }
            }
            return initiatedActivities;
        }

        public static void UnblockAllDependent(Activity invoked)
        {
            if(invoked.dependent != null)
                foreach (Activity activity in invoked.dependent)
                {
                    if (activity.blocked)
                        activity.blocked = false;
                }
        }

        static public void InitiateActivitys()
        {
            outcoming = 0;
            incoming = 0;
            events.Clear();

            activities = new List<Activity>(5);
            for (int i = 0; i < 6; i++)
            {
                activities.Add(new Activity());
            }
            // Activity_0
            activities[0].algoritm = () =>
            {
                N1 -= N2;
            };
            activities[0].tau = t1;
            activities[0].condition = () => N1 >= N2;
            activities[0].eventDescription = () => "Цех получил "+ N2 + " комплектов деталей";
            activities[0].followings = new Dictionary<Activity, bool>();
            activities[0].followings.Add(activities[0], false);
            activities[0].followings.Add(activities[1], false);
           
           
            activities[0].Fire();


            // Activity_1
            activities[1].algoritm = () => {
                ;
            };
            activities[1].tau = t2;
            activities[1].condition = () => N1 <= N3;
            activities[1].eventDescription = () => "Заявка на " + N4 + " деталей сформирована";
            activities[1].followings = new Dictionary<Activity, bool>();
            activities[1].followings.Add(activities[3], true);

            // Activity_2
            activities[2].algoritm = () => { };
            activities[2].tau = t4;
            activities[2].condition = () => true;
            activities[2].eventDescription = () => "Возвращенные детали прибыли в цен. ск.";
            activities[2].followings = null;
            activities[2].OnDone = () => outcoming = 0;

            // Activity_3
            activities[3].algoritm = () =>
            {
                ;
            };
            activities[3].tau = t3;
            activities[3].condition = () => true;
            activities[3].eventDescription = () => $"{N4} деталей укомплектованы цен. ск.";
            activities[3].followings = new Dictionary<Activity, bool>();
            activities[3].followings.Add(activities[4], false);

            // Activity_4
            activities[4].algoritm = () => {
                N1 += N4;
            };
            activities[4].tau = t4;
            activities[4].condition = () => true;
            activities[4].eventDescription = () => $"{N4} деталей доставлены";
            activities[4].followings = new Dictionary<Activity, bool>();
            activities[4].followings.Add(activities[5], false);
            activities[4].followings.Add(activities[0], false);
            activities[4].dependent = new List<Activity>();
            activities[4].dependent.Add(activities[1]);
            activities[4].OnFire = () => incoming = N4;
            activities[4].OnDone = () => incoming = 0;

            // Activity_5
            activities[5].algoritm = () => N1 = N1max;
            activities[5].tau = 0;
            activities[5].eventDescription = () => $"{N1 - N1max} деталей отправлены обратно в цен. ск.";
            activities[5].condition = () => N1 > N1max;
            activities[5].followings = new Dictionary<Activity, bool>();
            activities[5].followings.Add(activities[2], false);
            activities[5].OnFire = () => outcoming = N1 - N1max;
            
        }

        public static bool IsGuildWorking()
        {
            int lastEvent = -1;
            for (int i = events.Count - 1; i >= 0; i--)
            {
                if (events[i].IndexOf(0) != -1)
                {
                    lastEvent = i;
                    break;
                }
            }

            if (lastEvent == -1) 
                return false;
            else if (t0/dt - lastEvent + 1 <= activities[0].tau/dt) 
                return true;
            else 
                return false;
        }

        public static int GetIndexOfActivity(Activity activity)
        {
            return activities.IndexOf(activity);
        }
    }
}
