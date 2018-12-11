
public class Rootobject
{
    public Config Config { get; set; }
}

public class Config
{
    public Kitchen Kitchen { get; set; }
    public Restaurant Restaurant { get; set; }
}

public class Kitchen
{
    public int Cuisiner { get; set; }
    public int CommisCuisine { get; set; }
    public int Plongeur { get; set; }
}

public class Restaurant
{
    public int NbrPieces { get; set; }
    public int NbrTables { get; set; }
    public int ChefRang { get; set; }
    public int Serveur { get; set; }
    public int CommisResto { get; set; }
    public Clients Clients { get; set; }
}

public class Clients
{
    public Clients0 Clients0 { get; set; }
    public Clients1 Clients1 { get; set; }
    public Clients2 Clients2 { get; set; }
    public Clients3 Clients3 { get; set; }
    public Clients4 Clients4 { get; set; }
}

public class Clients0
{
    public string Reservation { get; set; }
    public int WaitingTime { get; set; }
    public Commande Commande { get; set; }
}

public class Commande
{
    public Choix1 Choix1 { get; set; }
    public Choix2 Choix2 { get; set; }
}

public class Choix1
{
    public string Entree { get; set; }
    public string Plat { get; set; }
    public string Dessert { get; set; }
}

public class Choix2
{
    public string Entree { get; set; }
    public string Plat { get; set; }
    public string Dessert { get; set; }
}

public class Clients1
{
    public string Reservation { get; set; }
    public int WaitingTime { get; set; }
    public Commande1 Commande { get; set; }
}

public class Commande1
{
    public Choix11 Choix1 { get; set; }
    public Choix21 Choix2 { get; set; }
}

public class Choix11
{
    public string Entree { get; set; }
    public string Plat { get; set; }
    public string Dessert { get; set; }
}

public class Choix21
{
    public string Entree { get; set; }
    public string Plat { get; set; }
    public string Dessert { get; set; }
}

public class Clients2
{
    public string Reservation { get; set; }
    public int WaitingTime { get; set; }
    public Commande2 Commande { get; set; }
}

public class Commande2
{
    public Choix12 Choix1 { get; set; }
    public Choix22 Choix2 { get; set; }
}

public class Choix12
{
    public string Entree { get; set; }
    public string Plat { get; set; }
    public string Dessert { get; set; }
}

public class Choix22
{
    public string Entree { get; set; }
    public string Plat { get; set; }
    public string Dessert { get; set; }
}

public class Clients3
{
    public string Reservation { get; set; }
    public int WaitingTime { get; set; }
    public Commande3 Commande { get; set; }
}

public class Commande3
{
    public Choix13 Choix1 { get; set; }
    public Choix23 Choix2 { get; set; }
}

public class Choix13
{
    public string Entree { get; set; }
    public string Plat { get; set; }
    public string Dessert { get; set; }
}

public class Choix23
{
    public string Entree { get; set; }
    public string Plat { get; set; }
    public string Dessert { get; set; }
}

public class Clients4
{
    public string Reservation { get; set; }
    public int WaitingTime { get; set; }
    public Commande4 Commande { get; set; }
}

public class Commande4
{
    public Choix14 Choix1 { get; set; }
    public Choix24 Choix2 { get; set; }
}

public class Choix14
{
    public string Entree { get; set; }
    public string Plat { get; set; }
    public string Dessert { get; set; }
}

public class Choix24
{
    public string Entree { get; set; }
    public string Plat { get; set; }
    public string Dessert { get; set; }
}
