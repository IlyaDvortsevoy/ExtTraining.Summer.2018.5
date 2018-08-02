using System.IO;

namespace No8.Solution
{
    // Выделение интерфейса в целях: 1) устранения зависимости типа NetworkPrinter от 
    //                                  конкретной реализации принтера при инъекции через конструктор
    //                               2) возможности создания Moq обхектов на основе интерфейса
    public interface IPrinter
    {
        string Name { get; set; }

        string Model { get; set; }

        string Print(string path);
    }
}
