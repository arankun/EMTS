using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emts.Web.Api.Models {
    public class NewEventV2 {
        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime? StartDate { get; set; }

        public string Category { get; set; }

        public User CreatedBy { get; set; }
    }
}
