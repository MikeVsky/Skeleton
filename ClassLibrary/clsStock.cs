using System;

namespace ClassLibrary
{
    public class clsStock
    { 
        public bool Available { get; set; }
        public string SneakerDescription { get; set; }
        public string SneakerColour { get; set; }
        public int SneakerSize { get; set; }
        public double Price { get; set; }
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
            //always return true
            return true;
        }

        private Int32 mSneakerId;
    }

    
}