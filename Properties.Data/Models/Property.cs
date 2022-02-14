using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties.Data.Models
{
    public class Property
    {
        public int PropertyId { get; set; }
        public string Line1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public int MarketValue { get; set; }
        public int ReservePrice { get; set; }
    }

    public class PropertyListing
    {
        public int PropertyId { get; set; }
        public string Address { get; set; }
        public string LastBidAmount { get; set; }
        public string ReservePrice { get; set; }
    }

    public class Bid
    {
        public int BidId { get; set; }
        public int PropertyId { get; set; }
        public int BidPrice { get; set; }
        public DateTime BidDateTime { get; set; }
        public string Status { get; set; }
    }

    public class Bids
    {
        public int PropertyId { get; set; }
        public int OutbidCount { get; set; }
        public int ActiveCount { get; set; }
        public int WinningCount { get; set; }
    }

    public class BidAmounts
    {
        public int PropertyId { get; set; }
        public string OutbidAmount { get; set; }
        public string ActiveAmount { get; set; }
        public string WinningAmount { get; set; }
    }
}
