using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;

namespace CoffeeTraderAPI.Models
{
    public class Receipt
    {
        public string User1 { get; set; }
        public string User2 { get; set; }

        [ForeignKey("User1Stocks")]
        public ICollection<Stock> User1Stocks { get; set; }
        [ForeignKey("User2Stocks")]
        public ICollection<Stock> User2Stocks { get; set; }

        [Key]
        public string Token { get; private set; }

        public Receipt()
        {
            byte[] token = new byte[32];
            new RNGCryptoServiceProvider().GetBytes(token);
            Token = Convert.ToBase64String(token);
        }
    }
}
