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

public class Square:Shape
{
    private readonly int myside;

    public Square(int side, string id):base(id)
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

public class Rectangle:Shape
{
    private readonly int myWidth;
    private readonly int myHeight;

    public Rectangle(int myWidth, int myHeight,string id):base(id) 
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
        get { return  this.myWidth*this.myHeight;}
    }

    public override void Print()
    {
        Console.WriteLine("This is " + this.Name);
    }
}

public class Triangle:Shape
{
    private readonly int side1;
    private readonly int side2;
    private readonly int side3;
    private readonly int halfper;

    public Triangle(int side1, int side2, int side3,string id):base(id)
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
        }else
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

public class TestClass
{
    public static void Main()
    {
        Shape[] shapes =
        {
            new Square(5,"Square1"),
            new Rectangle(3,4,"Rectangle1"),
            new Triangle(3,4,5,"Triangle1")
        };

        Console.WriteLine("Shapes Collection");
        foreach(Shape shape in shapes)
        {
            shape.Print();
            Console.WriteLine(shape.Area);
        }
    }
}