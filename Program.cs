using System;

// "Издательство"
public interface IPublisher
{
    string GetBookTitle();
    string GetAuthor();
}

// "Пользователь"
public interface IUser
{
    string GetUserName();
    string GetPassword();
}

// "Товар"
public interface IProduct
{
    void BuyByUser(User user);
}

public interface IBook : IPublisher
{
    DateTime GetPublicationDate();
    int GetNumberOfPages();
}

public class Book : IBook
{
    private string title;
    private string author;
    private DateTime publicationDate;
    private int numberOfPages;

    public Book(string title, string author, DateTime publicationDate, int numberOfPages)
    {
        this.title = title;
        this.author = author;
        this.publicationDate = publicationDate;
        this.numberOfPages = numberOfPages;
    }

    public string GetBookTitle()
    {
        return title;
    }

    public string GetAuthor()
    {
        return author;
    }

    public DateTime GetPublicationDate()
    {
        return publicationDate;
    }

    public int GetNumberOfPages()
    {
        return numberOfPages;
    }
}

public class User : IUser
{
    private string userName;
    private string password;

    public User(string userName, string password)
    {
        this.userName = userName;
        this.password = password;
    }

    public string GetUserName()
    {
        return userName;
    }

    public string GetPassword()
    {
        return password;
    }
}

public class Product : IProduct
{
    private string productName;
    private string productDescription;

    public Product(string productName, string productDescription)
    {
        this.productName = productName;
        this.productDescription = productDescription;
    }

    public void BuyByUser(User user)
    {
        Console.WriteLine($"{user.GetUserName()} купил {productName}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var book1 = new Book("Волшебник страны Оз", "Виктор Флеминг", new DateTime(1955, 1, 1), 200);
        var book2 = new Book("Волшебник Изумрудного города", "А. М. Волков", new DateTime(1939, 1, 1), 100);

        var user1 = new User("Павел", "1234");
        var user2 = new User("Виктор", "5678");

        var product1 = new Product("Волшебник страны Оз", "Виктор Флеминг");
        var product2 = new Product("Волшебник Изумрудного города", "А. М. Волков");

        product1.BuyByUser(user1);
        product2.BuyByUser(user2);

    }
}

