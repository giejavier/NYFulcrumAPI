using Properties.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties.Data.Interfaces
{
    interface IPropertyRepository
    {
        public List<PropertyListing> GetAllPropertyListings();
        public Property GetProperty(int id);
        public PropertyListing GetPropertyListing(int id);
        public Bids GetBids(int id);
        public BidAmounts GetBidAmounts(int id);
    }
}
