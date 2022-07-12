// See https://aka.ms/new-console-template for more information

        int custid, custu;
        string cusnum;
        double chg = 0, surchg=0 , chrgamt, netamt;

        Console.WriteLine("Input Customer ID:");
        custid = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input the name of the customer:");
        cusnum = Console.ReadLine();
        Console.WriteLine("Input the unit consumed by the customer:");
        custu = Convert.ToInt32(Console.ReadLine());

        if (custu < 200)
        {
            Console.WriteLine(chg = 1.20);
        }
        else if (custu >= 200 && custu < 400)
        {
            Console.WriteLine(chg = 1.50);
        }
        else if (custu >= 400 && custu < 600)
        {
            Console.WriteLine(chg = 1.80);
        }
        else if (custu > 600)
        {
            Console.WriteLine(chg = 2.00);
        }

        chrgamt = custu * chg;
        if (chrgamt > 400)
            surchg = chrgamt * 15 / 100.0;
        netamt = chrgamt + surchg;
        if (netamt < 100)
            netamt = 100;
        Console.WriteLine("\nElectricity Bill\n");
        Console.WriteLine("Customer IDNO                       :" + custid);
        Console.WriteLine("Customer Name                       :"+ cusnum);
        Console.WriteLine("unit Consumed                       :"+ custu);
        Console.WriteLine("Amount Charges   per unit :" +chg , chrgamt);
        Console.WriteLine("Surchage Amount                     :"+ surchg);
        Console.WriteLine("Net Amount Paid By the Customer     :"+ netamt);
    



