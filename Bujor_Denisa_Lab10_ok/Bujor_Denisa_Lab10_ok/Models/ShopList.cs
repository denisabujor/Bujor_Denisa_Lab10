﻿using System;
using SQLite;

namespace Bujor_Denisa_Lab10_ok.Models
{
    public class ShopList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}