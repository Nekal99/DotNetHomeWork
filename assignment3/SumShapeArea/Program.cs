using System.Security.Cryptography.X509Certificates;

public abstract class Shape
{
    private readonly string myName;
    public Shape(string s)
    {
        myName = s;
    }

    public abstract double Area
    {
        get;
    }

    public string Name
    {
        get { return myName; }
    }

    public virtual void Print()
    {
        Console.WriteLine(myName);
    }
}

public class Square : Shape
{
    private readonly int myside;

    public Square(int side, string id) : base(id)
    {
        if (side >= 0)
        {
            myside = side;
        }
        else { throw new Exception(); }
    }

    public override double Area
    {
        get
        {
            return myside * myside;
        }
    }

    public override void Print()
    {
        Console.WriteLine("This is " + this.Name);
    }

}

public class Rectangle : Shape
{
    private readonly int myWidth;
    private readonly int myHeight;

    public Rectangle(int myWidth, int myHeight, string id) : base(id)
    {
        if (myWidth >= 0 && myHeight >= 0)
        {
            this.myWidth = myWidth;
            this.myHeight = myHeight;
        }
        else
        {
            throw new Exception();
        }
    }

    public override double Area
    {
        get { return this.myWidth * this.myHeight; }
    }

    public override void Print()
    {
        Console.WriteLine("This is " + this.Name);
    }
}

public class Triangle : Shape
{
    private readonly int side1;
    private readonly int side2;
    private readonly int side3;
    private readonly int halfper;

    public Triangle(int side1, int side2, int side3, string id) : base(id)
    {
        if (side1 >= 0 && side2 >= 0 && side3 >= 0)
        {
            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
                halfper = (side1 + side2 + side3) / 2;
            }
            else
            {
                throw new Exception();
            }
        }
        else
        { throw new Exception(); }
    }

    public override double Area
    {
        get { return Math.Sqrt(halfper * (halfper - side1) * (halfper - side2) * (halfper - side3)); }
    }

    public override void Print()
    {
        Console.WriteLine("This is " + this.Name);
    }
}

public class Factory
{
    public Shape CreateShape(int type)
    {
        Random random = new Random();
        int side1 = random.Next(9);
        int side2 = random.Next(9);
        int side3 = random.Next(9);
        while(side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
        {
            side1 = random.Next(9);
            side2 = random.Next(9);
            side3 = random.Next(9);
        }
        switch(type)
        {
            case 0:
                return new Square(side1, "Square");
            case 1:
                return new Rectangle(side1, side2, "Rectangle");
            case 2:
                return new Triangle(side1, side2, side3, "Triangle");
            default:
                break;
        }
        throw new Exception("创造类型失败");

    }
}

public class TestClass
{
    public static void Main()
    {
        Factory factory = new Factory();
        Shape[] shapes = new Shape[10];
        double sumArea = 0;
        for (int i = 0; i < shapes.Length; i++)
        {
            Random random = new Random();
            int type = random.Next(3);
            shapes[i] = factory.CreateShape(type);
            shapes[i].Print();
            Console.WriteLine("Area is " + shapes[i].Area);
            sumArea += shapes[i].Area;
        }

        Console.WriteLine("sum of shapes area :" + sumArea);
    }
}
