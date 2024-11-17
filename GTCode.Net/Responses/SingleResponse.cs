namespace GTCode.Net.Responses;

/// <summary>
/// Rappresenta una risposta contenente un oggetto.
/// </summary>
/// <typeparam name="T">il tipo dell'oggetto</typeparam>
/// <seealso cref="GenericResponse"/>
public class SingleResponse<T> : GenericResponse
{
    
    public T? Item { get; set; }

    /// <summary>
    /// Inizzializza la risposta con lo stato <see cref="Status.SUCCESS"/> e l'oggetto fornito.
    /// </summary>
    /// <param name="item">l'oggetto che la risposta dovrà contenere</param>
    public void AsSuccessful(T? item)
    {
        base.AsSuccess();
        this.Item = item;
    }
    
}