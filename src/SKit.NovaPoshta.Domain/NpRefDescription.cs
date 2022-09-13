
namespace SKit.NovaPoshta.Domain
{
    public class NpRefDescription : INpRefDescription
    {
        public string Ref { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public override string ToString()
        {
            return this.Description;
        }
    }
}
