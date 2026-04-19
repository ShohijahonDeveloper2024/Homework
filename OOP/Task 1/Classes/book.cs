namespace Homework.Classes
{
  class BOOK
  {
    public string Pages { get; set; }
    public string Author { get; set; }
    public string Price { get; set; }
    public string BookName { get; set; }

    public BOOK(
      string page,
      string author,
      string price,
      string bookName)
    {
      Pages = page;
      Author = author;
      Price = price;
      BookName = bookName;

    }

    public void FirstBook(
      string pages,
      string author,
      string price,
      string bookName)
    {
      Console.WriteLine("The first book: ");
      Console.WriteLine($"Author : {author} \n Price: {price} $ \nBookName: \"{bookName}\"\n Page: {pages}");
    }

    public void SecondBook(
     string pages,
     string author,
     string price,
     string bookName)
    {
      Console.WriteLine("The second book: ");
      Console.WriteLine($"Author : {author} \n Price: {price} $ \nBookName: \"{bookName}\"\n Page: {pages}");
    }
    public void ThirdBook(
      string pages,
      string author,
      string price,
      string bookName)
    {
      Console.WriteLine("The third book: ");
      Console.WriteLine($"Author : {author} \n Price: {price} $ \nBookName: \"{bookName}\"\n Page: {pages}");

    }
    public void FourthBook(
      string pages,
      string author,
      string price,
      string bookName)
    {
      Console.WriteLine("The fourth book: ");
      Console.WriteLine($"Author : {author} \n Price: {price} $ \nBookName: \"{bookName}\"\n Page: {pages}");
    }


  }
}
