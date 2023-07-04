// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter your IPv4 addresses: ");
string ipAddress = Console.ReadLine();
mymethod mymethods = new mymethod();
Console.WriteLine(mymethods.testingIP(ipAddress));

class mymethod {
    public bool testingIP(string ipAddress)
    {
        string[] octets = ipAddress.Split('.');

        if (octets.Length != 4)
           return false;

        for (int i =  0; i < octets.Length; i++)
        {
            if (!int.TryParse(octets[i], out int value))
                return false;

            if (value < 0 || value > 255)
            {
                return false;
            }

            if (octets[i].Length > 1 && octets[i][0] == '0') 
            {
                return false;
            }
        }
        return true;
    }
}
