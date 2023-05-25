using System;
namespace HR.LeaveManagement.Application.Responses
{
    public class BaseCommandResponse
    {
        public int Id { set; get; }
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<String> Errors { get; set; }
    }
}

