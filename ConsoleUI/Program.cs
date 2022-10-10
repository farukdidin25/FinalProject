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

    var result = productManager.GetProductDetails();

    if (result.Success==true)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine(product.ProductName + "/" + product.CategoryName);
        }
    }

    else
    {
        Console.WriteLine(result.Message);
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