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
        private int mSneakerId;
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
            //Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for sneaker id to search for
            DB.AddParameter("@SneakerId", SneakerId);
            //execute the stored procedure
            DB.Execute("sproc_tblSneaker_FilterByAddressNo");
            //There should either be 1 or 0 records found
            if (DB.Count == 1)
            {
                //copy the data from database to private data members
                mSneakerId = Convert.ToInt32(DB.DataTable.Rows[0][1]);
                mSneakerDescription = Convert.ToString(DB.DataTable.Rows[0]["Nike Air Force 1"]);
                mSneakerColour = Convert.ToString(DB.DataTable.Rows[0]["White"]);
                mSneakerSize = Convert.ToInt32(DB.DataTable.Rows[0][8]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0][79.99]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0][true]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
       
    
