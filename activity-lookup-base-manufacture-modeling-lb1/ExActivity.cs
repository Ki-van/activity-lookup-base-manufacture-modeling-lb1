using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity_lookup_base_manufacture_modeling_lb1
{
    class ExActivity
    {
        public Action algoritm;

        /// <summary>
        ///     duration of algoritm
        /// </summary>
        public float tau;
        public Func<bool> IsInitiate;
        public string description;

        public override string ToString()
        {
            return description + Environment.NewLine;
        }
    }
}
