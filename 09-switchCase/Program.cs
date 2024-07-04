// Estrutura do Switch Case.
int lvl = 100;
string name = "Páprico";
string title = "";

switch (lvl)
{
    case 40:
        title = "Junior";
        break;
    case 60:
        title = "Pleno";
        break;
    case 80:
    case 90:
        title = "Senior";
        break;
    case 100:
        title = "Big Boss";
        break;
    default:
        title = "Intern";
        break;
}

Console.WriteLine($"Nome:{name}\tLevel:{lvl}\tCargo:{title}");

/****************************************************************************************************/
Console.Clear();

string sku = "01-MN-L";

//product[0] conterá "01", product[1] conterá "MN" e product[2] conterá "L"
string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");