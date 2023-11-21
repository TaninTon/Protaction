//การใช่ dictionarty
Dictionary<string,string> Country = new Dictionary<string,string>();
Dictionary<int,double> UnitofMoney = new Dictionary<int,double>();


Country.Add("kan", "kanchanaburi");
Country.Add("CM", "ChaineMai");
Country.Add("CM", "BangKok");

UnitofMoney.Add(1, 1000_000_000);
UnitofMoney.Add(2, 2000_000_000);
UnitofMoney.Add(3, 3000_000_000);
UnitofMoney.Add(4, 4000_000_000);
UnitofMoney.Add(5, 5000_000_000);


if (Country.ContainsKey("kan"))  Console.WriteLine(Country["kan"]);

foreach (var item in UnitofMoney)
{
    Console.WriteLine($"{ item.Key} {item.Value}");    
}

var total = UnitofMoney[1] + UnitofMoney[2];

UnitofMoney.Sum(p=>p.Value);

