

interface IMovable
{
    void Move();
}

abstract class Person : IMovable
{
    public abstract void Move();
}

class Driver : Person
{
    public override void Move() => Console.WriteLine("Driver drive a car");
}


















/*IMovable tom = new Person("Tom");
tom.MoveEvent += () => Console.WriteLine($"{tom.Name} is moving");
tom.Move();

interface IMovable
{
    protected internal void Move();
    protected internal string Name { get; }
    delegate void MoveHandler();

    protected internal event MoveHandler MoveEvent;
}

class Person : IMovable
{
    private string name;
    private IMovable.MoveHandler? moveEvent;
    event IMovable.MoveHandler IMovable.MoveEvent
    {
        add => moveEvent += value;
        remove => moveEvent -= value;
    }
    
    string IMovable.Name { get => name; }
    public Person(string name) => this.name = name;

    void IMovable.Move()
    {
        Console.WriteLine($"{name} is walking");
        moveEvent?.Invoke();
    }
}*/



/*HeroAction heroAction = new HeroAction();
BaseAction baseAction = new BaseAction();

baseAction.Move();
heroAction.Move();

interface IAction
{
    void Move();
}

class BaseAction : IAction
{
    public void Move() => Console.WriteLine("Move in BaseAction");
}

class HeroAction : BaseAction, IAction
{
    public void Move() => Console.WriteLine("Move in HeroAction");
}*/



/*Person tom = new Person();

((ISchool)tom).Study();
((IUniversity)tom).Study();

class Person : ISchool, IUniversity
{
    //public void Study() => Console.WriteLine("Studying at school or university");
    void ISchool.Study() => Console.WriteLine("Studying at school");
    void IUniversity.Study() => Console.WriteLine("Studying at university");
}

interface ISchool
{
    void Study();
}

interface IUniversity
{
    void Study();
}*/



/*BaseAction baseAction1 = new BaseAction();
IAction baseAction2 = new BaseAction();

if (baseAction1 is IAction action) action.Move();
baseAction2.Move();

interface IAction
{
    void Move();
}

class BaseAction : IAction
{
    void IAction.Move() => Console.WriteLine("Move in base Class");
}*/



/*Message hello = new Message("Hello bro");
hello.Print();

IMessage message = new Message("Hello Brush");
Console.WriteLine(message.Text);

if (hello is Message someMessage) someMessage.Print();

interface IMessage
{
    string Text { get; set; }
}

interface IPrintable
{
    void Print();
}

class Message : IMessage, IPrintable
{
    public string Text { get; set; }
    public Message(string text) => Text = text;
    public void Print() => Console.WriteLine(Text);
}*/



/*IMovable tom = new Person();
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
}*/



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
    public void Move() => Console.WriteLine("Car driving");
}*/



/*interface IMovable
{
    public void Move() => Console.WriteLine("Human walking");
}

struct Car : IMovable
{
    public void Move() => Console.WriteLine("Car driving")
}*/



/*public interface IMovable
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