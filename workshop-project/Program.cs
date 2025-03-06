
var UsersList = new List<Users>();
UsersList.Add(new Users
{
    UserId = 1,
    NIT = 123,
    UserName = "taller el juancho",
    Phone = "78485465",
    Email = "juancho@mail.com",
    Adress = "Calle sur Envigado",
    VehiclesList = [new Vehicles(){
        VehicleId = 1,
        Plate = "abc777",
        Chassis = "dwfew7456",
        Color = "red",
        Engine = "v8",
        BrandId = 1,
        CustomerId = 1,
        UserId = 1,
        _Brand = new Brands(){
            BrandId = 1,
            BrandName = "BMW",
            OriginCountry = "Germany",
            UserId = 1,

        },
        _Customer = new Customers(){
            CustomerId = 1,
            CustomerName = "Rick Sanchez",
            Identification = "102365874",
            PhoneNumber = "3041248795",
            Email = "Rick@mail.com",
            UserId = 1,

        },

    },
    new Vehicles(){
        VehicleId = 2,
        Plate = "qwr780",
        Chassis = "dwf56g456",
        Color = "White",
        Engine = "v6",
        BrandId = 2,
        CustomerId = 2,
        UserId = 1,
        _Brand = new Brands(){
            BrandId = 2,
            BrandName = "Toyota",
            OriginCountry = "Japan",
            UserId = 1,

        },
        _Customer = new Customers(){
            CustomerId = 2,
            CustomerName = "Morty Smith",
            Identification = "102781966",
            PhoneNumber = "30412441100",
            Email = "Morty@mail.com",
            UserId = 1,

        },

    }
    ],
    CustomersList = [
        new Customers(){
            CustomerId = 1,
            CustomerName = "Rick Sanchez",
            Identification = "102365874",
            PhoneNumber = "3041248795",
            Email = "Rick@mail.com",
            UserId = 1,
            VehiclesList = [
                new Vehicles(){
                    VehicleId = 1,
                    Plate = "abc777",
                    Chassis = "dwfew7456",
                    Color = "red",
                    Engine = "v8",
                    BrandId = 1,
                    CustomerId = 1,
                    UserId = 1,
                    _Brand = new Brands(){
                        BrandId = 1,
                        BrandName = "BMW",
                        OriginCountry = "Germany",
                        UserId = 1,

                    },
                    _Customer = new Customers(){
                        CustomerId = 1,
                        CustomerName = "Rick Sanchez",
                        Identification = "102365874",
                        PhoneNumber = "3041248795",
                        Email = "Rick@mail.com",
                        UserId = 1,

                    },

                }
            ]
        }
    ,
    new Customers(){
        CustomerId = 2,
        CustomerName = "Morty Smith",
        Identification = "102781966",
        PhoneNumber = "30412441100",
        Email = "Morty@mail.com",
        UserId = 1,
        VehiclesList = [
            new Vehicles(){
                VehicleId = 2,
                Plate = "qwr780",
                Chassis = "dwf56g456",
                Color = "White",
                Engine = "v6",
                BrandId = 2,
                CustomerId = 2,
                UserId = 1,
                _Brand = new Brands(){
                    BrandId = 2,
                    BrandName = "Toyota",
                    OriginCountry = "Japan",
                    UserId = 1,

                },
                _Customer = new Customers(){
                    CustomerId = 2,
                    CustomerName = "Morty Smith",
                    Identification = "102781966",
                    PhoneNumber = "30412441100",
                    Email = "Morty@mail.com",
                    UserId = 1,

                },
            }
        ]
    }
    ],
    BrandsList = [
        new Brands(){
            BrandId = 1,
            BrandName = "BMW",
            OriginCountry = "Germany",
            UserId = 1
        }
    ,
        new Brands(){
            BrandId = 2,
            BrandName = "Toyota",
            OriginCountry = "Japan",
            UserId = 1
        }
    ],
    CategoriesList = [
        new Categories(){
            CategoryId = 1,
            CategoryName = "Engine",
            active = true,
            UserId = 1
        }
    ,
        new Categories(){
            CategoryId = 2,
            CategoryName = "Accesories",
            active = true,
            UserId = 1
        }
    ],
    EmployeesList = [
        new Employees(){
            EmployeeId = 1,
            EmployeeName = "Rafa el mechanic",
            Identification = "7246982",
            _OrdersList = [
                new Orders(){
                    OrderId = 1,
                    OrderRef = "f21",
                    CustomerRemark = "Be careful with the paint",
                    VehicleId = 1,
                    EmployeeId = 1,
                    UserId = 1,
                    _Vehicle = new Vehicles(){
                        VehicleId = 1,
                        Plate = "abc777",
                        Chassis = "dwfew7456",
                        Color = "red",
                        Engine = "v8",
                        BrandId = 1,
                        CustomerId = 1,
                        UserId = 1,
                        _Brand = new Brands(){
                            BrandId = 1,
                            BrandName = "BMW",
                            OriginCountry = "Germany",
                            UserId = 1,

                        },
                        _Customer = new Customers(){
                            CustomerId = 1,
                            CustomerName = "Rick Sanchez",
                            Identification = "102365874",
                            PhoneNumber = "3041248795",
                            Email = "Rick@mail.com",
                            UserId = 1,

                        },
                    },
                    OrderServicesList = [new OrderServices(){
                        OrderId = 1,
                        ServiceId = 1,
                        _Service = new Services(){
                            ServiceId = 1,
                            ServiceName = "Oil Change",
                            Reference = "G34",
                            Price = 12.99,
                            StimatedTime = "2 hours",
                        }
                    }]
                }
            ,
                new Orders(){
                    OrderId = 2,
                    OrderRef = "f22",
                    CustomerRemark = null,
                    VehicleId = 2,
                    EmployeeId = 1,
                    UserId = 1,
                    _Vehicle = new Vehicles(){
                        VehicleId = 2,
                        Plate = "qwr780",
                        Chassis = "dwf56g456",
                        Color = "White",
                        Engine = "v6",
                        BrandId = 2,
                        CustomerId = 2,
                        UserId = 1,
                        _Brand = new Brands(){
                            BrandId = 2,
                            BrandName = "Toyota",
                            OriginCountry = "Japan",
                            UserId = 1,

                        },
                        _Customer = new Customers(){
                            CustomerId = 2,
                            CustomerName = "Morty Smith",
                            Identification = "102781966",
                            PhoneNumber = "30412441100",
                            Email = "Morty@mail.com",
                            UserId = 1,

                        },

                    },
                    OrderServicesList = [new OrderServices(){
                        OrderId = 2,
                        ServiceId = 2,
                        _Service = new Services(){
                            ServiceId = 2,
                            ServiceName = "Windshiel repair",
                            Reference = "q74",
                            Price = 30.99,
                            StimatedTime = "24 hours"
                        }
                        }
                    ,
                    new OrderServices(){
                        OrderId = 2,
                        ServiceId = 3,
                        _Service = new Services(){
                            ServiceId = 3,
                            ServiceName = "15Km maintenance",
                            Reference = "a23",
                            Price = 25.99,
                            StimatedTime = "6 hours"
                        }
                    }
                    ]
                }
            ]
        }
    ],
    OrdersList = [
        new Orders(){
            OrderId = 1,
            OrderRef = "f21",
            CustomerRemark = "Be careful with the paint",
            VehicleId = 1,
            EmployeeId = 1,
            UserId = 1,
            _Vehicle = new Vehicles(){
                VehicleId = 1,
                Plate = "abc777",
                Chassis = "dwfew7456",
                Color = "red",
                Engine = "v8",
                BrandId = 1,
                CustomerId = 1,
                UserId = 1,
                _Brand = new Brands(){
                    BrandId = 1,
                    BrandName = "BMW",
                    OriginCountry = "Germany",
                    UserId = 1,

                },
                _Customer = new Customers(){
                    CustomerId = 1,
                    CustomerName = "Rick Sanchez",
                    Identification = "102365874",
                    PhoneNumber = "3041248795",
                    Email = "Rick@mail.com",
                    UserId = 1,

                },
            },
                OrderServicesList = [new OrderServices(){
                    OrderId = 1,
                    ServiceId = 1,
                    _Service = new Services(){
                        ServiceId = 1,
                        ServiceName = "Oil Change",
                        Reference = "G34",
                        Price = 12.99,
                        StimatedTime = "2 hours",
                    }
                }
                ]
        }
    ,
        new Orders(){
            OrderId = 2,
            OrderRef = "f22",
            CustomerRemark = null,
            VehicleId = 2,
            EmployeeId = 1,
            UserId = 1,
            _Vehicle = new Vehicles(){
                VehicleId = 2,
                Plate = "qwr780",
                Chassis = "dwf56g456",
                Color = "White",
                Engine = "v6",
                BrandId = 2,
                CustomerId = 2,
                UserId = 1,
                _Brand = new Brands(){
                    BrandId = 2,
                    BrandName = "Toyota",
                    OriginCountry = "Japan",
                    UserId = 1,

                },
                _Customer = new Customers(){
                    CustomerId = 2,
                    CustomerName = "Morty Smith",
                    Identification = "102781966",
                    PhoneNumber = "30412441100",
                    Email = "Morty@mail.com",
                    UserId = 1,

                },

            },
                OrderServicesList = [new OrderServices(){
                    OrderId = 2,
                    ServiceId = 2,
                    _Service = new Services(){
                        ServiceId = 2,
                        ServiceName = "Windshiel repair",
                        Reference = "q74",
                        Price = 30.99,
                        StimatedTime = "24 hours"
                    }
                }
                    ,
                    new OrderServices(){
                        OrderId = 2,
                        ServiceId = 3,
                        _Service = new Services(){
                            ServiceId = 3,
                            ServiceName = "15Km maintenance",
                            Reference = "a23",
                            Price = 25.99,
                            StimatedTime = "6 hours"
                        }
                    }
                    ]
                }
    ],
    PaymentMethodsList = [
        new PaymentMethods(){
            PaymentMethodId = 1,
            PaymentMethod = "Cash",
            Active = true,
            SalesList = [
                new Sales(){
                    SaleId = 1,
                    SaleRef = "001",
                    PaymentMethodId = 1,
                    OrderId = 1,
                    _Order = new Orders(){
                        OrderId = 1,
                        OrderRef = "f21",
                        CustomerRemark = "Be careful with the paint",
                        VehicleId = 1,
                        EmployeeId = 1,
                        UserId = 1,
                        _Vehicle = new Vehicles(){
                            VehicleId = 1,
                            Plate = "abc777",
                            Chassis = "dwfew7456",
                            Color = "red",
                            Engine = "v8",
                            BrandId = 1,
                            CustomerId = 1,
                            UserId = 1,
                            _Brand = new Brands(){
                                BrandId = 1,
                                BrandName = "BMW",
                                OriginCountry = "Germany",
                                UserId = 1,

                            },
                            _Customer = new Customers(){
                                CustomerId = 1,
                                CustomerName = "Rick Sanchez",
                                Identification = "102365874",
                                PhoneNumber = "3041248795",
                                Email = "Rick@mail.com",
                                UserId = 1,

                            },
                        },
                        OrderServicesList = [new OrderServices(){
                        OrderId = 1,
                        ServiceId = 1,
                        _Service = new Services(){
                            ServiceId = 1,
                            ServiceName = "Oil Change",
                            Reference = "G34",
                            Price = 12.99,
                            StimatedTime = "2 hours",
                        }
                        }
                        ]
                    }

                }
            ]
        }
    ,
        new PaymentMethods() {
            PaymentMethodId = 2,
            PaymentMethod = "Card",
            Active = true,
            UserId = 1,
            SalesList = [
                new Sales(){
                    SaleId = 2,
                    SaleRef = "002",
                    PaymentMethodId = 2,
                    OrderId = 2,
                    UserId = 1,
                    _Order = new Orders(){
                        OrderId = 2,
                        OrderRef = "f22",
                        CustomerRemark = null,
                        VehicleId = 2,
                        EmployeeId = 1,
                        UserId = 1,
                    _Vehicle = new Vehicles(){
                        VehicleId = 2,
                        Plate = "qwr780",
                        Chassis = "dwf56g456",
                        Color = "White",
                        Engine = "v6",
                        BrandId = 2,
                        CustomerId = 2,
                        UserId = 1,
                        _Brand = new Brands(){
                            BrandId = 2,
                            BrandName = "Toyota",
                            OriginCountry = "Japan",
                            UserId = 1,

                        },
                        _Customer = new Customers(){
                            CustomerId = 2,
                            CustomerName = "Morty Smith",
                            Identification = "102781966",
                            PhoneNumber = "30412441100",
                            Email = "Morty@mail.com",
                            UserId = 1,

                        },

                    },
                    OrderServicesList = [new OrderServices(){
                        OrderId = 2,
                        ServiceId = 2,
                        _Service = new Services(){
                            ServiceId = 2,
                            ServiceName = "Windshiel repair",
                            Reference = "q74",
                            Price = 30.99,
                            StimatedTime = "24 hours"
                        }
                    }
                    ,
                    new OrderServices(){
                        OrderId = 2,
                        ServiceId = 3,
                        _Service = new Services(){
                            ServiceId = 3,
                            ServiceName = "15Km maintenance",
                            Reference = "a23",
                            Price = 25.99,
                            StimatedTime = "6 hours"
                        }
                    }
                    ]
                    }
                }
            ]
        }    
    ],
    ProductsList = new List<Products>(),
    SalesList = new List<Sales>(),
    ServicesList = new List<Services>()
});





