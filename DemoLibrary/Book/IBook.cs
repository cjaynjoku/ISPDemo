namespace DemoLibrary
{
    public interface IBook: ILibraryItem
    {
        public string Author { get; set; }
        public int Pages { get; set; }
    }
}