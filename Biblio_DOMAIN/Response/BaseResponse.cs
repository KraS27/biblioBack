using Biblio_DOMAIN.Enum;


namespace Biblio_DOMAIN.Response
{
    public class BaseResponse<T>
    {
        public T Data { get; set; }

        public string Description { get; set; }

        public ResponseStatus Status { get; set; }
    }
}
