Console.WriteLine("Welcome!");

CannedFood food = new CannedFood("beans", "beans from Italy", 2.99, 200, "beans", new DateTime(2022, 07, 03));

food.Eat();

Console.WriteLine(food.GetFullName());

Water water = new Water("Rocchetta", "Acqua Rocchetta", 1.99, 2, 7, "boh");

water.Drink(2);



