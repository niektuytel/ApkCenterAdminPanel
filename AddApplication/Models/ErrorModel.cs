
namespace AddApplication.Models
{
    class ErrorModel
    {
        public string Error { get; set; }

        public int RequestedTimes { private get; set; }

        public string ErrorType { get; set; }

        public int GetRequestedTimes()
        {
            return RequestedTimes;
        }
    }
}
