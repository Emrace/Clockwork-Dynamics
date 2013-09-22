using System;
using System.Text;

//display characteristics (size and number of colors). 

public class Display
{
    private int size;
    private int? colors;

    //constructors
    public Display(int size)
        : this(size, null)
    {
    }

    public Display(int size, int? colors)
    {
        this.Size = size;
        this.Colors = colors;
    }

    //properties
    public int Size
    {
        get
        {
            return this.size;
        }
        set
        {
            if (value > 0)
            {
                this.size = value;
            }
            else
            {
                throw new ArgumentException("Enter display size.");
            }
        }
    }

    public int? Colors
    {
        get
        {
            return this.colors;
        }
        set
        {
            if (value == null || value > 0)
            {
                this.colors = value;
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
        StringBuilder displaySpecs = new StringBuilder();
        displaySpecs.AppendLine("-----Display-----");
        displaySpecs.AppendLine(this.size.ToString());
        displaySpecs.AppendLine(this.colors.ToString());

        return displaySpecs.ToString();
    }
}