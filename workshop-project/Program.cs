

Console.WriteLine("GHolaa");

public class Users {
    public int UserId {get;set;}
    public int NIT {get;set;}
    public int UserName {get;set;}
    public string? Phone {get;set;}
    public string? Email {get;set;}
    public string? Adress {get;set;}
}

public class Vehicles{
    public int VehicleId {get;set;}
    public string? Plate {get;set;}
    public string? Chassis {get;set;}
    public string? Color {get;set;}
    public string? Engine {get;set;}
    public int? IdBrand{get;set;}
    public int? IdCustomer{get;set;}
    public Brands? _Brand {get;set;}
    public Customers? _Customer {get;set;}
}

public class Customers{
    public int CustomerId{get;set;}
    public string? CustomerName{get;set;}
    public string? Identification{get;set;}
    public string? PhoneNumber{get;set;}
    public string? Email{get;set;}
    public List<Vehicles>? VehiclesList{get;set;}
}

public class Brands{
    public int BrandId{get;set;}
    public string? BrandName{get;set;}

}

public class Orders{
    public int OrderId{get;set;}
    public string? OrderRef{get;set;}
    public string? CustomerRemark{get;set;}
    public int VehicleId {get;set;}
    public int EmployeeId {get;set;}
    public Vehicles? _Vehicle {get;set;}
    public Employess? _Employees {get;set;}
    public List<OrderServices>? OrderServicesList {get;set;}

}

public class OrderServices{
    public int OrderId{get;set;}
    public int ServiceId{get;set;}
    public Orders? _Order {get;set;}
    public Services? _Service {get;set;}

}

public class Employess{
    public int EmployeeId{get;set;}
    public string? Identification{get;set;}
    public string? Name{get;set;}
    public bool Active{get;set;}
    public List<Orders>? _OrdersList {get;set;}
}

public class Services{
    public int Service_Id{get;set;}
    public string? ServiceName{get;set;}
    public string? references {get;set;}
    public double Price {get;set;}
    public string? StimatedTime{get;set;}
    public List<OrderServices>? OrderServicesList {get;set;}
    public List<ServicesProducts>? ServicesProductsList {get;set;}
}

public class ServicesProducts{
    public int ServiceId {get;set;}
    public int ProductId {get;set;}
    public Services? _Service {get;set;}
    public Products? _Prodcut {get;set;}
}

public class Sales{
    public int SaleId{get;set;}
    public string? SaleRef{get;set;}
    public int PaymentMethodId {get;set;}
    public int OrderId {get;set;}
    public PaymentMethods? _PaymentMethod {get;set;}
    public Orders? _Order {get;set;}

}

public class PaymentMethods{
    public int PaymentMethodId {get;set;}
    public string? PaymentMethod {get;set;}
    public bool Active {get;set;}
    public List<Sales>? SalesList {get;set;}
}

public class Products{
    public int ProductId{get;set;}
    public string? ProductName{get;set;}
    public string? Reference {get;set;}
    public double PurchasePrice {get;set;}
    public double SalePrice {get;set;}
    public int CategoryId {get;set;}
    public Categories? _Category {get;set;}
    public List<ServicesProducts>? ServicesProductsList {get;set;}

}

public class Categories{
    public int CategoryId {get;set;}
    public string? CategoryName {get;set;}
    List<Products>? ProductsList {get;set;} 
}
