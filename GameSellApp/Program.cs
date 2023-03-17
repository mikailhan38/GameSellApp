using GameSellApp;

internal class Program
{
    private static void Main(string[] args)
    {
        Customer customer1 = new Customer();
        Game game1 = new Game();
        Campaing campaing1 = new Campaing();
        CustomerManager manager1 = new CustomerManager();

        customer1.FirstName = "Mikail";
        customer1.LastName = "Lale";
        customer1.DateOfBirthYear = 1988;
        customer1.TcKimlikNo = 12345678901;
        customer1.Mail = "mikail.lale@outlook.com";
        manager1.Add(customer1);

        game1.GameName = "Araba Yarışı";
        game1.Price = 100;
        game1.About = "Açık Dünyada yarışın";

        campaing1.CampaingName = "%40 bahar indirimi";
        campaing1.Discount = 40;

        SellManager sellManager = new SellManager(campaing1, customer1, game1);
        
    }
}