using OpenClosed;

var book = new Book("The Horror One", "Turin", 2023, 220, "1602101");
var invoice = new Invoice(book, 2, 0.10, 0.15);

var printer = new InvoicePrinter(invoice);
printer.Print();

InvoicePersistence dbPersistence = new DatabasePersistence();
dbPersistence.Save(invoice);

InvoicePersistence filePersistence = new FilePersistence();
filePersistence.Save(invoice);