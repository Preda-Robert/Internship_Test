namespace TestInternship.CraneManager;

class Crane
{
    private StackManager stacks;
    private QueryManager queries;
    public Crane(string[] input)
    {
        queries = new QueryManager();
        int stackCount = (input[0].Length + 1) / 4;
        stacks = new StackManager(stackCount);

        foreach (string line in input)
            if (isQuery(line))
                queries.AddQuery(line);
            else if (isData(line))
                stacks.AddData(line);

        queries.ExecuteQueries(stacks);

        string output = stacks.GetOutput();
        Console.WriteLine(output);
    }

    public bool isQuery(string line)
    {
        if (line.Contains("move"))
            return true;
        return false;
    }

    public bool isData(string line)
    {
        if (line.Contains('['))
            return true;
        return false;
    }

}
