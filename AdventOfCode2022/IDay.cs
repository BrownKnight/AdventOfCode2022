namespace AdventOfCode2022;

public interface IDay<TResult>
{
    public TResult Process1(string[] inputs);

    public TResult Process2(string[] inputs);
}

