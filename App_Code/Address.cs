using EDUnited.Attributes;
using System;

namespace EDUnited
{
    /// <summary>
    /// Summary description for Address
    /// </summary>
    [Serializable()]
    public class Address
    {
        #region Members

        private string sStreet = String.Empty;
        private string sCity = String.Empty;
        private string sState = String.Empty;
        private string sZipcode = String.Empty;
        private bool bisMailingAddress = false;

        #endregion

        #region Constructors

        public Address() { }

        public Address(string sStreet, string sCity, string sState, string sZipcode, bool bisMailingAddress) 
        {
            Street = sStreet;
            City = sCity;
            State = sState;
            Zipcode = sZipcode;
            IsMailingAddress = bisMailingAddress;
        }

        #endregion

        #region Properties

        [Description("Street")]
        public string Street
        {
            get { return sStreet; }
            set { sStreet = value; }
        }

        [Description("City")]
        public string City
        {
            get { return sCity; }
            set { sCity = value; }
        }

        [Description("State")]
        public string State
        {
            get { return sState; }
            set { sState = value; }
        }

        [Description("Zipcode")]
        public string Zipcode
        {
            get { return sZipcode; }
            set { sZipcode = value; }
        }

        [Description("Is Mailing Address")]
        public bool IsMailingAddress
        {
            get { return bisMailingAddress; }
            set { bisMailingAddress = value; }
        }

        #endregion
    }
}