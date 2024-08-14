using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Задача 1: Ресурсы для выживания

        int[] resources = new int[3]; // [0] - еда, [1] - вода, [2] - дерево

        while (true)
        {
            Console.WriteLine("Управление ресурсами:");
            Console.WriteLine("1. Добавить ресурс");
            Console.WriteLine("2. Удалить ресурс");
            Console.WriteLine("3. Просмотреть ресурсы");
            Console.WriteLine("4. Выйти");
            Console.Write("Выберите действие: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 4)
            {
                break;
            }

            switch (choice)
            {
                case 1:
                    AddResource(resources);
                    break;
                case 2:
                    RemoveResource(resources);
                    break;
                case 3:
                    DisplayResources(resources);
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }

    static void AddResource(int[] resources)
    {
        Console.WriteLine("Выберите ресурс для добавления:");
        Console.WriteLine("1. Еда");
        Console.WriteLine("2. Вода");
        Console.WriteLine("3. Дерево");
        int resourceType = int.Parse(Console.ReadLine());

        Console.Write("Введите количество для добавления: ");
        int amount = int.Parse(Console.ReadLine());

        if (resourceType >= 1 && resourceType <= 3)
        {
            resources[resourceType - 1] += amount;
            Console.WriteLine("Ресурс добавлен.");
        }
        else
        {
            Console.WriteLine("Неверный выбор ресурса.");
        }
    }

    static void RemoveResource(int[] resources)
    {
        Console.WriteLine("Выберите ресурс для удаления:");
        Console.WriteLine("1. Еда");
        Console.WriteLine("2. Вода");
        Console.WriteLine("3. Дерево");
        int resourceType = int.Parse(Console.ReadLine());

        Console.Write("Введите количество для удаления: ");
        int amount = int.Parse(Console.ReadLine());

        if (resourceType >= 1 && resourceType <= 3)
        {
            if (resources[resourceType - 1] >= amount)
            {
                resources[resourceType - 1] -= amount;
                Console.WriteLine("Ресурс удален.");
            }
            else
            {
                Console.WriteLine("Недостаточно ресурса для удаления.");
            }
        }
        else
        {
            Console.WriteLine("Неверный выбор ресурса.");
        }
    }

    static void DisplayResources(int[] resources)
    {
        Console.WriteLine("Текущие ресурсы:");
        Console.WriteLine($"Еда: {resources[0]}");
        Console.WriteLine($"Вода: {resources[1]}");
        Console.WriteLine($"Дерево: {resources[2]}");
    }

    /*
    Закоментирую 2-ю и 3-ю задачу
    // Задача 2: Ролевая игра - Сражение

    static void Battle()
    {
        int playerHealth = 100;
        int monsterHealth = 100;

        while (playerHealth > 0 && monsterHealth > 0)
        {
            Console.WriteLine("1. Атаковать");
            Console.WriteLine("2. Защититься");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    monsterHealth -= Attack();
                    Console.WriteLine($"Монстр получил урон, текущее здоровье монстра: {monsterHealth}");
                    break;
                case 2:
                    playerHealth -= Defend();
                    Console.WriteLine($"Вы получили урон, текущее здоровье игрока: {playerHealth}");
                    break;
                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }

            if (monsterHealth <= 0)
            {
                Console.WriteLine("Вы победили монстра!");
            }
            else if (playerHealth <= 0)
            {
                Console.WriteLine("Вы проиграли.");
            }
        }
    }

    static int Attack()
    {
        Random rand = new Random();
        return rand.Next(10, 21); // Урон от 10 до 20
    }

    static int Defend()
    {
        Random rand = new Random();
        return rand.Next(5, 16); // Урон от 5 до 15
    }

    static void CheckHealth(int health)
    {
        if (health <= 0)
        {
            Console.WriteLine("Здоровье на нуле.");
        }
    }

    // Задача 3: Инвентарь игрока

    static List<string> inventory = new List<string>();

    static void ManageInventory()
    {
        while (true)
        {
            Console.WriteLine("Управление инвентарем:");
            Console.WriteLine("1. Добавить предмет");
            Console.WriteLine("2. Удалить предмет");
            Console.WriteLine("3. Просмотреть инвентарь");
            Console.WriteLine("4. Выйти");
            Console.Write("Выберите действие: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 4)
            {
                break;
            }

            switch (choice)
            {
                case 1:
                    AddItem();
                    break;
                case 2:
                    RemoveItem();
                    break;
                case 3:
                    DisplayInventory();
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }
        }
    }

    static void AddItem()
    {
        Console.Write("Введите название предмета: ");
        string item = Console.ReadLine();
        inventory.Add(item);
        Console.WriteLine("Предмет добавлен.");
    }

    static void RemoveItem()
    {
        Console.Write("Введите название предмета для удаления: ");
        string item = Console.ReadLine();
        if (inventory.Contains(item))
        {
            inventory.Remove(item);
            Console.WriteLine("Предмет удален.");
        }
        else
        {
            Console.WriteLine("Предмет не найден.");
        }
    }

    static void DisplayInventory()
    {
        Console.WriteLine("Текущий инвентарь:");
        foreach (string item in inventory)
        {
            Console.WriteLine(item);
        }
    }

    */
}
