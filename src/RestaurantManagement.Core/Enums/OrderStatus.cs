namespace RestaurantManagement.Core.Enums
{
    /// <summary>
    /// Statusi i porosive
    /// </summary>
    public enum OrderStatus
    {
        New = 1,        // Porosi e re
        InProgress = 2, // Duke u përpunuar
        Ready = 3,      // E gatshme
        Completed = 4,  // Përfunduar
        Cancelled = 5   // Anuluar
    }
}
