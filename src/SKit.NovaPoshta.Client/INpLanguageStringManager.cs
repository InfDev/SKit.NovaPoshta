
namespace SKit.NovaPoshta.Client
{
    public interface INpLanguageStringManager
    {
        NpLanguage DefaultLanguage { get; set; }
        NpLanguage CurrentUILanguage { get; }

//        string GetLocalizedString(object obj, string propName, NpLanguage npLanguage);

    }
}
