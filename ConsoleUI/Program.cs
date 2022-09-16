// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntiityFramework;
using DataAccess.Concrete.InMemory;


ProductTest();
//CategoryTest();
//OrderTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());
    foreach (var product in productManager.GetProductDetails())
    {
        Console.WriteLine(product.ProductName);
    }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryId);
    }
}

static void OrderTest()
{
    OrderManager orderManager = new OrderManager(new EfOrderDal());
    foreach (var order in orderManager.GetAllById(2))
    {
        Console.WriteLine(order.OrderId);
    }
}