namespace GTCode.Net.Responses;

/// <summary>
/// Implementazione di IResponse.<br/>
/// Rappresenta una risposta generica contenente solamente l'esito e un eventuale messaggio di risposta.<br/>
/// Per indicare lo stato della risposta viene utilizzata l'oggetto Status.
/// </summary>
/// <seealso cref="Status"/>
/// <seealso cref="SingleResponse{T}"/>
/// <seealso cref="ListResponse{T}"/>
public class GenericResponse : IResponse
{
    
    /// <summary>
    /// Lo stato della risposta
    /// </summary>
    public Status Status { get; set; }
    
    /// <summary>
    /// L'eventuale messaggio di risposta
    /// </summary>
    public string? Message { get; set; }

    /// <summary>
    /// Costruttore di base. Un oggetto appena creato ha Status valorizzato a Status.UNKNOWN.
    /// </summary>
    public GenericResponse()
    {
        this.Status = Status.UNKNOWN;
        this.Message = Status.UNKNOWN.Message();
    }
    
    /// <summary>
    /// Indica che questa risposta deve rappresentare un esito positivo contenente il messaggio fornito.
    /// </summary>
    /// <param name="message">messaggio di risposta</param>
    public void AsSuccess(string? message)
    {
        this.Status = Status.SUCCESS;
        this.Message = message;
    }

    /// <summary>
    /// Indica che questa risposta deve rappresentare un esito positivo.
    /// </summary>
    public void AsSuccess()
    {
        this.AsSuccess(Status.SUCCESS.Message());
    }

    /// <summary>
    /// Indica che questa risposta deve rappresentare un esito negativo contenente il messaggio fornito.
    /// </summary>
    /// <param name="message">message messaggio di risposta</param>
    public void AsError(string? message)
    {
        this.Status = Status.ERROR;
        this.Message = message;
    }

    /// <summary>
    /// Indica che questa risposta deve rappresentare un esito negativo.
    /// </summary>
    public void AsError()
    {
        this.AsError(Status.ERROR.Message());
    }
    
}