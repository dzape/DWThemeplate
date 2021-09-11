using System;

namespace DWWebApp.Core
{
    public class Developer
    {
        private int _devid;
        public int devId { 
            get
            {
                return _devid;
            }
            set
            {
                _devid = value;
            }
        }
       
        private string _devusername;
        public string devUsername { 
            get
            {
                return _devusername;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    _devusername = value;
                }
            }
        }

        private int _devyears;
        public int devYears
        {
            get
            {
                return _devyears;
            }
            set
            {
                if(value > 0)
                _devyears = value;
            }
        }

        private string _devabout;
        public string devAbout
        {
            get
            {
                return _devabout;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
                    _devabout = value;
            }
        }
    
    }
}
