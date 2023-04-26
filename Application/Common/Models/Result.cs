namespace Application.Common.Models;
public class Result
{
    public bool Succeded { get; set; }
    public string[] Errors { get; set; }

    internal Result(bool succeded, IEnumerable<string> errors)
    {
        Succeded = succeded;
        Errors = errors.ToArray();
    }

    public static Result Success()
    {
        return new Result(true, Array.Empty<string>());
    }
    public static Result Failure(IEnumerable<string> errors)
    {
        return new Result(false, errors);
    }
}

