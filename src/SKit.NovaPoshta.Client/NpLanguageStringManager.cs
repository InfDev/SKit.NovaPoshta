
using System.Globalization;

namespace SKit.NovaPoshta.Client
{
    public class NpLanguageStringManager : INpLanguageStringManager
    {
        public NpLanguage DefaultLanguage { get; set; } = NpLanguage.Ukrainian;
        public NpLanguage CurrentUILanguage
        {
            get
            {
                var cultureName = CultureInfo.CurrentUICulture.Name.Substring(0, 2);
                switch (cultureName)
                {
                    case "ru": return NpLanguage.Russian;
                    case "en": return NpLanguage.English;
                }
                return NpLanguage.Ukrainian;
            }
        }

        //public string GetLocalizedString(object obj, string propName, NpLanguage npLanguage)
        //{
        //    if (obj == null)
        //        throw new ArgumentNullException(nameof(obj));
        //    if (string.IsNullOrWhiteSpace(propName))
        //        throw new ArgumentNullException(nameof(obj));
        //    var props = obj.GetType().GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.GetProperty)
        //            .Where(x => System.Type.GetTypeCode(x.PropertyType) == TypeCode.String && x.Name.StartsWith(propName))
        //            .OrderBy(x => x.Name)                    
        //            .ToArray();
        //    if (props.Length == 0)
        //        throw new ArgumentException($"Unknown property: {propName}");
        //    var value = props[0].GetValue(obj);
        //    switch(npLanguage)
        //    {
        //        case NpLanguage.Ukrainian:
        //    }
        //}
    }
}
