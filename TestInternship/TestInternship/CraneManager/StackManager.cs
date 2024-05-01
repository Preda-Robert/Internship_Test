namespace TestInternship.CraneManager;
class StackManager
{
    private List<List<char>> stacks;
    private int stackCount;

    public StackManager(int size)
    {
        stackCount = size;
        stacks = new List<List<char>>();
        for (int i = 0; i < stackCount; i++)
            stacks.Add(new List<char>());
    }

    public void AddData(string line)
    {
        for (int i = 0; i < stackCount; i++)
            if (line[i * 4 + 1] != ' ')
                stacks[i].Add(line[i * 4 + 1]);
    }

    public void Move(int source, int destination)
    {
        if (stacks[source - 1].Count == 0)
            return;

        char data = stacks[source - 1][0];
        stacks[source - 1].RemoveAt(0);
        stacks[destination - 1].Insert(0, data);
    }

    public string GetOutput()
    {
        string output = "";
        for (int i = 0; i < stackCount; i++)
            output += stacks[i][0];

        return output;
    }
}
