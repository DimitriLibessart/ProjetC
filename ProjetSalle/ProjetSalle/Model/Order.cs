
public class Rootobject
{
public Commandsrestaurant CommandsRestaurant { get; set; }
}

public class Commandsrestaurant
{
public Salle1 Salle1 { get; set; }
public Salle2 Salle2 { get; set; }
}

public class Salle1
{
public Command1 Command1 { get; set; }
public Command2 Command2 { get; set; }
}

public class Command1
{
public string TableNumber { get; set; }
public Commandslist CommandsList { get; set; }
}

public class Commandslist
{
public Client1 Client1 { get; set; }
public Client2 Client2 { get; set; }
}

public class Client1
{
public string Entree { get; set; }
public string Plat { get; set; }
public string Dessert { get; set; }
}

public class Client2
{
public string Entree { get; set; }
public string Plat { get; set; }
public string Dessert { get; set; }
}

public class Command2
{
public string TableNumber { get; set; }
public Commandslist1 CommandsList { get; set; }
}

public class Commandslist1
{
public Client11 Client1 { get; set; }
public Client21 Client2 { get; set; }
}

public class Client11
{
public string Entree { get; set; }
public string Plat { get; set; }
public string Dessert { get; set; }
}

public class Client21
{
public string Entree { get; set; }
public string Plat { get; set; }
public string Dessert { get; set; }
}

public class Salle2
{
public Command11 Command1 { get; set; }
public Command21 Command2 { get; set; }
}

public class Command11
{
public string TableNumber { get; set; }
public Commandslist2 CommandsList { get; set; }
}

public class Commandslist2
{
public Client12 Client1 { get; set; }
public Client22 Client2 { get; set; }
}

public class Client12
{
public string Entree { get; set; }
public string Plat { get; set; }
public string Dessert { get; set; }
}

public class Client22
{
public string Entree { get; set; }
public string Plat { get; set; }
public string Dessert { get; set; }
}

public class Command21
{
public string TableNumber { get; set; }
public Commandslist3 CommandsList { get; set; }
}

public class Commandslist3
{
public Client13 Client1 { get; set; }
public Client23 Client2 { get; set; }
}

public class Client13
{
public string Entree { get; set; }
public string Plat { get; set; }
public string Dessert { get; set; }
}

public class Client23
{
public string Entree { get; set; }
public string Plat { get; set; }
public string Dessert { get; set; }
}
