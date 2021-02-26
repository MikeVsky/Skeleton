using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsStock
    { 
        //private data member for available
        private Boolean mAvailable;
        //public property for availbale
        public bool Available
        {
            get
            {
                //return the private data
                return mAvailable;
            }
            set
            {
                mAvailable = value;
            }
        }
        //private data member for sneaker description
        private string mSneakerDescription;
        //public data member for sneaker description
        public string SneakerDescription
        {
            get
            {
                //return the private data
                return mSneakerDescription; 
            }
            set
            {
                mSneakerDescription = value;
            }
        }
        //private data member for sneaker colour
        private string mSneakerColour;
        //public data member for sneaker colour
        public string SneakerColour 
        {
            get
            {
                //return the private data
                return mSneakerColour; 
            }
            set
            {
                mSneakerColour = value;
            }
        }

        //private data member for sneaker description
        private int mSneakerSize;
        //public data member for sneaker description
        public int SneakerSize
        {
            get
            {
                //return the private data
                return mSneakerSize;
            }
            set
            {
                mSneakerSize = value;
            }
        }

        //private data member for sneaker description
        private double mPrice;
        //public data member for sneaker description
        public double Price
        {
            get
            {
                //return the private data
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        public int SneakerId
        {
            get
            {
                //this line of code sends data out of property
                return mSneakerId;
            }
            set
            {
                //this line of code allows data in property
                mSneakerId = value;
            }
        }
            

        public bool Find(int SneakerId)
        {
            //set private data member to test data value
            mSneakerId = 3;

            mSneakerDescription = "Test Description";

            mSneakerColour = "Red";

            mSneakerSize = 8;

            mPrice = 124.99;

            mAvailable = true;

            //always return true
            return true;
        }

        private Int32 mSneakerId;
    }

    
}