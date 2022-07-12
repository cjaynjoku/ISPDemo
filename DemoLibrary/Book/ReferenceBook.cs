namespace DemoLibrary
{
    public class ReferenceBook: IBook
    {
        public string LibraryID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
    }
}