namespace ProductsClass
{
public class Product
{
    string Name = "";
    double Price=0;

    public Product(string name="", double price=0)
    {
        Name = name;
        Price = price;
    }

    public static Product operator +(Product p1, Product p2)
    {
        return new Product(p1.Name, p1.Price + p2.Price);
    }

    public static Product operator -(Product p1, Product p2)
    {
            if (p1.Name == p2.Name)
                return new Product(p1.Name, p1.Price - p2.Price);
            else
                return new Product();
    }

    public static Product operator *(Product p1, double n)
    {
        return new Product(p1.Name, p1.Price * n);
    }

    public static Product operator /(Product p1, double n)
    {
        return new Product(p1.Name, p1.Price / n);
    }

    public static Product operator ++(Product p1)
    {
        return new Product(p1.Name, p1.Price + p1.Price);
    }

        public static bool operator <(Product p1, Product p2)
        {
            if (p1.Price < p2.Price)
                return true;
            else
                return false;
        }

        public static bool operator >(Product p1, Product p2)
        {
            if (p1.Price > p2.Price)
                return true;
            else
                return false;
        }

        public static bool operator <=(Product p1, Product p2)
        {
            if (p1.Price <= p2.Price)
                return true;
            else
                return false;
        }

        public static bool operator >=(Product p1, Product p2)
        {
            if (p1.Price >= p2.Price)
                return true;
            else
                return false;
        }

        public static bool operator ==(Product p1, Product p2)
        {
            if (p1.Price == p2.Price && p1.Name == p2.Name)
                return true;
            else
                return false;
        }

        public static bool operator !=(Product p1, Product p2)
        {
            if (p1.Price != p2.Price || p1.Name != p2.Name)
                return true;
            else
                return false;
        }

        public static double GetSum(params Product[] basket)
        {
            double sum=0;
            for(int i = 0; i<basket.Length; i++)
            {
                sum += basket[i].Price;
            }
            return sum;
        }

    public string GetName()
    {
        return this.Name;
    }

    public double GetPrice()
    {
        return this.Price;
    }


}
}
