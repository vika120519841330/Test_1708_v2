using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TEST_170819.Models
{
    public class FixRequest
    {
        [Key]
        public int? Id { get; set; }
        public string UserName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public DateTime GetDateTime  { get; set; }
        public string CorrelationId { get; set; }
    }
}