namespace MarketPlace.Application.Commands
{
    public class GenericCommandResult
    {
        public GenericCommandResult() { }

        public GenericCommandResult(int status, bool success, dynamic message, object data)
        {
            Status = status;
            Success = success;
            Message = message;
            Data = data;
        }

        public int Status { get; set; }
        public bool Success { get; set; }
        public dynamic Message { get; set; }
        public object Data { get; set; }
    }
}