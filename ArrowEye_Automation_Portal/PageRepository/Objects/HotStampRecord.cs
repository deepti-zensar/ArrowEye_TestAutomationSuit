using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowEye_Automation_Portal.PageRepository.Objects
{
    public class HotStampRecord
    {
        private string _name;

        private string _description;

        private string _partNumber;

        public string Name { get { return _name; } set { this._name = value; } }

        public string Description { get { return _description; } set { this._description = value; } }

        public string PartNumber { get { return _partNumber; } set { this._partNumber = value; } }
    }

    
}
