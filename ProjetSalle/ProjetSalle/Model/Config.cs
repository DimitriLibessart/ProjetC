

public class Rootobject
{
    public Config Config { get; set; }
}

public class Config
{
    public Restaurantconf RestaurantConf { get; set; }
}

public class Restaurantconf
{
    public int RowChief { get; set; }
    public int Server { get; set; }
    public int RoomClerk { get; set; }
}

