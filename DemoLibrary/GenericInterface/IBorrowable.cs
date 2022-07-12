namespace DemoLibrary
{
    public interface IBorrowable
    {
        public int CheckOutDurationInDays { get; set; }
        public string Borrower { get; set; }
        public DateTime BorrowDate { get; set; }

        public void CheckOut(string borrower);
        public void CheckIn();
        DateTime GetDueDate();
    }
}