using System;
using System.Collections.Generic;
using System.Text;

namespace DrinkApp
{
    class Drink
    {
        //private instance variable
        private string mornDrink;

        //setter
        public void SetDrink (string drinkName) 
        {
            mornDrink = drinkName;
        }

        //getter
        public string GetDrink()
        {
            return mornDrink;
        }


    }

}
