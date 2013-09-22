using System;
using System.Text.RegularExpressions;

//Create a class Call to hold a call performed through a GSM. 
//It should contain date, time, dialed phone number and duration (in seconds).


public class Call
{
    private DateTime dateAndTime;
    private string phoneNumber;
    private int duration;

    //constructors
    public Call(DateTime dateAndTime, string phoneNumber, int duration)
    {
        this.DateAndTime = dateAndTime;
        this.PhoneNumber = phoneNumber;
        this.Duration = duration;
    }

    //properties
    public DateTime DateAndTime
    {
        get
        {
            return this.dateAndTime;
        }
        set
        {
            this.dateAndTime = value;
        }
    }

    public string PhoneNumber
    {
        get
        {
            return this.phoneNumber;
        }
        set
        {
            string pattern = @"08[7-9][0-9]{7}";
            if (value.Length == 10 && Regex.IsMatch(value, pattern))
            {
                this.phoneNumber = value;
            }
            else
            {
                throw new ArgumentException("The phone number must consist of 10 numbers and start with 08[7-9].");
            }
        }
    }

    public int Duration
    {
        get
        {
            return this.duration;
        }
        set
        {
            if (value >= 0)
            {
                this.duration = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Call duration can't be negative.");
            }
        }
    }
}