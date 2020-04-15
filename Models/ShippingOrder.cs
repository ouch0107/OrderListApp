using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace interview.Models
{
    public class ShippingOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public ShippingOrderStatus Status { get; set; }
        public DateTime CreatedTime { get; set; }

        public enum ShippingOrderStatus
        {
            New = 0,
            arrived = 1,
            sendBack = 2
        }
        
        [JsonIgnore]
        public virtual Order Order { get; set; }
    }
}