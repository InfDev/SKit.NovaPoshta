
namespace SKit.NovaPoshta.Domain
{
    public interface INpRefDescription : INpType
    {
        string Ref { get; set; }
        string Description { get; set; }
    }
}
