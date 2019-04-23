using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loni_X_PRG252_Toinette_Oberholzer_P1
{
    class Obstacle
    {
        private int obstacleID, obstacleAlt;
        private string obstacleName, obstacleAmmo;

        public int ObstacleID
        {
            get
            {
                return obstacleID;
            }

            set
            {
                obstacleID = value;
            }
        }
        public string ObstacleName
        {
            get
            {
                return obstacleName;
            }

            set
            {
                obstacleName = value;
            }
        }
        public string ObstacleAmmo
        {
            get
            {
                return obstacleAmmo;
            }

            set
            {
                obstacleAmmo = value;
            }
        }
        public int ObstacleAlt
        {
            get
            {
                return obstacleAlt;
            }

            set
            {
                obstacleAlt = value;
            }
        }


        public Obstacle()
        {

        }

        public Obstacle(int obstacleID, string obstacleName, string obstacleAmmo, int obstacleAlt)
        {
            this.ObstacleID = obstacleID;
            this.ObstacleName = obstacleName;
            this.ObstacleAmmo = obstacleAmmo;
            this.ObstacleAlt = obstacleAlt;
        }
    }
}
