namespace GTCode.Net.Responses;

/// <summary>
/// Rappresenta una risposta contenente una lista di oggetti ottenuti da una richiesta che restituisce un risultato paginato. 
/// </summary>
/// <typeparam name="T">il tipo di oggetto contenuto</typeparam>
/// <seealso cref="ListResponse{T}"/>
public class PaginatedResponse<T> : ListResponse<T>
{

    /// <summary>Il numero totale di elementi presenti nel server. </summary>
    public int TotalCount { get; set; }

    /// <summary>
    /// Costruttore di base. Valorizza Items con una <see cref="List{T}"/> vuota e TotalCount 0.
    /// </summary>
    public PaginatedResponse()
    {
        this.TotalCount = 0;
    }

    /// <summary>
    /// Inizializza la risposta con lo stato <see cref="Status.SUCCESS"/> e i parametri forniti.
    /// </summary>
    /// <param name="items">gli oggetti che la risposta dovrà contenere</param>
    /// <param name="totalCount">numero di elementi presenti nel server</param>
    public void AsSuccess(List<T> items, int totalCount)
    {
        base.AsSuccess(items);
        this.TotalCount = totalCount;
    }
    
}