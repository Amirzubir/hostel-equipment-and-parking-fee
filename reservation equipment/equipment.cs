using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assgmnttttt_oop
{
    class equipment
    {
        private string _fee;
        private string _equipment;
        private string _vehicleType;
        private string _noplate;
        private int _parkingNo;

        public string Fee
        {
            get{return _fee;}
            set{_fee = value;}
        }

        public string Equipment
        {
            get{return _equipment;}
            set{_equipment = value;}
        }

        public string VehicleType
        {
            get{return _vehicleType;}
            set{_vehicleType = value;}
        }

        public string Noplate
        {
            get{return _noplate;}
            set{_noplate = value;}
        }

        public int ParkingNo
        {
            get{return _parkingNo;}
            set{_parkingNo = value;}
        }
    }
}
