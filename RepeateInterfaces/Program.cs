IMovable tom = new Person();
Car tesla = new Car();

tom.Move();
tesla.Move();

interface IMovable
{
    public void Move() => Console.WriteLine("Walking");
}

class Person : IMovable { }

struct Car : IMovable
{
    public void Move() => Console.WriteLine("Driving");
}













/*Person person = new Person();
Car car = new Car();

DoAction(person);
DoAction(car);

void DoAction(IMovable movable) => movable.Move();

interface IMovable
{
    public void Move();
}

class Person : IMovable
{
    public void Move() => Console.WriteLine("Human walking");
}

struct Car : IMovable
{
    public void Move() => Console.WriteLine("Car edet");
}*/



/*interface IMovable
{
    public void Move() => Console.WriteLine("Human walking");
}

struct Car : IMovable
{
    public void Move() => Console.WriteLine("Car edet")
}*/



/*public interface Imovable
{
    public const int minSpeed = 0;
    public const int maxSpeed = 60;

    static double GetTime(double distance, double speed) => distance / speed;

    static int MaxSpeed
    {
        get => maxSpeed;
        set
        {
            if (value > 0) maxSpeed = value;
        }
    }
    
}*/



/*Console.WriteLine(IMovable.minSpeed);
Console.WriteLine(IMovable.maxSpeed);

public interface IMovable
{
    const int minSpeed = 0;
    const int maxSpeed = 60;

    void Move() => Console.WriteLine("Walking");
    
    string Name { get; set; }
    delegate void MoveHandler(string message);
    event MoveHandler MoveEvent;
}*/