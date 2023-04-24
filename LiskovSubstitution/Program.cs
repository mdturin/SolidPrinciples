

using LiskovSubstitution;

void getAreaTest(Rectangle rc)
{
    int w = rc.getWidth();
    rc.setHeight(10);
    Console.WriteLine($"Expected: {w * 10}");
    Console.WriteLine($"Got: {rc.getArea()}");
}

var rc = new Rectangle(2, 3);
getAreaTest(rc);

Rectangle sq = new Square();
sq.setWidth(5);
getAreaTest(sq);