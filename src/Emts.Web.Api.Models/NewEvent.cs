using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emts.Web.Api.Models {
    public class NewEvent {
        public string Title { get; set; }

        public string Subject { get; set; }

        public DateTime? StartDate { get; set; }

        public string Category { get; set; }

        public string ZipCode { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public string Address1 { get; set; }
    }
}
