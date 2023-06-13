using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;
using Northwind.Data;
using Northwind.Models;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Northwind
{

    internal class Program
    {

        static void Main(string[] args)
        {
            NorthwindContext db = new NorthwindContext();

            // Bütün employesslerin adlarını ve soyadlarını ekrana satır satır yazdıran döngüyü yazınız.

            //var result = db.Employees.ToList();

            //foreach (var employee in result)
            //{
            //    Console.WriteLine(employee.FirstName + "" + employee.LastName);

            //}

            // -------------------------------------Sorular---------------------------------------------

            //1.Select CategoryName,Description from Categories Order by CategoryName

            //Category cat = new Category();
            //cat.Description = "Test";
            //cat.CategoryName = "Test1";

            //Category catt = new Category { Description= "Test" , CategoryName="Test2"};


            //var result = db.Categories.Select(c=> new Category {CategoryName=c.CategoryName,Description=c.Description}).OrderBy(c => c).ToList();

            //foreach (var category in result)
            //{
            //    Console.WriteLine(category.CategoryName + " " +category.Description);
            //}

            // ------------------------------------------------------------------------------------------

            // 2.Select ContactName, ContactTitle, CompanyName, Phone from Customers Order By Phone

            //var result = db.Customers.Select(c=> new Customer
            //{ContactName=c.ContactName, 
            //ContactTitle=c.ContactTitle,
            //CompanyName=c.CompanyName,
            //Phone=c.Phone
            //}).OrderBy(c => c.Phone).ToList();

            //foreach (var customer in result)
            //{
            //    Console.WriteLine(customer.ContactName + " " +customer.ContactTitle+ " " +customer.ContactTitle+ " " +customer.Phone);
            //}

            // ------------------------------------------------------------------------------------------

            //3.Select FirstName,LastName,HireDate from Employees order by HireDate DESC

            //var result = db.Employees.Select(e => new Employee
            //{
            //    FirstName=e.FirstName,
            //    LastName=e.LastName,
            //    HireDate=e.HireDate,

            //}).OrderByDescending(e => e.HireDate).ToList();


            //foreach (var employee in result)
            //{
            //    Console.WriteLine(employee.FirstName + " " +employee.LastName+ " " +employee.HireDate);
            //}


            // ------------------------------------------------------------------------------------------

            //5.Select CompanyName,Fax,Phone,HomePage,Country from Suppliers Order by Country DESC, CompanyName ASC

            //var result = db.Suppliers.Select(s => new Supplier
            //{
            //    CompanyName=s.CompanyName,
            //    Fax=s.Fax,
            //    Phone=s.Phone,
            //    HomePage=s.HomePage,
            //    Country=s.Country
            //}).OrderByDescending(s=>s.Country).ThenBy(s => s.CompanyName).ToList<Supplier>();



            //foreach (var supplier in result)
            //{
            //    Console.WriteLine(supplier.CompanyName + "\t " +supplier.Country);
            //}

            // ------------------------------------------------------------------------------------------


            //6.Select CompanyName,ContactName from Customers Where City='Buenos Aires'

            //var result = db.Customers.Where(c => c.City == "Buenos Aires").Select(c => new Customer
            //{
            //    CompanyName=c.CompanyName,
            //    ContactName=c.ContactName

            //});

            // ------------------------------------------------------------------------------------------

            //7.Select ProductName,UnitPrice,QuantityPerUnit from Products where UnitsInStock =0

            //var result = db.Products.Where(p => p.UnitPrice == 0).Select(p => new Product
            //{
            //    ProductName=p.ProductName,
            //    UnitPrice=p.UnitPrice,
            //    QuantityPerUnit=p.QuantityPerUnit

            //});



            // ------------------------------------------------------------------------------------------

            //8.Select OrderDate,ShippedDate,Freight,CustomerID from Orders where OrderDate= DATEFROMPARTS(1997, 5, 19)


            //var result = db.Orders.Where(o => o.OrderDate == new DateTime(1997, 5, 19)).Select(o=> new Order
            //{
            //      OrderDate = o.OrderDate,
            //      ShippedDate =o.ShippedDate,
            //      Freight = o.Freight,
            //      CustomerId = o.CustomerId
            //});


            // ------------------------------------------------------------------------------------------

            //9.Select FirstName,LastName,Country from Employees where Country NOT IN('USA')

            //var result = db.Employees.Where(e => e.Country != "USA").Select(e => new Employee
            //{
            //        FirstName = e.FirstName,
            //        LastName = e.LastName,
            //        Country = e.Country

            //});

            // ------------------------------------------------------------------------------------------


            //10.Select EmployeeID,OrderID,CustomerID,RequiredDate,ShippedDate from Orders Where ShippedDate > RequiredDate

            //var result = db.Orders.Where(o => o.ShippedDate > o.RequiredDate).Select(o => new Order
            //{
            //    EmployeeId = o.EmployeeId,
            //    OrderId = o.OrderId,
            //    CustomerId  = o.CustomerId,
            //    RequiredDate = o.RequiredDate,
            //    ShippedDate = o.ShippedDate

            //});

            // ------------------------------------------------------------------------------------------

            // "StartsWith", bir dizeyi başka bir dizeyle karşılaştırmak ve belirtilen dizeyle başladığını kontrol etmek için kullanılan bir
            // metot veya işlevdir.

            //11.Select * from Customers where City LIKE 'A%' OR City LIKE 'B%'

            //var result = db.Customers.Where(c => c.City.StartsWith("A") || c.City.StartsWith("B")).Select(c => new Customer
            //{
            //    City=c.City


            //});

            //foreach (var customer in result)

            //{
            //    Console.WriteLine(customer.City);
            //}


            // ------------------------------------------------------------------------------------------

            //12.Select * from Orders where Freight >500


            //var result = db.Orders.Where(o => o.Freight > 500).Select(o => new Order
            //{
            //    Freight = o.Freight

            //});

            // ------------------------------------------------------------------------------------------

            //13. select * from Products where UnitsInStock <= ReorderLevel


            //var result = db.Products.Where(p => p.UnitsInStock  <= p.ReorderLevel).Select(o => new Order
            //{


            //});


            // ------------------------------------------------------------------------------------------

            // 14.select * from Customers where Fax is not NULL	

            //var result = db.Customers.Where(c => c.Fax!=null).Select(c => new Customer
            //{


            //});

            // ------------------------------------------------------------------------------------------

            //15.Select* from Employees where ReportsTo is NULL

            //var result = db.Employees.Where(e => e.ReportsTo == null);

            // ------------------------------------------------------------------------------------------

            //16.select CompanyName,ContactName,Fax from Customers where Fax is not null  order by CompanyName

            //var result = db.Customers.Where(c => c.Fax !=null).OrderBy(c => c.CompanyName).Select(c => new Customer
            //{
            //    CompanyName = c.CompanyName,
            //    ContactName = c.ContactName,
            //    Fax  = c.Fax


            //}).ToList();


            // ------------------------------------------------------------------------------------------

            // 18.select * from Employees where YEAR(BirthDate)>=1950 and YEAR(BirthDate)<1960



            //var result = db.Employees.Where(e => e.BirthDate.Value.Year>=1950 && e.BirthDate.Value.Year < 1960).Select(c => new Employee
            //{
            //    FirstName = c.FirstName,
            //    LastName = c.LastName,
            //    BirthDate = c.BirthDate,
            //});
            //foreach (var employee in result)
            //{
            //    Console.WriteLine(employee.FirstName + " : " + employee.LastName + " : " + employee.BirthDate);
            //}


            //------------------------------------------------------------------------------------------

            //19.select ProductName, SupplierID from Products where SupplierID in (select SupplierID from Suppliers where CompanyName in ('Tokyo Traders', 'Exotic Liquids', 'Grandma Kelly''s Homestead'))

            // Contains Sql de IN anlamına gelir.


            //List<string> list = new List<string>();

            //list.Add("Tokyo Traders");
            //list.Add("Exotic Liquids");
            //list.Add("Grandma Kelly's Homestead");

            //var result = db.Products.Where(p =>
            //db.Suppliers.Where(s => list.Contains(s.CompanyName)).
            //Select(s => s.SupplierId).
            //Contains((int)p.SupplierId)).Select(p => new Product
            //{
            //    ProductName=p.ProductName,
            //    SupplierId=p.SupplierId,

            //});

            //------------------------------------------------------------------------------------------

            //21.Select ContactName,ContactTitle,CompanyName from Customers where ContactTitle not like '%Sales%'

            //var result = db.Customers.Where(Customer => !Customer.ContactTitle.Contains("Sales")).Select(Customer => Customer.ContactTitle).ToList();

            //22.Select * from Employees where City!='Seattle' and Region='WA'

            //var result = db.Employees.Where(Employee => Employee.City!="Seattle" && Employee.Region=="WA");


            //

            //------------------------------------------------------------------------------------------

            //23.Select * from Customers where (Country = 'Mexico' or Country = 'Spain') and City!='Madrid'

            //var result = db.Customers.Where(c => (c.Country == "Mexico" || c.Country == "Spain") && c.City != "Madrid")
            //     .Select(c => new Customer

            //     {
            //         Country = c.Country,
            //         City = c.City,

            //     }).ToList();

            //foreach (var customer in result)
            //{
            //    Console.WriteLine(customer.Country + "\t" + customer.City);
            //}

            //------------------------------------------------------------------------------------------

            //25.select UnitPrice,UnitsInStock,(UnitsInStock*UnitPrice) as TotalPrice, FLOOR(UnitsInStock*UnitPrice) as TotalPriceRoundedDown, CEILING(UnitsInStock*UnitPrice) as TotalPriceRoundedUp from Products


            //var result = db.Products.Select(product => new
            //{
            //    product.UnitPrice,
            //    product.UnitsInStock,
            //    TotalPrice = product.UnitsInStock * product.UnitPrice,
            //    TotalPriceRoundedDown = Math.Floor((short)product.UnitsInStock * (decimal)product.UnitPrice),
            //    TotalPriceRoundedUp = Math.Ceiling((short)product.UnitsInStock * (decimal)product.UnitPrice)

            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.UnitPrice + " " + item.UnitsInStock + " " + item.TotalPrice + " | " + item.TotalPriceRoundedDown + " | " + item.TotalPriceRoundedUp);
            //}

            //------------------------------------------------------------------------------------------

            //26.Select Firstname, (YEAR(HireDate)-YEAR(BirthDate)) as HireAgeInaccurate, DATEDIFF(day,BirthDate,HireDate)/365.0 as Gun from Employees 

            //var result = db.Employees.Select(employee => new
            //{
            //    HireAgeInaccurate = employee.HireDate.Value.Year-employee.BirthDate.Value.Year,
            //    HireAgeAccurate = (employee.HireDate-employee.BirthDate).Value.Days/365.0
            //});

            //foreach (var employee in result)
            //{
            //    Console.WriteLine((employee.HireAgeAccurate)+" "+employee.HireAgeInaccurate);
            //}

            //------------------------------------------------------------------------------------------

            //27.select FirstName,LastName,DATENAME(MONTH,BirthDate) from Employees where MONTH(BirthDate)=MONTH(GETDATE())


            //var result = db.Employees.Where(employee => employee.BirthDate.Value.Month==DateTime.Now.Month).Select(e => new
            //{
            //e.FirstName,
            //e.LastName,
            //MonthName=e.BirthDate.Value.ToString("MMM")

            //});

            //------------------------------------------------------------------------------------------

            //28.Select LOVER (ContactTitle) from  Customers 

            //var result = db.Customers.Select(c => new Customer
            //{
            //    ContactTitle = c.ContactTitle.ToLower(),
            //});


            //------------------------------------------------------------------------------------------

            //30.Select * from Products where CategoryID=(select CategoryID from Categories where CategoryName='Seafood')


            //includes(): Sorgu sırasında entity'leri daha sorgumuzu yazarken birbirine bağlayıp tek seferde bir çekme işlemi sağlamış oluyoruz. Bu işlemi sağlarken de Include metodunu kullanarak entity'leri birbirine bağlama işlemini gerçekleştirmiş oluruz.

            //var result = db.Products.Include(p => p.Category).Where(p => p.Category.CategoryName=="Seafood").ToList();

            //foreach (var item in result)

            //{
            //    Console.WriteLine(item.Category.CategoryName+" "+item.CategoryId);
            //}


            //------------------------------------------------------------------------------------------

            //31.Select * from Products where CategoryID=8

            //var result = db.Products.Select(p => p.CategoryId ==8);



            //------------------------------------------------------------------------------------------


            //33.SORU : 

            //SQL: Select e.FirstName, o.ShippedDate from Orders o join Employees e
            //on e.EmployeeID = o.EmployeeID where o.ShippedDate > o.RequiredDate


            //Include Version:

            //var result = db.Orders.Include(o => o.Employee).Where(o => o.ShippedDate > o.RequiredDate).Select(o => new
            //{
            //    o.OrderDate,
            //    o.ShippedDate,
            //    o.Employee.FirstName,
            //    o.Employee.LastName,
            //});


            //foreach (var o in result)
            //{
            //    Console.WriteLine(o.OrderDate + " " + o.ShippedDate + " " + o.Employee.FirstName + " " + o.Employee.LastName);


            //}



            //count bir property olarak değil fonksiyon olarak buraya geldiği için bu şekilde yaptık;
            ////Kaç kayıt geldiğini görmek için;
            //Console.WriteLine("Toplam Sayı : " + result.Count(a => 1 == 1));

            ////yada bu şekilde getirebiliriz
            //Console.WriteLine("Toplam Sayı : " + result.Count(a => true));

            ////isminin baş harfi a ile başlayanlar
            //Console.WriteLine("Toplam Sayı : " + result.Count(a =>a.FirstName.StartsWith("A")));


            //Çözüm 2;

            //List<Order> result = db.Orders.Include(o => o.Employee).Where(o => o.ShippedDate > o.RequiredDate).ToList<Order>();

            //foreach (var o in result)
            //{
            //    Console.WriteLine(o.OrderDate + " " + o.ShippedDate + " " + o.Employee.FirstName + " " + o.Employee.LastName);


            //}


            //Console.WriteLine("Toplam Sayı: " + result.Count);


            //Çözüm 3;

            //Önceki yazılımcı diyelim ki navigational property eklemedi ;
            //Yani: Order tablosundaki;
            // public virtual Employee? Employee { get; set; }


            //Ekstra Notlar aşağıda;
            //T tipinde bir değişken yani örnek olarak TResult generic demek dışarıdan herhangi bir class alabilir


            //Burada kısıtlanmış olan datayı kullanıyoruz 
            //var result = db.Orders.Where(o => o.ShippedDate>o.RequiredDate).Join(db.Employees, o => o.EmployeeId, e => e.EmployeeId, (order, employee) => new
            //{
            //    order.OrderDate,
            //    employee.FirstName,
            //    employee.LastName
            //});


            //Burada tüm datayı getirip oradan sınırlıyoruz.
            //var result = db.Orders.Join(db.Employees, o => o.EmployeeId, e => e.EmployeeId, (order, employee) => new
            //{
            //    order.OrderDate,
            //    employee.FirstName,
            //    employee.LastName
            //    order.RequiredDate,
            //    order.ShippedDate
            //}).Where(res => res.ShippedDate > res.RequiredDate);



            //    foreach (var o in result)
            //    {
            //        Console.WriteLine(o.FirstName + " " + o.LastName + " " + o.OrderDate);
            //    }


            //    Console.WriteLine("Toplam Sayı: " + result.Count(x => true));
            //}
            //33.Soru Notlar:

            //Bir method yazalım; Dışarıdan bir tane order nesnesi alsın bu orderIDsini 1 arttırsın geri göndersin


            //order tipinden bir nesne alacak
            //public static int BirArttir(Order order)
            //{
            //    //gelen order nesnesinin bir fazlasını return edeceğiz
            //    return order.OrderId + 1;
            //}

            //bu sınıftaki herhangi birini alabilsin deseydik T yazacaktık;

            //public static T BirArttir(TOrder order)
            //{

            //    return order.OrderId + 1;
            //}
            //burada özel bir ayar yapmamız gerekiyordu o yüzden altını çziiyor


            //------------------------------------------------------------------------------------------


            //34.SORU :
            //SELECT p.ProductName,SUM(od.Quantity) as TotalUnits
            //FROM[Order Details]  od JOIN Products p ON od.ProductID=p.ProductID
            //GROUP BY p.ProductName HAVING SUM(od.Quantity)<200


            //1.Çözüm:

            //var result = db.OrderDetails.Include(od => od.Product).GroupBy(od => od.Product.ProductName).Where(x => x.Sum(x => x.Quantity)<200).Select(x => new

            //{
            //    ProductName = x.Key,
            //    TotalUnits = x.Sum(x => x.Quantity)
            //});



            //2.Çözüm: 

            //var result = db.Products.GroupJoin(db.OrderDetails, od => od.ProductId, p => p.ProductId, (Product,OrderDetail) => new
            //{
            //    Product.ProductName,
            //    TotalUnits = OrderDetail.Sum(od => od.Quantity)


            //}).Where(result => result.TotalUnits<200);


            //3.Çözüm: 

            //var result = db.OrderDetails.Join(db.Products, od => od.ProductId, p => p.ProductId, (orderdetail, product) => new
            //{
            //    orderdetail.Quantity,
            //    product.ProductName
            //}).GroupBy(x => x.ProductName).Select(x => new
            //{
            //    x.Key,
            //    TotalUnits = x.Sum(x => x.Quantity)
            //}).Where(x => x.TotalUnits < 200);

            //------------------------------------------------------------------------------------------

            //35.SORU


            //SELECT CompanyName, COUNT(o.OrderID) as TotalNumber 
            //FROM Customers c join Orders o on o.CustomerID=c.CustomerID
            //WHERE o.OrderDate > '12/31/1996'
            //GROUP BY CompanyName
            //HAVING COUNT(o.OrderID) > 15;


            //var result = db.Customers.GroupJoin(
            //    db.Orders.Where(o=> o.OrderDate>new DateTime(1996,12,31)), c => c.CustomerId, o => o.CustomerId, 
            //    (customer, gruplanmisOrderTablosu) => new
            //{
            //    customer.CompanyName,
            //    ordercount = gruplanmisOrderTablosu.Count()
            //}).Where(res => res.ordercount >15);


            //foreach (var o in result)
            //{
            //    Console.WriteLine(o.CompanyName +"\t"+ o.ordercount);
            //}


            //36.SORU: 
            //Select c.CompanyName,o.OrderID, ((od.Quantity*od.UnitPrice) * (1-od.Discount)) as TotalPrice from Customers c join Orders o on c.CustomerID = o.CustomerID join [Order Details] od on o.OrderID  = od.OrderID where ((od.Quantity*od.UnitPrice) * (1-od.Discount)) >= 10000


            //var result = db.OrderDetails.Include(od => od.Order).ThenInclude(o => o.Customer).
            //    Where(od=>(od.UnitPrice*od.Quantity)*(1-(decimal)-od.Discount)>=10000).Select(res => new
            //    {
            //        res.Order.Customer.CompanyName,
            //        res.OrderId,
            //        TotalPrice = (res.UnitPrice*res.Quantity)*(1-(decimal)-res.Discount)
            //    });

            //foreach (var o in result)
            //{
            //    Console.WriteLine(o.CompanyName +"\t"+ o.OrderId+"\t"+o.TotalPrice);
            //}

            //Console.WriteLine("Toplam Sayı: " +result.Count(x=>true));




            // ---------------------------------------------------------------------------------------

            // ŞİFRE VE RASTGELE DEĞER ATAMA VE BULMA KODU:


            string password = RandomStringGenerator(5);

			

			MD5 md5 = MD5.Create();
			byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
			byte[] hashBytes = md5.ComputeHash(inputBytes);

			string md5string = Convert.ToHexString(hashBytes); // .NET 5 +

			Console.WriteLine("Password = " +password);
			Console.WriteLine("MD5 Password = " + md5string);


		}

        // ---------------------------------------------------------------------------------------

        // ŞİFRE VE RASTGELE DEĞER ATAMA VE BULMA KODU:


        static string RandomStringGenerator(int length)
        {
            //Bu metodun amacı, girilen uzunluk değeri kadar uzun bir rastgele string oluşturmaktır.
            //stringi oluştururken, Büyükharf, Küçükarf ve Rakam kullanılacaktır.
            //Ancak içerisinde kaç büyükharf kaç küçük harf ve kaç rakam olacağı RASTGELE olarak belirlenecektir.
            //Ama, en az bir büyük harf, en az bir küçük harf ve en az bir rakam olması, garanti edilecektir.

            Random rnd = new Random();
            string karakterler = "ABCDEFGHIJKLMNOPRSTUVYZQWabcdefghijklmnoprstuvyzqw0123456789";
            string randomString = "";
            if (length >= 3)
            {


                for (int i = 0; i < length - 3; i++)
                    randomString+= karakterler[rnd.Next(0, karakterler.Length)];

                //bir tane küçük harf enjekte edelim.
                randomString = randomString.Insert(rnd.Next(0, randomString.Length), Convert.ToChar(rnd.Next(97, 123)).ToString());

                //bir tane de büyük harf enjekte edelim

                randomString = randomString.Insert(rnd.Next(0, randomString.Length), Convert.ToChar(rnd.Next(65, 91)).ToString());

                //bir tane de rakam enjekte edelim

                randomString = randomString.Insert(rnd.Next(0, randomString.Length), rnd.Next(0, 10).ToString());

            }

            return randomString;
        }

    }
}
