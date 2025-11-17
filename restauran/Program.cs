namespace RestaurantApp;

public class Program
{
    public static void Main(string[] args)
    {
        MenuManager menuManager = new();
        OrderManager orderManager = new();

        Dish dish1 = new(DishCategory.ПершаСтрава, 1, "Борщ", 50.0m, "Український традиційний борщ з пампушками");
        Dish dish2 = new(DishCategory.ДругаСтрава, 2, "Котлета по-київськи", 120.0m, "Соковита куряча котлета з вершковим маслом");
        Dish dish3 = new(DishCategory.Десерт, 3, "Наполеон", 80.0m, "Смачний торт з листкового тіста з кремом");

        menuManager.AddMenuItem(dish1);
        menuManager.AddMenuItem(dish2);
        menuManager.AddMenuItem(dish3);

        Bevarage bevarage1 = new(1, "Чай", 30, "Чорний чай з лимоном", 0.5, false);
        Bevarage bevarage2 = new(2, "Пиво", 60, "Світле пиво", 0.5, true);

        menuManager.AddMenuItem(bevarage1);
        menuManager.AddMenuItem(bevarage2);

        while(true)
        {
            Console.WriteLine("Вас вітає ресторан! Ось доступні опції:");
            Console.WriteLine("1. Показати меню");
            Console.WriteLine("2. Створити нове замовлення");
            Console.WriteLine("3. Додати позицію до замовлення");
            Console.WriteLine("4. Видалити позицію з замовлення");
            Console.WriteLine("5. Змінити статус замовлення");
            Console.WriteLine("6. Показати всі замовлення");
            Console.WriteLine("7. Демонстрація Upcast/Downcast");
            Console.WriteLine("8. Вийти");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                Console.WriteLine(menuManager.DisplayFullMenu());
                break;

                case "2":
                Console.WriteLine("Введiть номер столика");
                if(int.TryParse(Console.ReadLine(), out int tableNumber))
                {

                Order newOrder = orderManager.CreateNewOrder(tableNumber);
                Console.WriteLine($"Замовлення с номеров {newOrder.Id}");

                }
                else
                {
                    Console.WriteLine("Некоректний номер столика");
                }
                break;

                case "3":
                Console.WriteLine("Введiть номер замовлення");
                if(!int.TryParse(Console.ReadLine(), out int orderId)) {Console.WriteLine("Некоректний номер замовлення"); break; }


                Order order = orderManager.FindOrderById(orderId);
                if(order == null) {Console.WriteLine("Замовлення не знайдено"); break;}

                Console.WriteLine("Введіть ID позиції меню для додавання: ");
                if(!int.TryParse(Console.ReadLine(), out int itemId)) {Console.WriteLine("Некоректний ID позиції"); break;}

                MenuItem item = menuManager.FindItemById(itemId);
                if(item == null) {Console.WriteLine("Позицiя не знайдена"); break;}

                order.AddItemInOrder(item);
                Console.WriteLine("Позицiя успiшно додана");
                Console.WriteLine($"Нова сума {order.CalculateTotalCost()}");
                break;

                case "4":
                Console.WriteLine("Введiть номер замовлення");
                if(!int.TryParse(Console.ReadLine(), out int removeOrderId)) {Console.WriteLine("Некоректний номер замовлення"); break;};

                Order removeOrder = orderManager.FindOrderById(removeOrderId);
                if(removeOrder == null) {Console.WriteLine("Замовлення не знайдено"); break;}

                Console.WriteLine("Введіть ID позиції меню для видалення: ");
                if(!int.TryParse(Console.ReadLine(), out int removeItemId)) {Console.WriteLine("Некоректний ID позиції"); break;}
                
                MenuItem removeItem = menuManager.FindItemById(removeItemId);
                removeOrder.RemoveItemFromOrder(removeItem);
                Console.WriteLine("Позицiя успiшно видалена");
                break;

                case "5":
                Console.WriteLine("Введiть номер замовлення");
                if(!int.TryParse(Console.ReadLine(), out int statusOrderId)) {Console.WriteLine("Некоректний номер замовлення"); break;};

                Order newStatusOrder = orderManager.FindOrderById(statusOrderId);
                if(newStatusOrder == null) {Console.WriteLine("Замовлення не знайдено"); break;}

                Console.WriteLine("Введiть новий статус замовлення (0-Очікується, 1-Готується, 2-Завершено, 3-Відмінено: ");
                if (int.TryParse(Console.ReadLine(), out int newStatusInt))
                {
                    if(newStatusInt == 0)
                        {
                            orderManager.ChangeStatus(statusOrderId, OrderStatus.Очікується);
                        }
                    else if(newStatusInt == 1)
                        {
                            orderManager.ChangeStatus(statusOrderId, OrderStatus.Готується);
                        }
                    else if(newStatusInt == 2)
                        {
                            orderManager.ChangeStatus(statusOrderId, OrderStatus.Завершено);
                        }
                    else if(newStatusInt == 3)
                        {
                            orderManager.ChangeStatus(statusOrderId, OrderStatus.Відмінено);
                        }
                    else
                        {
                            Console.WriteLine("Некоректний статус.");
                            break;
                        }
                }
                else
                {
                    Console.WriteLine("Некоректний статус.");
                }
                break;

                case "6":
                Console.WriteLine(orderManager.DisplayActiveOrder());
                break;

                case "7":
                Console.WriteLine("\n--- ДЕМОНСТРАЦІЯ UPCAST/DOWNCAST ---");
    
                MenuItem itemToCast = menuManager.FindItemById(2); 

                if (itemToCast == null)
                {
                    Console.WriteLine("Позиція меню з ID 2 не знайдена для демонстрації.");
                    break;
                }
    
                Console.WriteLine($"Знайдено: '{itemToCast.Name}' (тип: {itemToCast.GetType().Name})");
                Console.WriteLine("Це UPCAST: об'єкт Beverage зберігається як загальний MenuItem.");
    
                if (itemToCast is Bevarage beverage)
                {
                    Console.WriteLine("\n Успішний DOWNCAST!");
                    Console.WriteLine($"Об'єкт приведено до типу {beverage.GetType().Name}.");
        
                    Console.WriteLine($"Специфічна властивість: Об'єм: {beverage.Volume} мл");
                }
                else
                {
                    Console.WriteLine("Приведення типу (DOWNCAST) неможливе (це не напій).");
                }
                break;

                case "8":
                Console.WriteLine("Дякуємо за вiдвiдування нашого ресторану!");
                return;

                default:
                Console.WriteLine("Невiрна команда");
                break;
            }
        }
    }   
}