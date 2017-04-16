using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourist.Tourist
{
    class TouristSetting
    {
        public bool useADB { get; set; }
        public bool useInternet { get; set; }

        public TouristSetting()
        {
            this.useADB = Properties.Settings.Default.useADB;
            this.useInternet = Properties.Settings.Default.useInternet;
        }


    }
}
