using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem
{
    abstract class vehicle
    {

        public string regNumber { get; }

        public string Color { get; }

        protected vehicle( string regNumber,string Color)
        {
            RegNumber=RegNumber
            Color=color    
        }   

    public abstract dubble calculateParkingFee(int parkedSeconds);
    public abstract dubble spotsNedded { get; }
}
    class Car ; vehicle
{
