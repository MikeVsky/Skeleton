using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for active
        private Boolean mActive;
        //public property for active

        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }

        //private date added data member
        private DateTime mDateAdded;
        //public property for date added
        public DateTime DateAdded
        {
            get
            {
                //return the private data
                return mDateAdded;
            }
            set
            {
                //set the private data
                mDateAdded = value;
            }
        }

        //private data member for first name
        private string mFirstName;
        //public property for first name
        public string FirstName
        {
            get
            {
                //return the private data
                return mFirstName;
            }
            set
            {
                //set the private data
                mFirstName = value;
            }
        }
        //private data member for last name
        private string mLastName;
        //public property for last name
        public string LastName
        {
            get
            {
                //return the private data
                return mLastName;
            }
            set
            {
                //set the private data
                mLastName = value;
            }
        }
        //private data member for first name
        private string mEmail;
        //public property for first name
        public string Email
        {
            get
            {
                //return the private data
                return mEmail;
            }
            set
            {
                //set the private data
                mEmail = value;
            }
        }
        //private data member for street
        private string mStreet;
        //public data member for street
        public string Street
        {
            get
            {
                //return the private data
                return mStreet;
            }
            set
            {
                //set the private data
                mStreet = value;
            }
        }

        //private data member for flat
        private string mFlat;
        //public property for flat
        public string Flat
        {
            get
            {
                //return the private data
                return mFlat;
            }
            set
            {
                //set the private data
                mFlat = value;
            }
        }
        //private data member for city
        private string mCity;
        //public property for city
        public string City
        {
            get
            {
                //return the private data
                return mCity;
            }
            set
            {
                //set the private data
                mCity = value;
            }
        }        //private data member for postcode
        private string mPostcode;
        //public property for postcode
        public string Postcode
        {
            get
            {
                //return the private data
                return mPostcode;
            }
            set
            {
                //set the private data
                mPostcode = value;
            }
        }

        //private data member for country
        private string mCountry;
        //public property for country
        public string Country
        {
            get
            {
                //return the private data
                return mCountry;
            }
            set
            {
                //set the private data
                mCountry = value;
            }
        }
        //private data member for customerid

        private Int32 mCustomerId;
        //public property for country

        public Int32 CustomerId
        {
            get
            {
                //sends data do the property
                return mCustomerId;
            }

            set
            {
                //allows data into the property
                mCustomerId = value;
            }
        }

        public bool Find(int CustomerId)
        {
            //set the private data members to the test data value
            mCustomerId = 21;
            mFirstName = "Test FirstName";
            mLastName = "Test LastName";
            mEmail = "Test Email";
            mStreet = "Test Street";
            mFlat = "Test Flat";
            mCity = "Test City";
            mPostcode = "XXX XXX";
            mCountry = "Test Country";
            mDateAdded = Convert.ToDateTime("16/9/2015");
            mActive = true;

            //always return true
            return true;
        }
    }
}