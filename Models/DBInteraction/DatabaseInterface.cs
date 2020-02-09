namespace StoreSite.Models.DBInteraction
{
    interface IDatabaseInterface
    {

        public bool Add();

        public bool Delete();

        public bool Edit();

        public void Details();

        public void ListAll();

        public void FilterEntries();
    }
}
