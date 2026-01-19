namespace NET_CarRentalSystem.Shared.CoreHelpers;

public static class TransactionHelper
{
    public static long CreateCode()
    {
        return DateTimeOffset.Now.ToUnixTimeSeconds();
    }
}