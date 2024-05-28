using DataStructures.Arrays;

ArraysCode arraysCode = new ArraysCode();
bool exit = false;


while (!exit)
{
    Console.WriteLine("Ana Menü:");
    Console.WriteLine("1. Dizi Oluştur");
    Console.WriteLine("2. Mevcut Diziyi Elemanları Görüntüle");
    Console.WriteLine("3. Diziye Eleman Ekle");
    Console.WriteLine("4. Diziyi Sil");
    Console.WriteLine("5. Çıkış");
    Console.Write("Seçiminizi yapın: ");


    int choice = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    switch(choice)
    {
        case 1:
            Console.Write("Dizi Boyutu Giriniz");
            int size = Convert.ToInt32(Console.ReadLine());
            arraysCode.CreateArray(size);
            break;
        case 2:
            arraysCode.DisplayArray();
            break;
        case 3:
            Console.Write("Ekleyeceğiniz indeks: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ekleyeceğiniz değer: ");
            int value = Convert.ToInt32(Console.ReadLine());
            arraysCode.AddElement(index, value);
            break;
        case 4:
            arraysCode.DeleteArray();
            break;

        case 5:
            exit = true;
            break;

        default:
            Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
            break;
    }
    if (!exit)
    {
        Console.WriteLine("\nAna menüye dönmek için bir tuşa basın...");
        Console.ReadKey();
        Console.Clear();
    }
}
    