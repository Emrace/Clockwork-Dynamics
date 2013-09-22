using System;

/*
Write a class GSMTest to test the GSM class:
Create an array of few instances of the GSM class.
Display the information about the GSMs in the array.
Display the information about the static property IPhone4S.
*/

public class GSMTest
{
    static void Main()
    {
        //GSM Test
        GSM[] mobilePhoneArray = new GSM[3];

        Display testDisplay = new Display(8, 160);
        Battery testBattery = new Battery(BatteryType.LiIon, 10, 10);

        GSM firstMobile = new GSM("Lumia", "Nokia", 350, "Pesho", testBattery, testDisplay);
        mobilePhoneArray[0] = firstMobile;

        GSM secondMobile = new GSM("One", "HTC", 700, "Toshko", testBattery, testDisplay);
        mobilePhoneArray[1] = secondMobile;

        GSM thirdMobile = new GSM("Galaxy S3", "Samsung", 500, "Ganio", testBattery, testDisplay);
        mobilePhoneArray[2] = secondMobile;

        for (int i = 0; i < mobilePhoneArray.Length; i++)
        {
            Console.WriteLine(mobilePhoneArray[i]);
            Console.WriteLine(new string('=', 17));
            Console.WriteLine();
        }

        Console.WriteLine(GSM.Iphone.Model);
        Console.WriteLine(GSM.Iphone.Manufacturer);
        Console.WriteLine(GSM.Iphone.Price);
        Console.WriteLine();

        //GSM Call History Test
        GSM myPhone = new GSM("Lumia", "Nokia", 459, "Kiro", testBattery, testDisplay);

        myPhone.AddCall(DateTime.Now, "0884647523", 456);
        myPhone.AddCall(DateTime.Now, "0894547579", 320);
        myPhone.AddCall(DateTime.Now, "0875578923", 15);
        myPhone.AddCall(DateTime.Now, "0888987051", 45);
        myPhone.AddCall(DateTime.Now, "0880600700", 32);
        myPhone.AddCall(DateTime.Now, "0875657258", 69);

        myPhone.DisplayCallHistory();

        Console.WriteLine(myPhone.CalcPrice(0.37));

        myPhone.RemoveCallByDuration(456);
        
        myPhone.DisplayCallHistory();
        Console.WriteLine(myPhone.CalcPrice(0.37));

        myPhone.ClearHistory();
        myPhone.DisplayCallHistory();
    }
}