using System;
using System.Collections.Generic;
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

    static private GSM iPhone = new GSM("4S", "Apple", 439, "Mel");

    //constructors
    public GSM(string model, string manufacturer)
        : this(model, manufacturer, null, null, null, null)
    {
    }

    public GSM(string model, string manufacturer, uint? price, string owner)
        : this(model, manufacturer, price, owner, null, null)
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
    private List<Call> callHistory = new List<Call>();

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

    public uint? Price
    {
        get
        {
            return this.price;
        }
        set
        {
            this.price = value;
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
    public void AddCall(DateTime now, string number, int duration)
    {
        Call myCall = new Call(now, number, duration);
        callHistory.Add(myCall);
    }
    
    public void RemoveCallByDuration(int duration)
    {
        for (int i = 0; i < callHistory.Count; i++)
        {
            if (callHistory[i].Duration == duration)
            {
                callHistory.RemoveAt(i);
                i--;
            }
        }
    }

    public void ClearHistory()
    {
        callHistory.Clear();
    }

    public void DisplayCallHistory()
    {
        StringBuilder callList = new StringBuilder();
        callList.AppendLine("Call History:");
        Console.WriteLine(new string('-', 35));
        foreach (var call in callHistory)
        {
            callList.AppendFormat("Number: {0}, \n Date: {1}, \n Duration: {2} seconds \n", 
                call.PhoneNumber, call.DateAndTime, call.Duration);
        }

        Console.WriteLine(new string('-', 35));

        Console.WriteLine(callList.ToString());
    }

    public double CalcPrice(double perMin)
    {
        double completeTimeTalked = 0;
        for (int i = 0; i < callHistory.Count; i++)
        {
            completeTimeTalked += callHistory[i].Duration;
        }

        double price = perMin * (Math.Ceiling(completeTimeTalked / 60));
        return price;
    }

    public override string ToString()
    {
        StringBuilder phoneInfo = new StringBuilder();
        phoneInfo.Append(new string('-', 7));
        phoneInfo.Append("GSM");
        phoneInfo.AppendLine(new string('-', 7));
        phoneInfo.AppendLine(this.model);
        phoneInfo.AppendLine(this.manufacturer);
        phoneInfo.AppendLine(this.price.ToString());
        phoneInfo.AppendLine(this.Battery.ToString());
        phoneInfo.AppendLine(this.Display.ToString());
        phoneInfo.AppendLine(this.owner);

        return phoneInfo.ToString();
    }
}
