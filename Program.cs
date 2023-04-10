// MIS 3013 April 10, 2023
// HW7 Array
// Kyle Gauthier 113502872

string[] nameArray;
nameArray = new string[10];

double[] balanceArray;
balanceArray = new double[10];

string m;

for(int i = 0; i < nameArray.Length; i++)
{
    string s = string.Format($"Input the clients' {i+1} name: ");
    Console.Write( s );
    string name = Console.ReadLine();
    nameArray[i] = name;

    s = string.Format($"Input the clients' {i+1} balance: ");
    Console.Write(s);
    string balanceStr=Console.ReadLine();
    double balanceDbl=Convert.ToDouble(balanceStr);

    balanceArray[i] = balanceDbl;
}

Console.WriteLine("\nThe clients' names:");
for (int i = 0; i < nameArray.Length; i++)
{
    Console.WriteLine(nameArray[i]);
}

Console.WriteLine("\nInput a clients' name: ");
string searchName = Console.ReadLine();
for(int i=0;i<nameArray.Length ;i++ )
{
    if (nameArray[i] == searchName)
    {
        m = string.Format($"{searchName} has a balance of {balanceArray[i]:C2}");
        Console.WriteLine(m); 
    }
}