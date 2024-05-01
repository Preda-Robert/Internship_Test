namespace TestInternship.CraneManager;
class QueryManager
{
    private List<(int quantity, int source, int destination)> queries;

    public QueryManager()
    {
        queries = new List<(int quantity, int source, int destination)>();
    }

    public void AddQuery(string line)
    {
        string[] tokens = line.Split(' ');
        queries.Add((int.Parse(tokens[1]), int.Parse(tokens[3]), int.Parse(tokens[5])));
    }

    public void ExecuteQueries(StackManager stacks)
    {
        foreach (var query in queries)
            for (int i = 0; i < query.quantity; i++)
                stacks.Move(query.source, query.destination);
    }
}
