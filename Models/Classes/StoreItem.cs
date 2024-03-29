﻿using System;

namespace StoreSite.Models.Classes
{
    public class StoreItem
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string DescriptionS { get; set; }
        public string DescriptionL { get; set; }
        public string ImageS { get; set; }
        public string ImageL { get; set; }
        public int Pricing { get; set; }
        public Guid? InlcudedDeals { get; set; }
        public string LocationLine1 { get; set; }
        public string LocationLine2 { get; set; }

        public enum Type
        {
            Public,             // Available to all   
            Member,             // Available to all signed in
            Admin,              // Avaiable to administrators only
            Hidden              // Available to none (Discontinued)
        }
    }
}
