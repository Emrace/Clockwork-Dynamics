using System;
using System.Text;

//battery characteristics (model, hours idle and hours talk) 

public enum BatteryType
{
    LiIon, NiMH, NiCd
}

public class Battery
{
    private BatteryType batteryModel;
    private int? hoursIdle;
    private int? hoursTalk;


    //constructors
    public Battery(BatteryType batteryModel)
        : this(batteryModel, null, null)
    {
    }

    public Battery(BatteryType batteryModel, int? hoursIdle)
        : this(batteryModel, hoursIdle, null)
    {
    }

    public Battery(BatteryType batteryModel, int? hoursIdle, int? hoursTalk)
    {
        this.BatteryModel = batteryModel;
        this.HoursIdle = hoursIdle;
        this.HoursTalk = hoursTalk;
    }

    //properties
    public BatteryType BatteryModel
    {
        get
        {
            return this.batteryModel;
        }
        set
        {
            this.batteryModel = value;
        }
    }

    public int? HoursIdle
    {
        get
        {
            return this.hoursIdle;
        }
        set
        {
            if (value == null || value >= 0)
            {
                this.hoursIdle = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public int? HoursTalk
    {
        get
        {
            return this.hoursTalk;
        }
        set
        {
            if (value == null || value >= 0)
            {
                this.hoursTalk = value;
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
        StringBuilder batteryInfo = new StringBuilder();
        batteryInfo.AppendLine("-----Battery-----");
        batteryInfo.AppendLine(this.batteryModel.ToString());
        batteryInfo.AppendLine(this.hoursIdle.ToString());
        batteryInfo.AppendLine(this.hoursTalk.ToString());

        return batteryInfo.ToString();
    }
}