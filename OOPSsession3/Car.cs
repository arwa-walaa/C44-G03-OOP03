using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSsession3
{
     class Car
    {
        #region Attributes
        //private int id;
        //private string? model;
        //private double speed;

        #endregion


        #region Properties
        public int id { get; set; }
        public string? model { get; set; }
        public double speed { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Car ID: {id}, Model: {model}, Speed: {speed} km/h";
        }
        #endregion
        #region Constructors
      
        public Car(int id, string model, double speed)
        {
            this.id = id;
            this.model = model;
            this.speed = speed;
            Console.WriteLine("1st CTOR");
        }

        public Car(int id, string model): this(id, model, 360)
        {
           Console.WriteLine("2nd CTOR");
        } 


        public Car(int id) : this(id, "BMW", 360)
        {
            Console.WriteLine("3rd CTOR");
        }
        #endregion


    }
}