public class Users
{
    public int UserId { get; set; }
    public int NIT { get; set; }
    public string? UserName { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? Adress { get; set; }
    public List<Vehicles>? VehiclesList { get; set; }
    public List<Customers>? CustomersList { get; set; }
    public List<Brands>? BrandsList { get; set; }
    public List<Orders>? OrdersList { get; set; }
    public List<Employees>? EmployeesList { get; set; }
    public List<Services>? ServicesList { get; set; }
    public List<Sales>? SalesList { get; set; }
    public List<PaymentMethods>? PaymentMethodsList { get; set; }
    public List<Products>? ProductsList { get; set; }
    public List<Categories>? CategoriesList { get; set; }

}

public class Vehicles
{
    public int VehicleId { get; set; }
    public string? Plate { get; set; }
    public string? Chassis { get; set; }
    public string? Color { get; set; }
    public string? Engine { get; set; }
    public int? BrandId { get; set; }
    public int? CustomerId { get; set; }
    public int? UserId { get; set; }
    public Brands? _Brand { get; set; }
    public Customers? _Customer { get; set; }
    public Users? _User { get; set; }
}

public class Customers
{
    public int CustomerId { get; set; }
    public string? CustomerName { get; set; }
    public string? Identification { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public int UserId { get; set; }
    public Users? _User { get; set; }
    public List<Vehicles>? VehiclesList { get; set; }
}

public class Brands
{
    public int BrandId { get; set; }
    public string? BrandName { get; set; }
    public string? OriginCountry { get; set; }
    public int UserId { get; set; }
    public Users? _User { get; set; }

}

public class Orders
{
    public int OrderId { get; set; }
    public string? OrderRef { get; set; }
    public string? CustomerRemark { get; set; }
    public string? ServiceCenterRemark {get;set;}
    public int VehicleId { get; set; }
    public int EmployeeId { get; set; }
    public int UserId { get; set; }
    public Users? _User { get; set; }
    public Vehicles? _Vehicle { get; set; }
    public Employees? _Employees { get; set; }
    public List<OrderServices>? OrderServicesList { get; set; }

}

public class OrderServices
{
    public int OrderId { get; set; }
    public int ServiceId { get; set; }
    public Orders? _Order { get; set; }
    public Services? _Service { get; set; }

}

public class Employees
{
    public int EmployeeId { get; set; }
    public string? Identification { get; set; }
    public string? EmployeeName { get; set; }
    public bool Active { get; set; }
    public int UserId { get; set; }
    public Users? _User { get; set; }
    public List<Orders>? _OrdersList { get; set; }
}

public class Services
{
    public int ServiceId { get; set; }
    public string? ServiceName { get; set; }
    public string? Reference { get; set; }
    public double Price { get; set; }
    public string? StimatedTime { get; set; }
    public int UserId { get; set; }
    public Users? _User { get; set; }
    public List<OrderServices>? OrderServicesList { get; set; }
    public List<ServicesProducts>? ServicesProductsList { get; set; }
}

public class ServicesProducts
{
    public int ServiceId { get; set; }
    public int ProductId { get; set; }
    public Services? _Service { get; set; }
    public Products? _Prodcut { get; set; }
}

public class Sales
{
    public int SaleId { get; set; }
    public string? SaleRef { get; set; }
    public int PaymentMethodId { get; set; }
    public int OrderId { get; set; }
    public int UserId { get; set; }
    public Users? _User { get; set; }
    public PaymentMethods? _PaymentMethod { get; set; }
    public Orders? _Order { get; set; }

}

public class PaymentMethods
{
    public int PaymentMethodId { get; set; }
    public string? PaymentMethod { get; set; }
    public bool Active { get; set; }
    public int UserId { get; set; }
    public Users? _User { get; set; }
    public List<Sales>? SalesList { get; set; }
}

public class Products
{
    public int ProductId { get; set; }
    public string? ProductName { get; set; }
    public string? Reference { get; set; }
    public double PurchasePrice { get; set; }
    public double SalePrice { get; set; }
    public int CategoryId { get; set; }
    public int UserId { get; set; }
    public Users? _User { get; set; }
    public Categories? _Category { get; set; }
    public List<ServicesProducts>? ServicesProductsList { get; set; }

}

public class Categories
{
    public int CategoryId { get; set; }
    public string? CategoryName { get; set; }
    public bool active { get; set; }
    public int UserId { get; set; }
    public Users? _User { get; set; }
    List<Products>? ProductsList { get; set; }
}
