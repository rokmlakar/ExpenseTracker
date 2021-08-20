namespace ExpenseTracker.Shared.Respones
{
    public class ApiErrorResponse
    {
        public string Messsage { get; set; }
        public string[] Errors { get; set; }
        public bool IsSuccess { get; set; }
    }

}
