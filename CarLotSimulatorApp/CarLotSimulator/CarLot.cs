﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class CarLot
    {
       
        public CarLot()
        {

        }
            
        
        public static int numberOfCars = 1;
       

        public List<Car> CarList { get; set; } = new List<Car>();
        public List<Car> Cars { get; set; } = new List<Car>();

    }
}
