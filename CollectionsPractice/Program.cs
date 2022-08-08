// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] intArray = new int[10] {0,1,2,3,4,5,6,7,8,9};
string[] stringArray = new string[4] {"Tim", "Martin", "Nikki", "Sara"};
bool[] boolArray = new bool[10] {true, false, true, false, true, false, true, false, true, false};

List<string> flavors = new List<string>() {
"Chocolate", "Vanilla", "Rocky Road", "Chocolate Chip Mint", "Chocolate Peanut Butter"
};

Console.WriteLine(flavors.Count());
Console.WriteLine(flavors[3]);
flavors.Remove(flavors[3]);
Console.WriteLine(flavors.Count());

Dictionary<string, string> userInfo = new Dictionary<string, string>();

userInfo.Add(stringArray[0], flavors[0]);
userInfo.Add(stringArray[1], flavors[1]);
userInfo.Add(stringArray[2], flavors[2]);
userInfo.Add(stringArray[3], flavors[3]);
userInfo.Add(stringArray[4], flavors[4]);

foreach (KeyValuePair<string, string> user in userInfo) {
    Console.WriteLine(user.Key + " - " + user.Value);
}

