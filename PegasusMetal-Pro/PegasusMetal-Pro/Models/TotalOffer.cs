using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PegasusMetal_Pro.Models
{
    public class TotalOffer
    {
        public Offer Offer { get; set; }
        public List<OfferItem> OfferItems { get; set; }
    }
}
