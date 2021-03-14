using System;

namespace ConsoleApp1.Transport
{
    public class Bicycle
    {
        public string Brand;
        private int Wheelsize = 275;
        
        public Bicycle()
        {
            
        }
        public Bicycle(string name)
        {
            Brand = name;
        }

        public int GetWheelsize()
        {
            if (Brand == "Merida")
            {
                Wheelsize = 26;
                return Wheelsize;
            }
            if (Brand == "Santa Cruz")
            {
                Wheelsize = 29;
                return Wheelsize;
            }
            //todo: Hometask: Resolve error, try different approaches such as changing brand class variable to enum,
            //todo: ore use additional check with method that will compare enum value and string and return result (probably bool result)
            // if (Brand == BikeBrands.Merida)
            // {
            //     Wheelsize = 29;
            //     return Wheelsize;
            // }
            

            //return Wheelsize;
            throw new InvalidOperationException("Unknown bike brand");
        }

        public void GetBrandWitshSwitchCase(BikeBrands brand)
        {
            
            //todo: hometask : complete switchcase in such way, to return wheelsize for each brand from enum and inplement exeption
            switch (brand)
            {
                case BikeBrands.Gt:
                    return;
                //-----------------
            }
        }

    }
}