namespace GTCode.Net.Responses;

/// <summary>
/// Rappresenta una risposta contenente una lista di oggetti.
/// </summary>
/// <typeparam name="T">il tipo di oggetto contenuto</typeparam>
/// <seealso cref="GenericResponse"/>
/// <seealso cref="PaginatedResponse{T}"/>
public class ListResponse<T> : GenericResponse
{
    
    public List<T> Items { get; set; }

    /// <summary>
    /// Costruttore di base. Valorizza Items con una <see cref="List"/> vuota.
    /// </summary>
    public ListResponse()
    {
        this.Items = [];
    }

    /// <summary>
    /// Inizzializza la risposta con lo stato <see cref="Status.SUCCESS"/> e gli oggetti forniti.
    /// </summary>
    /// <param name="items">gli oggetti che la risposta dovrà contenere</param>
    public void AsSuccess(List<T> items)
    {
        base.AsSuccess();
        this.Items = items;
    }
    
}