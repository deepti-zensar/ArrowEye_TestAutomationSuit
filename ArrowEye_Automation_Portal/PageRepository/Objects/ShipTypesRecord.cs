using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowEye_Automation_Portal.PageRepository.Objects
{
    public class ShipTypesRecord
    {
        private string _ShipType;

        private string _description;

        private string asiShipType;

        public string ShipType { get { return _ShipType; } set { this._ShipType = value; } }

        public string Description { get { return _description; } set { this._description = value; } }

        public string ASIShipType { get { return asiShipType; } set { this.asiShipType = value; } }
    }

    
}
