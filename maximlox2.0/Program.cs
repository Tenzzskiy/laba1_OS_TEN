


namespace ConsoleApp1
{
  class Person
  {
    class Program
    {
      public string Name { get; set; }
      public int Age { get; set; }
    }
    static void Main(string[] args)
    {
    menu:
      Console.WriteLine("     МЕНЮ                     ");
      Console.WriteLine("1.Работа с файлами \n2.Работа с дисками\n3.Работа с файлами JSON");
      string choise = Console.ReadLine();
      switch (choise)
      {

        case "1":
          string txt;
          string path = @"C:\SomeDir2";
          DirectoryInfo dirr = new DirectoryInfo(path);
          if (!dirr.Exists)
          {
            dirr.Create();
          }
          Console.WriteLine("Введите текст для записи в файл");
          txt = Console.ReadLine();


          using (FileStream fstream = new FileStream($"{path}/task1.txt", FileMode.OpenOrCreate))
          {

            byte[] array = System.Text.Encoding.Default.GetBytes(txt);

            fstream.Write(array, 0, array.Length);
            Console.WriteLine("Текст записан в файл");

            File.Delete($"{path}/task1.txt");
            Console.WriteLine("Файл удален");

          }
          break;
        case "2":
          DriveInfo[] drives = DriveInfo.GetDrives();
          foreach (DriveInfo drive in drives)
          {
            Console.WriteLine($"Название: {drive.Name}");
            Console.WriteLine($"Тип: {drive.DriveType}");
            if (drive.IsReady)
            {
              Console.WriteLine($"Объем диска: {drive.TotalSize}");
              Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace}");
              Console.WriteLine($"Метка: {drive.VolumeLabel}");
            }
            Console.WriteLine();


          }
          break;
        case "3":
          using (FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
          {

          }

          goto menu;
          Console.ReadLine();
      }
    }
  }
}

