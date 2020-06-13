using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesPart1
{
    class BoatShop : IBoatInStore
    {
        private int draugt;
        private int maxSpeed;
        private VesselType type;
        private string title;
        private SpeedUnit speedUnit;
        private double price;
        private DateTime date;
        string photo;


        public int Draught { get => draugt; set => draugt = value > 0 ? value : 1; }
        public VesselType Type { get => type; set => type = value; }
        public string Title { get => title; set => title = value; }
        public int MaxSpeed { get => maxSpeed; set => maxSpeed = value > 0 ? value : 1; }
        public SpeedUnit SpeedUnit { get => speedUnit; set => speedUnit = value; }
        public double Price { get => price; set => price = value > 0 ? value : 1; }
        public DateTime Date { get => date; set => date = value; }
        public string Photo { get => photo; set => photo = value; }

        public override string ToString()
        {
            return $"{Title} ({Type}), {MaxSpeed} {SpeedUnit}, {Draught} m, {Date} : {Price} m\n";
        }
    }

}
