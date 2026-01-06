namespace BlazorCrudApp.Services
{
    public class NotificationService
    {
        public string? Message { get; set; }
        public bool IsError { get; set; }

        public void Success(string message)
        {
            Message = message;
            IsError = false;
        }

        public void Error(string message)
        {
            Message = message;
            IsError = true;
        }

        public void Clear()
        {
            Message = null;
            IsError = false;
        }
    }
}
