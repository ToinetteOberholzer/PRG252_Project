using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loni_X_PRG252_Toinette_Oberholzer_P1
{
    class Jets
    {
        private int jetID, jetSpeed, jetAlt, jetCam, jetGun, jetAmmo, jetBomb, jetDamage, jetFuel;
        private string jetName;
       

        public int JetID
        {
            get
            {
                return jetID;
            }

            set
            {
                jetID = value;
            }
        }

        public string JetName
        {
            get
            {
                return jetName;
            }

            set
            {
                jetName = value;
            }
        }

        public int JetSpeed
        {
            get
            {
                return jetSpeed;
            }

            set
            {
                jetSpeed = value;
            }
        }

        public int JetAlt
        {
            get
            {
                return jetAlt;
            }

            set
            {
                jetAlt = value;
            }
        }

        public int JetCam
        {
            get
            {
                return jetCam;
            }

            set
            {
                jetCam = value;
            }
        }

        public int JetGun
        {
            get
            {
                return jetGun;
            }

            set
            {
                jetGun = value;
            }
        }

        public int JetAmmo
        {
            get
            {
                return jetAmmo;
            }

            set
            {
                jetAmmo = value;
            }
        }

        public int JetBomb
        {
            get
            {
                return jetBomb;
            }

            set
            {
                jetBomb = value;
            }
        }

        public int JetDamage
        {
            get
            {
                return jetDamage;
            }

            set
            {
                jetDamage = value;
            }
        }

        public int JetFuel
        {
            get
            {
                return jetFuel;
            }

            set
            {
                jetFuel = value;
            }
        }

        public Jets()
        {

        }

        public Jets(int jetID, string jetName, int jetSpeed, int jetAlt, int jetCam, int jetGun, int jetAmmo, int jetBomb, int jetDamage, int jetFuel)
        {
            this.jetID = jetID;
            this.jetName = jetName;
            this.jetSpeed = jetSpeed;
            this.jetAlt = jetAlt;
            this.jetCam = jetCam;
            this.jetGun = jetGun;
            this.jetAmmo = jetAmmo;
            this.jetBomb = jetBomb;
            this.jetDamage = jetDamage;
            this.jetFuel = jetFuel;
        }
    }
}
