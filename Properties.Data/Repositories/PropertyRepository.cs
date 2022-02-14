using Properties.Data.Interfaces;
using Properties.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties.Data.Repositories
{
    public class PropertyRepository : IPropertyRepository
    {
        #region Properties
        private const string ActiveStatus = "Active";

        private List<Property> properties = new List<Property>() {
            new Property { PropertyId = 1, Line1 = "123 Test St.",  City = "Chicago", State = "IL", ZipCode = "111111", MarketValue = 10000, ReservePrice = 1000 },
            new Property { PropertyId = 2, Line1 = "123 Clone St.",  City = "San Francisco", State = "CA", ZipCode = "222222", MarketValue = 20000, ReservePrice = 2000 },
            new Property { PropertyId = 3, Line1 = "123 Fulcrum St.",  City = "New York", State = "NY", ZipCode = "333333", MarketValue = 30000, ReservePrice = 3000 },
            new Property { PropertyId = 4, Line1 = "123 Phil St.",  City = "Detroit", State = "MI", ZipCode = "444444", MarketValue = 40000, ReservePrice = 4000 }
        };

        private List<Bid> bids = new List<Bid>(){
            // 1
            new Bid { BidId = 1, PropertyId = 1,  BidPrice = 20000, BidDateTime = new DateTime(2022, 1, 1, 1, 0, 0), Status = ActiveStatus },
            new Bid { BidId = 2, PropertyId = 1,  BidPrice = 20000, BidDateTime = new DateTime(2022, 1, 1, 2, 0, 0), Status = ActiveStatus },
            new Bid { BidId = 3, PropertyId = 1,  BidPrice = 20000, BidDateTime = new DateTime(2022, 1, 1, 3, 0, 0), Status = ActiveStatus },
            new Bid { BidId = 4, PropertyId = 1,  BidPrice = 20000, BidDateTime = new DateTime(2022, 1, 1, 4, 0, 0), Status = ActiveStatus },
            new Bid { BidId = 5, PropertyId = 1,  BidPrice = 20000, BidDateTime = new DateTime(2022, 1, 1, 5, 0, 0), Status = ActiveStatus },
            new Bid { BidId = 6, PropertyId = 1,  BidPrice = 10000, BidDateTime = new DateTime(2022, 1, 1, 6, 0, 0), Status = ActiveStatus },
            new Bid { BidId = 7, PropertyId = 1,  BidPrice = 10000, BidDateTime = new DateTime(2022, 1, 1, 7, 0, 0), Status = ActiveStatus },
            new Bid { BidId = 8, PropertyId = 1,  BidPrice = 10000, BidDateTime = new DateTime(2021, 12, 31, 1, 0, 0), Status = "Expired" },
            new Bid { BidId = 9, PropertyId = 1,  BidPrice = 15000, BidDateTime = new DateTime(2021, 12, 31, 2, 0, 0), Status = "Expired" },
            new Bid { BidId = 10, PropertyId = 1,  BidPrice = 15000, BidDateTime = new DateTime(2021, 12, 31, 3, 0, 0), Status = "Expired" },
            // 2
            new Bid { BidId = 11, PropertyId = 2,  BidPrice = 25000, BidDateTime = new DateTime(2022, 1, 1, 1, 0, 0), Status = ActiveStatus },
            new Bid { BidId = 12, PropertyId = 2,  BidPrice = 25000, BidDateTime = new DateTime(2022, 1, 1, 2, 0, 0), Status = ActiveStatus },
            new Bid { BidId = 13, PropertyId = 2,  BidPrice = 15000, BidDateTime = new DateTime(2022, 1, 1, 3, 0, 0), Status = ActiveStatus },
            new Bid { BidId = 14, PropertyId = 2,  BidPrice = 20000, BidDateTime = new DateTime(2022, 1, 1, 4, 0, 0), Status = ActiveStatus },
            new Bid { BidId = 15, PropertyId = 2,  BidPrice = 20000, BidDateTime = new DateTime(2022, 1, 1, 5, 0, 0), Status = ActiveStatus },
            new Bid { BidId = 16, PropertyId = 2,  BidPrice = 10000, BidDateTime = new DateTime(2022, 1, 1, 6, 0, 0), Status = ActiveStatus },
            new Bid { BidId = 17, PropertyId = 2,  BidPrice = 10000, BidDateTime = new DateTime(2021, 12, 31, 1, 0, 0), Status = "Expired" },
            new Bid { BidId = 18, PropertyId = 2,  BidPrice = 10000, BidDateTime = new DateTime(2021, 12, 31, 2, 0, 0), Status = "Expired" },
            new Bid { BidId = 19, PropertyId = 2,  BidPrice = 15000, BidDateTime = new DateTime(2021, 12, 31, 2, 0, 0), Status = "Expired" },
            new Bid { BidId = 20, PropertyId = 2,  BidPrice = 15000, BidDateTime = new DateTime(2021, 12, 31, 3, 0, 0), Status = "Expired" },
            // 3
            new Bid { BidId = 21, PropertyId = 3,  BidPrice = 30000, BidDateTime = new DateTime(2022, 1, 1, 1, 0, 0), Status = ActiveStatus },
            new Bid { BidId = 22, PropertyId = 3,  BidPrice = 25000, BidDateTime = new DateTime(2022, 1, 1, 2, 0, 0), Status = ActiveStatus },
            new Bid { BidId = 23, PropertyId = 3,  BidPrice = 15000, BidDateTime = new DateTime(2022, 1, 1, 3, 0, 0), Status = ActiveStatus },
            new Bid { BidId = 24, PropertyId = 3,  BidPrice = 20000, BidDateTime = new DateTime(2022, 1, 1, 4, 0, 0), Status = ActiveStatus },
            new Bid { BidId = 25, PropertyId = 3,  BidPrice = 20000, BidDateTime = new DateTime(2022, 1, 1, 5, 0, 0), Status = ActiveStatus },
            new Bid { BidId = 26, PropertyId = 3,  BidPrice = 10000, BidDateTime = new DateTime(2021, 12, 31, 1, 0, 0), Status = "Expired" },
            new Bid { BidId = 27, PropertyId = 3,  BidPrice = 10000, BidDateTime = new DateTime(2021, 12, 31, 2, 0, 0), Status = "Expired" },
            new Bid { BidId = 28, PropertyId = 3,  BidPrice = 10000, BidDateTime = new DateTime(2021, 12, 31, 3, 0, 0), Status = "Expired" },
            new Bid { BidId = 29, PropertyId = 3,  BidPrice = 15000, BidDateTime = new DateTime(2021, 12, 31, 4, 0, 0), Status = "Expired" },
            new Bid { BidId = 30, PropertyId = 3,  BidPrice = 15000, BidDateTime = new DateTime(2021, 12, 31, 5, 0, 0), Status = "Expired" },
            // 4
            new Bid { BidId = 31, PropertyId = 4,  BidPrice = 35000, BidDateTime = new DateTime(2022, 1, 1, 1, 0, 0), Status = ActiveStatus },
            new Bid { BidId = 32, PropertyId = 4,  BidPrice = 35000, BidDateTime = new DateTime(2022, 1, 1, 2, 0, 0), Status = ActiveStatus },
            new Bid { BidId = 33, PropertyId = 4,  BidPrice = 35000, BidDateTime = new DateTime(2022, 1, 1, 3, 0, 0), Status = ActiveStatus },
            new Bid { BidId = 34, PropertyId = 4,  BidPrice = 20000, BidDateTime = new DateTime(2022, 1, 1, 4, 0, 0), Status = ActiveStatus },
            new Bid { BidId = 35, PropertyId = 4,  BidPrice = 20000, BidDateTime = new DateTime(2022, 1, 1, 5, 0, 0), Status = ActiveStatus },
            new Bid { BidId = 36, PropertyId = 4,  BidPrice = 10000, BidDateTime = new DateTime(2022, 1, 1, 6, 0, 0), Status = ActiveStatus },
            new Bid { BidId = 37, PropertyId = 4,  BidPrice = 10000, BidDateTime = new DateTime(2021, 12, 31, 1, 0, 0), Status = "Expired" },
            new Bid { BidId = 38, PropertyId = 4,  BidPrice = 10000, BidDateTime = new DateTime(2021, 12, 31, 1, 0, 0), Status = "Expired" },
            new Bid { BidId = 39, PropertyId = 4,  BidPrice = 15000, BidDateTime = new DateTime(2021, 12, 31, 5, 0, 0), Status = "Expired" },
            new Bid { BidId = 40, PropertyId = 4,  BidPrice = 15000, BidDateTime = new DateTime(2021, 12, 31, 5, 0, 0), Status = "Expired" }
        };
        #endregion

        public List<PropertyListing> GetAllPropertyListings()
        {
            var result = new List<PropertyListing>();

            foreach (var prop in properties)
            {
                var propertyListing = GetPropertyListing(prop.PropertyId);
                result.Add(propertyListing);
            }

            return result;
        }

        public BidAmounts GetBidAmounts(int id)
        {
            var result = new BidAmounts();
            var propBids = bids.Where(x => x.PropertyId == id).ToList();
            var maxBid = propBids.Count > 0 ? propBids.Max(x => x.BidPrice) : 0;
            result.OutbidAmount = string.Format("${0:n0}", maxBid);
            result.ActiveAmount = string.Format("${0:n0}", maxBid);
            result.WinningAmount = string.Format("${0:n0}", maxBid);

            return result;
        }

        public Bids GetBids(int id)
        {
            var result = new Bids();
            var propBids = bids.Where(x => x.PropertyId == id).ToList();
            var maxBid = propBids.Count > 0 ? propBids.Max(x => x.BidPrice) : 0;
            result.OutbidCount = propBids.Where(x => x.Status != ActiveStatus).ToList().Count;
            result.ActiveCount = propBids.Where(x => x.Status == ActiveStatus).ToList().Count;
            result.WinningCount = propBids.Where(x => x.BidPrice == maxBid).ToList().Count;

            return result;
        }

        public Property GetProperty(int id)
        {
            return properties.Where(x => x.PropertyId == id).FirstOrDefault();
        }

        public PropertyListing GetPropertyListing(int id)
        {
            var prop = properties.Where(x => x.PropertyId == id).FirstOrDefault();
            var propBids = bids.Where(x => x.PropertyId == id).ToList();

            var propertyListing = new PropertyListing();
            propertyListing.PropertyId = prop.PropertyId;
            propertyListing.Address = prop.Line1;
            propertyListing.ReservePrice = string.Format("${0:n0}", prop.ReservePrice);
            propertyListing.LastBidAmount = string.Format("${0:n0}", propBids.Count > 0 ? propBids.Max(x => x.BidPrice) : 0);

            if (propBids.Count > 1)
            {
                var priceBids = propBids.OrderByDescending(x => x.BidPrice).Select(x => x.BidPrice).ToArray();
                propertyListing.LastBidAmount = string.Format("${0:n0}", priceBids[0] - priceBids[1]);
            }

            return propertyListing;
        }
    }
}
