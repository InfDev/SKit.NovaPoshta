
namespace SKit.NovaPoshta.Client.Requests.TrackingDocument
{
    public class GetStatusDocumentsProperties
    {
        public GetStatusDocumentsProperties()
        {
        }

        public GetStatusDocumentsProperties(TrackingDocumentItemSearch[] documents)
        {
            if (documents == null)
                throw new ArgumentNullException(nameof(documents));
            Documents = documents;
        }

        public TrackingDocumentItemSearch[] Documents { get; set; } = new TrackingDocumentItemSearch[0];
    }

    public class TrackingDocumentItemSearch
    {
        private string _phone = String.Empty;

        /// <summary>
        /// Номер документа
        /// </summary>
        public string DocumentNumber { get; set; } = string.Empty;
        
        /// <summary>
        /// 
        /// </summary>
        public string? Phone { 
            get => _phone; 
            set => _phone = SafePhone(value) ?? String.Empty;
        }

        private string? SafePhone(string? value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return null;
            var numbers = string.Concat(value.Where(Char.IsDigit));
            return numbers;
        }
    }

}
