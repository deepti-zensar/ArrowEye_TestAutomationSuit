using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowEye_Automation_Portal.PageRepository.Objects
{
    public class IssuingBankRecord
    {
        private string _name;

        private string _ica;

        private string _contactEmail;

        private string _contactName;

        private string _contactPhone;

        private string _country;

        private string _region;
       

        public string Name { get { return _name; } set { this._name = value; } }

        public string ICA { get { return _ica; } set { this._ica = value; } }

        public string ContactEmail { get { return _contactEmail; } set { this._contactEmail = value; } }
  
        public string ContactName { get { return _contactName; } set { this._contactName = value; } }

        public string ContactPhone { get { return _contactPhone; } set { this._contactPhone = value; } }
        public string Country { get { return _country; } set { this._country = value; } }

        public string Region { get { return _region; } set { this._region = value; } }

    }

    
}
