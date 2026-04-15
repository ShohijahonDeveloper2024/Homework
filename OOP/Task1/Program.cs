using System;
using Homework.Classes;

class Programm
{
  static void Main()
  {
    BOOK book = new BOOK(
      bookName: "Hamsa",
      page: "350",
      price: "46",
      author: "Navoiy");

    book.FirstBook(
      author: "A. Romiy",
      bookName: "Ichingdagi ichingdadur",
      price: "340",
      pages: "1500");

    book.SecondBook(
      author: "Napalion Xill",
      bookName: "O'yla va boy bo'l",
      pages: "300",
      price: "20"
    );
    book.ThirdBook(
      author: "Brayin Tracy",
      bookName: "Muvaqatga erishishning 21 usuli ",
      price: "120",
      pages: "180");

    book.FourthBook(
      author: "Bodo Shefer",
      bookName: "G'oliblik qonuniyatlari",
      price: "12",
      pages: "240"
    );


  }



}
