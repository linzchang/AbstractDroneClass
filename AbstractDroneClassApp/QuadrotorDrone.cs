using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDroneClassApp
{
    class QuadrotorDrone : Drone
    {
        public int TotalFlyTime1
        {
            set
            {
                TotalFlyTime = value;
            }
            get
            {
                if (TotalFlyTime <= 60 && TotalFlyTime > 0)
                {
                    return TotalFlyTime;
                }
                else
                {
                    return TotalFlyTime = 60;
                }
            }
        }

        public int TotalDistance1
        {
            set
            {
                TotalDistance = value;
            }
            get
            {
                if (TotalDistance <= 45 && TotalDistance > 0)
                {
                    return TotalDistance;
                }
                else
                {
                    return TotalDistance = 45;
                }

            }
        }

        #region Constructor
        public QuadrotorDrone(int totalFlyTime, int totalDistance) :base(totalFlyTime, totalDistance)
        {
        }

        public QuadrotorDrone()
        {
            TotalFlyTime1 = 1;
            TotalDistance1 = 1;
        }
        #endregion

        #region Methods
        public override int FlightSpeed()
        {
            int calculatedSpeed = TotalDistance1 / TotalFlyTime1;
            return calculatedSpeed;
        }
        #endregion
    }
}
