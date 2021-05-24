namespace ToolLibrary
{
    public class Tool : iTool
    {
        private string name;
        private int quantity;
        private int availableQuantity;
        private int noBorrowings;
        private MemberCollection borrowers = new();

        public Tool()
        {

        }

        public Tool(string name, int quantity, int availableQuantity, int noBorrowings)
        {
            this.name = name;
            this.quantity = quantity;
            this.availableQuantity = availableQuantity;
            this.noBorrowings = noBorrowings;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Quantity {
            get { return quantity; }
            set { quantity = value; }
        }

        public int AvailableQuantity
        {
            get { return availableQuantity; }
            set { availableQuantity = value; }
        }

        public int NoBorrowings
        {
            get { return noBorrowings; }
            set { noBorrowings = value; }
        }

        public MemberCollection GetBorrowers
        {
            get { return borrowers; }
        }

        public void addBorrower(Member Member)
        {
            borrowers.add(Member);
        }

        public void deleteBorrower(Member Member)
        {
            borrowers.delete(Member);
        }
        public override string ToString()
        {
            return name + "".PadRight(25 - name.Length) + quantity.ToString() + "".PadRight(20 - quantity.ToString().Length)
            + availableQuantity.ToString() + "".PadRight(20 - availableQuantity.ToString().Length) + noBorrowings.ToString();
        }
    }
}
