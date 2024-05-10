using System;

interface IPublishing
{
    string Title { get; set; }
    string Author { get; set; }
}

interface ILiteraryWork : IPublishing
{
    DateTime ReleaseDate { get; set; }
    int Pages { get; set; }
}

class LiteraryWork : ILiteraryWork
{
    public string Title { get; set; }
    public string Author { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int Pages { get; set; }
}

interface IUserAccount
{
    string Username { get; set; }
    string Password { get; set; }
}

class UserAccount : IUserAccount
{
    public string Username { get; set; }
    public string Password { get; set; }
}

class ProductUser : IUserAccount, ILiteraryWork
{
    public string Title { get; set; }
    public string Author { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int Pages { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    public void Purchase()
    {
        Console.WriteLine($"{Username} купил книгу \"{Title}\".");
    }
}

class Program
{
    static void Main(string[] args)
    {
        LiteraryWork book1 = new LiteraryWork
        {
            Title = "Волшебник Изумрудного города",
            Author = "А. М. Волков",
            ReleaseDate = new DateTime(1939, 1, 1),
            Pages = 450
        };

        LiteraryWork book2 = new LiteraryWork
        {
            Title = "Волшебник страны Оз",
            Author = "Виктор Флеминг",
            ReleaseDate = DateTime.Now,
            Pages = 300
        };

        UserAccount user1 = new UserAccount
        {
            Username = "Павел",
            Password = "12345"
        };

        UserAccount user2 = new UserAccount
        {
            Username = "Максим",
            Password = "45678"
        };

        ProductUser productUser = new ProductUser
        {
            Title = book1.Title,
            Author = book1.Author,
            ReleaseDate = book1.ReleaseDate,
            Pages = book1.Pages,
            Username = user1.Username,
            Password = user1.Password
        };

        productUser.Purchase();
    }
}
