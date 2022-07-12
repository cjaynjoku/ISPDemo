namespace DemoLibrary
{
    public class Book:IBorrowableBook
    {
        public string LibraryID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int CheckOutDurationInDays { get; set; } = 14;
        public string Borrower { get; set; }
        public DateTime BorrowDate { get; set; }

        public void CheckOut(string borrower)
        {

        }
        public void CheckIn()
        {

        }
        public DateTime GetDueDate()
        {
            return BorrowDate.AddDays(CheckOutDurationInDays);
        }
    }
}