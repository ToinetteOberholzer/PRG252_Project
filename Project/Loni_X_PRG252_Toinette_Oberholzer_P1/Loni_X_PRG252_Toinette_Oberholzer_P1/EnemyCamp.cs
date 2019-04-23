using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loni_X_PRG252_Toinette_Oberholzer_P1
{
    class EnemyCamp
    {
        private int buildingID, buildingCap, buildingDamage;
        private string buildingName;

        public int BuildingID
        {
            get
            {
                return buildingID;
            }

            set
            {
                buildingID = value;
            }
        }
        public string BuildingName
        {
            get
            {
                return buildingName;
            }

            set
            {
                buildingName = value;
            }
        }
        public int BuildingCap
               {
                   get
                   {
                        return buildingCap;
                   }

                    set
                   {
                        buildingCap = value;
                   }
               }
        public int BuildingDamage
        {
            get
            {
                return buildingDamage;
            }

            set
            {
                buildingDamage = value;
            }
        }
       

        
        public EnemyCamp()
        {

        }
        public EnemyCamp(int buildingID, string buildingName, int buildingCap, int buildingDamage)
        {
            this.BuildingID = buildingID;
            this.BuildingName = buildingName;
            this.BuildingCap = buildingCap;
            this.BuildingDamage = buildingDamage;
        }
    }
}
