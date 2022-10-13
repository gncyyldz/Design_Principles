using Single_Responsibility_Principle;

namespace Single_Responsibility_Principle_IdealCode;
class Database
{
    public void Connect()
    {
        //...
        Console.WriteLine("Veritabanı bağlantısı sağlanmıştır.");
    }
    public void Disconnect()
    {
        //...
        Console.WriteLine("Veritabanı bağlantısı kesilmiştir.");
    }
    public string State { get; set; }
}

class PersonService
{
    public List<Person> GetPersons()
    {
        return new() {
            new(){ Name = "Hilmi", Surname = "Celayir" },
            new(){ Name = "Mustafa", Surname = "Yıldız" },
            new(){ Name = "Cafer", Surname = "Muiddinoğlu" }
        };
    }
}