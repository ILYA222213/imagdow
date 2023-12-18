using System.Diagnostics;

internal class Program
{
    private static async Task Main(string args)
    {
        HttpClient client = new(); // Создание экземпляра HttpClient

        Console.WriteLine("Введите ссылку для скачивания картинки: ");
        string nameWebsite = Console.ReadLine(); // Ввод пользователем ссылки для скачивания картинки

        HttpResponseMessage response = await client.GetAsync(nameWebsite); // Выполнение HTTP GET запроса для получения картинки
        byte data = await response.Content.ReadAsByteArrayAsync(); // Чтение данных картинки в виде массива байтов

        await File.WriteAllBytesAsync("C:\\Users\\ilruz\\OneDrive\\Рабочий стол\\image.jpg", data); // Сохранение картинки на жесткий диск

        Process.Start(new ProcessStartInfo { FileName = "C:\\Users\\ilruz\\OneDrive\\Рабочий стол\\image.jpg", UseShellExecute = true }); // Открытие картинки с помощью программы по умолчанию
    }
}
