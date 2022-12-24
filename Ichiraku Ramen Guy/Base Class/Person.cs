using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ichiraku_Ramen_Guy.Base_Class
{
    public class Person : BoundProperties
    {

        private string _name;
        private string _money;
        private int _hungerBar;

        public string Name
        {
            get 
            { 
                return _name; 
            }
            set 
            { 
                _name = value; 
                OnPropertyChanged(value);
            }
        }

        public string Money 
        {
            get
            {
                return _money;
            }
            set
            {
                _money = value;
                OnPropertyChanged(value);
            }
        }

        public int hungerBar
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


        public void Eat()
        {

        }

        public void Drink()
        {

        }


    }
}
