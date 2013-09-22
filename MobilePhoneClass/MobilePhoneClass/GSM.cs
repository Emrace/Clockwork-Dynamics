using System;
using System.Text;

//Define a class that holds information about a mobile phone device: model, manufacturer, price, owner

public class GSM
{
    public Battery Battery = new Battery(BatteryType.LiIon, null, null);
    public Display Display = new Display(8, null);

    private string model;
    private string manufacturer;
    private uint? price;
    private string owner;
    
    static private GSM iPhone = new GSM("4S", "Apple", 439);

    //constructors
    public GSM(string model, string manufacturer) : this(model, manufacturer, null, null, null, null)
    {
    }

    public GSM(string model, string manufacturer, uint? price) : this(model, manufacturer, price, null, null, null)
    {
    }

    public GSM(string model, string manufacturer, uint? price, string owner, Battery battery, Display display)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.price = price;
        this.Owner = owner;
        this.Battery = battery;
        this.Display = display;
    }

    //properties
    public static GSM Iphone
    {
        get
        {
            return iPhone;
        }
    }

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if (value.Length > 0)
            {
                this.model = value;
            }
            else
            {
                throw new ArgumentException("Model was not entered.");
            }
        }
    }

    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            if (value.Length > 0)
            {
                this.manufacturer = value;
            }
            else
            {
                throw new ArgumentException("Manufacturer name missing.");
            }
        }
    }

    public string Owner
    {
        get
        {
            return this.owner;
        }
        set
        {
            if (value == null || value.Length > 0)
            {
                this.owner = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    //methods
    public override string ToString()
    {
        StringBuilder phoneInfo = new StringBuilder();
        phoneInfo.Append(new string('-', 5));
        phoneInfo.Append("GSM");
        phoneInfo.AppendLine(new string('-', 5));
        phoneInfo.AppendLine(this.model);
        phoneInfo.AppendLine(this.manufacturer);
        phoneInfo.AppendLine(this.price.ToString());
        phoneInfo.AppendLine(this.Battery.ToString());
        phoneInfo.AppendLine(this.Display.ToString());
        phoneInfo.AppendLine(this.owner);

        return phoneInfo.ToString();
    }
}
