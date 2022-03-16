using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TetWebApplication.Models
{
    public class RequestDto
    {
        public int RequestId { get; set; }
        public string RequestType { get; set; }
        public string RequestStatus { get; set; }
        public DateTime CreateDate { get; set; }

    }
}