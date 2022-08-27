using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IchirakuRamenShop
{
    public class Customer 
    {

        private string _name;
        public string Name
        { 

            get 
            { 
                return _name; 
            } 
            set 
            {
                _name = value;
            } 
        
        }

        private double _balance;
        public double Balance
        {

            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }

        }

        private string _hungerBar;
        public string HungerBar
        {

            get
            {
                return _hungerBar;
            }
            set
            {
                _hungerBar = value;
            }

        }

        
    }
}
