using System;
using System.Text;

namespace Lab6_Sliusarchuk
{
    class Tablet // Оголошення класу, що описує структуру об'єкта "Планшет".
    {
        public string Brand;         // Поле для зберігання назви виробника (текст).
        public string Model;         // Поле для зберігання назви моделі (текст).
        public double ScreenSize;    // Поле для діагоналі екрану (дробове число).
        public int StorageGB;        // Поле для об'єму пам'яті в ГБ (ціле число).
        public int BatteryCapacity;  // Поле для ємності батареї (ціле число).
        public bool SupportsSimCard; // Поле логічного типу: чи підтримує SIM-карту 
        public double Price;         // Поле для зберігання ціни (дробове число).

        public double GetPricePerGB() // Метод класу для розрахунку вартості одного гігабайта.
        {
            if (StorageGB == 0) return 0; // Перевірка, щоб уникнути ділення на нуль, якщо пам'ять не вказана.
            return Price / StorageGB;     // Повертає результат ділення ціни на об'єм пам'яті.
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // Вмикає підтримку українських літер у консолі.
            Console.Write("Введіть виробника : "); // Виводить запит на введення бренду.
            string sBrand = Console.ReadLine(); // Зчитує введений текст у змінну.
            Console.Write("Введіть модель: "); // Виводить запит на введення моделі.
            string sModel = Console.ReadLine(); // Зчитує введений текст у змінну.
            Console.Write("Введіть діагональ екрану (дюйми): "); // Виводить запит на введення діагоналі.
            double sScreenSize = double.Parse(Console.ReadLine()); // Перетворює введений рядок у дробове число.
            Console.Write("Введіть об'єм пам'яті (GB): "); // Виводить запит на введення пам'яті.
            int sStorage = int.Parse(Console.ReadLine()); // Перетворює введений рядок у ціле число.
            Console.Write("Введіть ємність акумулятора (mAh): "); // Виводить запит на введення ємності батареї.
            int sBattery = int.Parse(Console.ReadLine()); // Перетворює введений рядок у ціле число.
            Console.Write("Введіть ціну (грн): "); // Виводить запит на введення ціни.
            double sPrice = double.Parse(Console.ReadLine()); // Перетворює введений рядок у дробове число.
            Console.Write("Чи підтримує SIM-карту? (+ так, - ні): "); // Виводить інструкцію для введення статусу SIM.
            ConsoleKeyInfo keySim = Console.ReadKey(); // Зчитує натискання однієї клавіші без Enter.
            Console.WriteLine(); // Переводить курсор на новий рядок для коректного відображення подальшого тексту.
            Tablet myTablet = new Tablet(); // Створює новий екземпляр (об'єкт) класу Tablet у пам'яті.
            myTablet.Brand = sBrand; // Записує введене значення бренду у відповідне поле об'єкта.
            myTablet.Model = sModel; // Записує введене значення моделі у поле об'єкта.
            myTablet.ScreenSize = sScreenSize; // Записує значення діагоналі у поле об'єкта.
            myTablet.StorageGB = sStorage; // Записує значення пам'яті у поле об'єкта.
            myTablet.BatteryCapacity = sBattery; // Записує значення батареї у поле об'єкта.
            myTablet.Price = sPrice; // Записує значення ціни у поле об'єкта.
            myTablet.SupportsSimCard = (keySim.KeyChar == '+'); // Якщо натиснуто '+', записує true, інакше false.
            double pricePerGb = myTablet.GetPricePerGB(); // Викликає метод об'єкта для обчислення вартості за ГБ.
            Console.WriteLine("\n--------------------------------------------------"); // Виводить розділювальну лінію.
            Console.WriteLine("Дані про об'єкт (Планшет):"); // Виводить заголовок блоку результатів.
            Console.WriteLine("--------------------------------------------------"); // Виводить розділювальну лінію.
            Console.WriteLine("Виробник: " + myTablet.Brand); // Виводить значення поля Brand на екран.
            Console.WriteLine("Модель: " + myTablet.Model); // Виводить значення поля Model на екран.
            Console.WriteLine("Діагональ екрану: {0:F1}\"", myTablet.ScreenSize); // Виводить діагональ з точністю 1 знак після коми.
            Console.WriteLine("Пам'ять: " + myTablet.StorageGB + " GB"); // Виводить об'єм пам'яті.
            Console.WriteLine("Батарея: " + myTablet.BatteryCapacity + " mAh"); // Виводить ємність батареї.
            Console.WriteLine("Ціна: {0:F2} грн", myTablet.Price); // Виводить ціну з точністю 2 знаки (копійки).
            Console.WriteLine(myTablet.SupportsSimCard ? "Підтримка SIM: Так" : "Підтримка SIM: Ні"); // Виводить "Так" або "Ні" залежно від значення true/false.
            Console.WriteLine("--------------------------------------------------"); // Виводить розділювальну лінію.
            Console.WriteLine("Вартість 1 ГБ пам'яті у цій моделі: {0:F2} грн", pricePerGb); // Виводить результат роботи методу.
            Console.ReadKey(); // Зупиняє виконання програми, очікуючи натискання будь-якої клавіші.
        }
    }
}