namespace GTCode.Net.Responses;

/// <summary>
/// Rappresenta un possibile stato di una <see cref="IResponse"/>.
/// </summary>
public enum Status
{
    
    /// <summary> Rappresenta uno stato non definito. </summary>
    UNKNOWN,
    /// <summary> Rappresenta un esito positivo. </summary>
    SUCCESS,
    /// <summary> Rappresenta un esito negativo. </summary>
    ERROR
    
}

public static class StatusExtensions
{
    public static string? Message(this Status status)
    {
        return status switch
        {
            Status.UNKNOWN => null,
            Status.SUCCESS => null,
            Status.ERROR => "Errore dal server",
            _ => throw new ArgumentOutOfRangeException(nameof(status), status, null)
        };
    }
}