namespace Day23Sets
{
    class Program
    {
        public static void Main(string[] args)
        {
            AddressBook myAddressBook = new AddressBook();
            Contacts Contact1 = new Contacts("ares","zeus","olympus","12345678","areszeus@godofgreek.com");
            Contacts Contact2 = new Contacts("athena","Zeus","olympus","12344545","athena@godofgreek.com");
            Contacts Contact3 = new Contacts("Loki","odinson","Asgard","987654321","Loki@godofasgrad.com");

            myAddressBook.AddContact(Contact1);
            myAddressBook.AddContact(Contact2);
            myAddressBook.AddContact(Contact3);
         
        }
    }
}