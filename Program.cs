Person Johnson = new Person("Johnson");
Vehicle car1 = new Vehicle();
Vehicle car2 = new Vehicle(Johnson,"tesla",82);
Truck truck1 = new Truck();
Truck truck2 = new Truck(Johnson, "toyota", 6,50000,2);

Console.WriteLine(Johnson);
Console.WriteLine();
Console.WriteLine(car1);
Console.WriteLine();
Console.WriteLine(car2);
Console.WriteLine();
Console.WriteLine(truck1);
Console.WriteLine();
Console.WriteLine(truck2);

class Vehicle {
    private enum Manufracturer {
        ford,
        tesla,
        honda,
        mercedes,
        toyota,
        nissan
    }
    private Manufracturer manu;
    private int numCyl;
    private Person owner;

    public Vehicle() {
        manu = Manufracturer.ford;
        numCyl = 4;
        owner = new Person();
    }

    public Vehicle(Person _person, string _manu = "ford", int _numCyl = 4) {
        switch (_manu) {
            case "ford":
                manu = Manufracturer.ford;
                break;
            case "tesla":
                manu = Manufracturer.tesla;
                break;
            case "honda":
                manu = Manufracturer.honda;
                break;
            case "mercedes":
                manu = Manufracturer.mercedes;
                break;
            case "toyota":
                manu = Manufracturer.toyota;
                break;
            case "nissan":
                manu = Manufracturer.nissan;
                break;
            default:
                manu = Manufracturer.ford;
                break;
        }
        numCyl = _numCyl;
        owner = _person;
    }

    public int getNumCyl() { return numCyl; }
    public Person getOwner() { return owner; }
    public void setOwner(Person owner) { this.owner = owner; }
    public void setNumCyl(int cyl) { this.numCyl = cyl; }

    private string manuToString() {
        switch (manu) {
            case Manufracturer.ford:
               return "ford";
            case Manufracturer.tesla:
                return "tesla";
            case Manufracturer.honda:
                return "honda";
            case Manufracturer.mercedes:
                return "mercedes";
            case Manufracturer.toyota:
                return "toyota";
            case Manufracturer.nissan:
                return "nissan";
        }
        return "error";
    }

    public override string ToString() {
        return "Manufacturer: " + manuToString() + "\nNumber of Cylinders: " + numCyl + "\nOwner: " + owner.ToString();
    }
}

class Truck : Vehicle {
    private double loadCap;
    private int towCap;

    public Truck() : base()
    {
        loadCap = 2.5;
        towCap = 5000;
    }
    public Truck(Person _person, string _manu = "ford", int _numCyl = 4, double _loadCap=2.5,int _towCap=5000) : base(_person,_manu, _numCyl) {
        loadCap = _loadCap;
        towCap = _towCap;
    }

    public override string ToString() {
        return base.ToString()+"\nload capacity: "+loadCap+" tons\ntowing capacity: "+towCap+" pounds";
    }
}

public class Person
{
    private String name;
    public Person() { name = "example name"; }
    public Person(string theName) { name = theName; }
    public Person(Person obj) { name = obj.GetName(); }
    public string GetName() { return name; }
    public void SetName(string _name) { name = _name; }
    public override string ToString() { return "Person whose name is "+name; }
    public bool Equals(Person obj) { return (name == obj.GetName()); }
}