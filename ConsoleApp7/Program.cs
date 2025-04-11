using ConsoleApp7;

class Program
{
    static void Main(string[] args)
    {
        //FeaturesСтудент
        FeaturesStudent student1 = new FeaturesStudent("Иванов Иван Иванович", "Группа-101", "123456", "123-456-789 00");
        Console.WriteLine(student1.Info);

        //MethodСтудент
        MethodСтудент student2 = new MethodСтудент("Петров Петр Петрович", "Группа-102", "654321", "987-654-321 00\n\n");
        Console.WriteLine(student2.GetInfo());



        //FeaturesКотик
        FeaturesKotik cat1 = new FeaturesKotik("Вискас", "Сиамский", 25.5, 4.2, "Владислав");
        Console.WriteLine(cat1.Information);

        //MethodКотик
        MethodKotik cat2 = new MethodKotik("Лешка", "Шотландец", 30.0, 5.0, "Софья\n\n");
        Console.WriteLine(cat2.GetInformation());


        //FeaturesКинотеатр
        FeaturesCinema movie1 = new FeaturesCinema("Ждун", 410, 150, "1");
        Console.WriteLine(movie1.Information);

        //MethodКинотеатр
        MethodCinema movie2 = new MethodCinema("Марвел", 400, 200, "2\n");
        Console.WriteLine(movie2.GetInformation());



        //Создание котика
        Cat cat = new Cat("Юна", 4.5, "Британка", new DateTime(2020, 5, 15));
        Console.WriteLine(cat.GetInfo());
        Console.WriteLine($"Поймала ли кошка мышь? {cat.CatchMouse()}");

        //Созданиепопугайчика
        Parrot parrot = new Parrot("Кеша", 0.3, "Ара", new DateTime(2019, 8, 10));
        Console.WriteLine(parrot.GetInfo());



        //башня
        Tower tower = new Tower("башня", 10, 20, 5.0);
        Console.WriteLine(tower.GetInfo());
        Console.WriteLine($"доход за одну поездку (вместимость по умолчанию): {tower.CalculateRevenue()}");
        Console.WriteLine($"Доход за одну поездку (15 человек): {tower.CalculateRevenue(15)}");

        //американские горки
        RollerCoaster rollerCoaster = new RollerCoaster("американские горки", 5, 30, 10.0);
        Console.WriteLine(rollerCoaster.GetInfo());
        Console.WriteLine($"Доход за одну поездку (вместимость по умолчанию): {rollerCoaster.CalculateRevenue()}");
        Console.WriteLine($"Доход за одну поездку (25 человек): {rollerCoaster.CalculateRevenue(25)}\n");


        //блюдо
        Dish dish = new Dish("Паста", 450, "Италия", 600, 300);
        Console.WriteLine(dish.GetInfo());
        Console.WriteLine($"Цена за грамм: {dish.CalculatePricePerGram():F2} RUB/g");

        // Создание экземпляра напитка
        Drink drink = new Drink("Апельсиновый сок", 200, "Россия", 500);
        Console.WriteLine(drink.GetInfo());
        Console.WriteLine($"Цена со скидкой (20%): {drink.CalculateDiscountedPrice(20):F2}RUB");

    }
}
