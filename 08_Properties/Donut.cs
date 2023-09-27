//* Properties

//* Gives the developer the ability to have read/write methods on variable containers w/n the class

//* public Type VariableName {get;set;}

//* {get;set;} this is shorthand for read/write methods

//* Use Pascal-Casing EveryFirstLetterIsCapitalized

namespace _08_Properties
{
    public class Donut
    {
        #region Private backing Field 
       
        private string _donutType;
        private string _Filling;

        #endregion

        #region Properties...these are Attributes of a class
        //* prop
        public string Filling { get; set; }
        // public string Filling 
        // { 
        //     get
        //     {
                 //* read only
        //         return _Filling.ToUpper();
        //     } 
        //     set
        //     {
        //         if(value != null)
        //         {
        //             _Filling = value;
        //         }
        //     }
        //  }
        public string Topping {get;set;}
        public decimal Price {get;set;} = .25m;
        public bool IsSpecial { get; set; } = false;
        public int TestProperty { get; private set; }  //* read-only

        #endregion

        #region Constructors. What we use to make an object class on the fly
        public Donut()
        {
            _donutType = "Plane Jane";
        }
        //* lets create some Method Overloads...
        public Donut(string donutType)
        {
            _donutType = donutType; 
        }

        //* full-constructor
        public Donut(string donutType, string filling,string topping, bool isSpecial, decimal price)
        {
            _donutType = donutType;
            Filling = filling;
            Topping = topping;
            IsSpecial = isSpecial;
            Price = price;
        }

        #endregion

        #region Get/Set Methods that will be uesed for reading and writing purposes

        //* this is our "Getter" (read-only) method
        public string GetDonutType()
        {
            return _donutType;
        }

        //* this is our "setter" (write-only) method
        public void SetDonutType(string donutType)
        {
            _donutType = donutType;
        }

        #endregion

        #region Special Price Calculation
        private decimal CalculateSpecialPrice(bool isSpecial)
        {
            if(isSpecial)
            {
                return Price*2;
            }else
            {
                return Price;
            }
        }
        #endregion
        
        #region overriding ToString()
        public override string ToString()
        {
            return $"This donut is {this.GetDonutType()}\n full of {this.Filling}\n and topped with {this.Topping}\n for ${CalculateSpecialPrice(this.IsSpecial)}";
        }
        #endregion
    }
}