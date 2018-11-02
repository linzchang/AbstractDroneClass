using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDroneClassApp
{
    abstract class Drone
    {
        #region Data Members
        private int _totalFlyTime;
        private int _totalDistance;
        #endregion

        #region Properties
        public int TotalFlyTime
        {
            set
            {
                _totalFlyTime = value;
            }
            get
            {
                if (_totalFlyTime <= 30 && _totalFlyTime > 0)
                {
                    return _totalFlyTime;
                }
                else
                {
                    return _totalFlyTime = 1;
                }
            }
        }

        public int TotalDistance
        {
            set
            {
                _totalDistance = value;
            }
            get
            {
                if (_totalDistance <= 20 && _totalDistance > 0)
                {
                    return _totalDistance;
                }
                else
                {
                    return _totalDistance = 1;
                }
                
            }
        }
        #endregion

        #region Constructor
        public Drone(int totalFlyTime, int totalDistance)
        {
            _totalFlyTime = totalFlyTime;
            _totalDistance = totalDistance;
        }

        public Drone()
        {
            _totalFlyTime = 1;
            _totalDistance = 1;
        }
        #endregion

        #region Methods
        public virtual int FlightSpeed()
        {
            int calculatedSpeed;
            calculatedSpeed = (TotalDistance / TotalFlyTime);
            //Speed in feet/minute
            return calculatedSpeed;
        }
        #endregion
    }
}
