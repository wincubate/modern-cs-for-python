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

// TODO 2: Total order sum spent

// TODO 3: Individual order sums per customer

// TODO 4: Group customers by city
