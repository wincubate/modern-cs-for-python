using ModernCS.Session3;

List<Customer> customers = [
    new Customer
    {
        Name = "Kim",
        City = "Aarhus",
        Orders =
        [
            new Order
            {
                Quantity = 4,
                Product = new Product
                {
                    Name = "Milk",
                    Price = 18
                }
            },
            new Order
            {
                Quantity = 2,
                Product = new Product
                {
                    Name = "Butter",
                    Price = 24
                }
            },
            new Order
            {
                Quantity = 2,
                Product = new Product
                {
                    Name = "Bread",
                    Price = 28
                }
            }
        ]
    },
    new Customer
    {
        Name = "Mads",
        City = "Horsens",
        Orders =
        [
            new Order
            {
                Quantity = 2,
                Product = new Product
                {
                    Name = "Milk",
                    Price = 18
                }
            },
            new Order
            {
                Quantity = 1,
                Product = new Product
                {
                    Name = "Butter",
                    Price = 24
                }
            },
            new Order
            {
                Quantity = 1,
                Product = new Product
                {
                    Name = "Bread",
                    Price = 28
                }
            },
            new Order
            {
                Quantity = 6,
                Product = new Product
                {
                    Name = "Beer",
                    Price = 15
                }
            }
        ]
    },
    new Customer
    {
        Name = "Jesper",
        City = "Aarhus",
        Orders =
        [
            new Order
            {
                Quantity = 12,
                Product = new Product
                {
                    Name = "Pepsi Max",
                    Price = 19
                }
            }
        ]
    }
];

// TODO 1: Name of customers having bought Milk
//var query1 = customers
//    .Where(c => c.Orders.Any(o => o.Product.Name == "Milk"))
//    .Select(c => c.Name)
//    ;
//foreach (var item in query1)
//{
//    Console.WriteLine(item);
//}

// TODO 2: Total order sum spent
//var query2 = customers
//    .SelectMany(c => c.Orders)
//    .Sum(o => o.Quantity * o.Product.Price)
//    ;
//Console.WriteLine(query2);

// TODO 3: Individual order sums per customer
//var query3 = customers
//    .Select(c => new
//    {
//        c.Name,
//        Spent = c.Orders.Sum(o => o.Quantity * o.Product.Price)
//    })
//    ;
//foreach (var item in query3)
//{
//    Console.WriteLine(item);
//}

// TODO 4: Group customers by city
//var query4 = customers
//    .GroupBy(c => c.City)
//    ;
//foreach (var group in query4)
//{
//    Console.WriteLine(group.Key);
//    foreach (var customer in group)
//    {
//        Console.WriteLine($"\t{customer.Name}");
//    }
//}

