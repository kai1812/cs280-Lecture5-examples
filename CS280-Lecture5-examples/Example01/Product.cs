using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public class Product
    {
        public string Name;
        private int price;
        private float discount;

        public int Price
        {
            get { return this.price; }

            set
            {
                if (value > 200)
                {
                    this.price = 200;
                }
                else if (value < 39)
                {
                    this.price = 39;
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public float Discount
        {
            get => this.discount;
            set
            {
                if (value > 1.0f)
                {
                    this.discount = 1.0f;
                }
                else if (value < 0.3f)
                {
                    this.discount = 0.3f;
                }
                else
                {
                    this.discount = value;
                }
            }
        }
    }
}