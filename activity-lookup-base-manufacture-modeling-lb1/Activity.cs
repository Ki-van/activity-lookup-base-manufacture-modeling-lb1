using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity_lookup_base_manufacture_modeling_lb1
{
    class Activity
    {

        public Action algoritm;

        /// <summary>
        ///     duration of algoritm
        /// </summary>
        public float tau;
        
        public Func<bool> condition;
        
        /// <summary>
        /// initiate time, set by another activity
        /// </summary>
        public double t;
        /// <summary>
        /// bool - is need to block this activity after firing the following Activivty
        /// </summary>
        public Dictionary<Activity, bool> followings;
        public List<Activity> dependent;
        public Func<string> eventDescription;
        public Action OnFire = null;
      
        public Action OnDone = null;
        public bool blocked = false;
        
        public Activity()
        {
            DropTime();
        }

        public void Invoke()
        {
            this.algoritm();
            if(OnDone != null)
                OnDone();
            SimulationModel.UnblockAllDependent(this);
            DropTime();
            FireFollowings();
        }

        public bool IsInitiate()
        {
            return !blocked && condition();
        }

        private void FireFollowings()
        {
            if(followings?.Count > 0)
            {
                foreach (KeyValuePair<Activity, bool> follow in followings)
                {
                    if (double.IsPositiveInfinity(follow.Key.t))
                    {
                        if (follow.Key.IsInitiate())
                        {
                            follow.Key.t = SimulationModel.t0 + follow.Key.tau;
                            follow.Key.OnFire?.Invoke();
                            if (follow.Value)
                                this.blocked = true;
                        }
                    }
                }
            }
        }

        public void Fire()
        {
            double newTime = SimulationModel.t0 + tau;
            if (t > newTime)
                t = newTime;
        }

        public void DropTime()
        {
            t = double.PositiveInfinity;
        }
        public override string ToString()
        {
            return eventDescription() + Environment.NewLine;
        }
    }
}
