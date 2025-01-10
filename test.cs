using System;


public class Publication
{
    public string title;
    public int price;
    public int copies;

    public Publication()
    {
        Console.WriteLine("Publication created");
    }

    /**
     * Sell a copy of the publication
     */
    public void SellCopy()
    {
        // TODO: implement later
    }
}

public class Book : Publication
{
    public string author { get; set; }

    public Book()
    {
        Console.WriteLine("Book created");
    }

    public void orderCopy()
    {
        // TODO: implement later
    }
}

public class Magazine : Publication
{
    public int orderQty;
    public int currIssue;

    public void adjustQty()
    {
        //
    }

    public void RecNewIssue()
    {
        //
    }
}
    Book book = new Book();







    