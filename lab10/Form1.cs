using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;

namespace lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        class Player : IComparable
        {
            public string Name { get; set; }
            public int WaitingTime { get; set; }
            public int VehicleType { get; set; }
            public Player(string Name, int WaitingTime, int VehicleType)
            {
                this.Name = Name;
                this.WaitingTime = WaitingTime;
                this.VehicleType = VehicleType;
            }

            public int CompareTo(object obj)
            {
                Player p = obj as Player;
                if (p != null)
                {
                    return p.WaitingTime.CompareTo(this.WaitingTime);
                }
                else
                {
                    throw new Exception("Cannot to compare");
                }
            }
        }

        class Card : IComparable
        {
            public string Name { get; set; }
            public int HealthPlayer { get; set; }
            public int VehicleType { get; set; }
            public Card(string Name, int HealthPlayer, int VehicleType)
            {
                this.Name = Name;
                this.HealthPlayer = HealthPlayer;
                this.VehicleType = VehicleType;
            }

            public int CompareTo(object obj)
            {
                Card card = obj as Card;
                if (card != null)
                {
                    return card.HealthPlayer.CompareTo(this.HealthPlayer);
                }
                else
                {
                    throw new Exception("Cannot to compare");
                }
            }

            public string Print(object obj)
            {
                return "HealthPlayer = " + HealthPlayer;
            }
        }
    }
    class Car
    {
        public int Speed { get; set; }
        Car(int speed)
        {
            Speed = speed;
        }
    }
}
