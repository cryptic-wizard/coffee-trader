using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;

namespace CoffeeTraderAPI.Models
{
    public class Stock
    {
        public string Name { get; set; }
        public StockType Type { get; set; }
        [Key]
        public string Token { get; private set; }

        public enum StockType : int
        {
            Brick      ,
            Wool       ,
            Lumber     ,
            Sugar      ,
            Coffee     ,
            Corn       ,
            Milk       ,
            Beef       ,
            Eggs       ,
            Wheat      ,
            Aluminum   ,
            Iron       ,
            Copper     ,
            Silver     ,
            Gold       ,
        }
        
        public static Dictionary<string, StockType> Dictionary = 
            Enum.GetValues(typeof(StockType))
            .Cast<StockType>()
            .ToDictionary(t => t.ToString(), t => t, StringComparer.InvariantCultureIgnoreCase);

        public Stock()
        {
            byte[] token = new byte[32];
            new RNGCryptoServiceProvider().GetBytes(token);
            Token = Convert.ToBase64String(token);
        }
    }
}
