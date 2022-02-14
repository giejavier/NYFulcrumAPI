using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Properties.Data.Models;
using Properties.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NYFulcrumAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PropertiesController : ControllerBase
    {
        private PropertyRepository properties = new PropertyRepository();

        [HttpGet]
        public IEnumerable<PropertyListing> GetAllPropertyListings()
        {
            return properties.GetAllPropertyListings();
        }

        [HttpGet("{id}")]
        public BidAmounts GetBidAmounts(int id)
        {
            return properties.GetBidAmounts(id);
        }

        [HttpGet("{id}")]
        public Bids GetBids(int id)
        {
            return properties.GetBids(id);
        }

        [HttpGet("{id}")]
        public Property GetProperty(int id)
        {
            return properties.GetProperty(id);
        }

        [HttpGet("{id}")]
        public PropertyListing GetPropertyListing(int id)
        {
            return properties.GetPropertyListing(id);
        }
    }
}
