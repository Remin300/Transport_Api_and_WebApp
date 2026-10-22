
namespace WebApplication1.Tools
{
    public enum ErrorType
    {
        None,
        NotFound,
        Validation,
        Unauthorized,
        Forbidden,
        Conflict,
        Failure
    }

    public class Result
    {
        public bool Success { get; set; }
        public string? Error { get; set; }
        public ErrorType ErrorType { get; set; } = ErrorType.None;

        public static Result Ok()
        {
            return new Result
            {
                Success = true,
                ErrorType = ErrorType.None
            };
        }

        public static Result Fail(
            string message,
            ErrorType errorType = ErrorType.Failure)
        {
            return new Result
            {
                Success = false,
                Error = message,
                ErrorType = errorType
            };
        }
    }

    public class Result<T> : Result
    {
        public T? Data { get; set; }

        public static Result<T> Ok(T data)
        {
            return new Result<T>
            {
                Success = true,
                Data = data,
                ErrorType = ErrorType.None
            };
        }

        public new static Result<T> Fail(
            string message,
            ErrorType errorType = ErrorType.Failure)
        {
            return new Result<T>
            {
                Success = false,
                Error = message,
                ErrorType = errorType
            };
        }
    }
}