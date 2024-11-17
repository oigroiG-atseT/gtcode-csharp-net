namespace GTCode.Net.Responses;

/// <summary>
/// La risposta di una richiesta od operazione effettuata attraverso uno dei protocolli di rete supportati dalla libreria.<br/>
/// Offre metodi di utility per semplificare la gestione delle classi implementanti quest'interfaccia.
/// </summary>
/// <seealso cref="GenericResponse"/>
public interface IResponse
{

    /// <summary>
    /// Lo stato della risposta
    /// </summary>
    Status Status { get; }
    
    /// <summary>
    /// L'eventuale messaggio di risposta
    /// </summary>
    string? Message { get; }
    
    /// <summary>
    /// Indica che questa risposta deve rappresentare un esito positivo contenente il messaggio fornito.
    /// </summary>
    /// <param name="message">messaggio di risposta</param>
    void AsSuccess(string message);

    /// <summary>
    /// Indica che questa risposta deve rappresentare un esito positivo.
    /// </summary>
    void AsSuccess();
    
    /// <summary>
    /// Indica che questa risposta deve rappresentare un esito negativo contenente il messaggio fornito.
    /// </summary>
    /// <param name="message">message messaggio di risposta</param>
    void AsError(string message);
    
    /// <summary>
    /// Indica che questa risposta deve rappresentare un esito negativo.
    /// </summary>
    void AsError();
    
}