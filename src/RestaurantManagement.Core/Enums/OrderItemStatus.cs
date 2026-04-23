namespace RestaurantManagement.Core.Enums
{
    /// <summary>
    /// Statusi i artikullit në porosinë
    /// </summary>
    public enum OrderItemStatus
    {
        Pending = 1,   // Në pritje
        Cooking = 2,   // Në gatim
        Ready = 3,     // E gatshme
        Served = 4     // E shërbyer
    }
}
