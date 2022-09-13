
namespace SKit.NovaPoshta.Domain;

/// <summary>
/// Represents base item with reference key
/// </summary>
public abstract class NpBaseReference : INpType
{
    /// <summary>
    /// Gets or sets  item unique reference key
    /// </summary>
    public Guid Reference { get; set; }

    /// <summary>
    /// Serves as the default hash function.
    /// </summary>
    /// <returns>Instance hash code</returns>
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    /// <summary>
    ///  Determines whether the specified object is equal to the current object.
    /// </summary>
    /// <param name="obj">The object to compare with the current object.</param>
    /// <returns>'true' if the specified object is equal to the current object; otherwise, 'false'.</returns>
    public override bool Equals(object? obj)
    {
        if (obj?.GetType() != this.GetType())
            return false;

        var compare = (NpBaseReference)obj;

        return this.Reference == compare.Reference;
    }
}

