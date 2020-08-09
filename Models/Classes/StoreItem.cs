namespace StoreSite.Models.Classes
{
    public class StoreItem
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public string DescriptionS { get; set; }

        public string DescriptionL { get; set; }

        public string ImageS { get; set; }

        public string ImageL { get; set; }

        public int Pricing { get; set; }

        public int[] RelatedItems { get; set; }

        public enum Type
        {
            Public,             // Available to all   
            Member,             // Available to all signed in
            Admin,              // Avaiable to administrators only
            Hidden              // Available to none (Discontinued)
        }
    }
}
