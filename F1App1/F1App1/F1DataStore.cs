public class F1DataStore
{
    // SoA: Structure of Arrays
    public readonly int[] Ids;
    public readonly string[] Names;
    public readonly string[] Teams;
    public readonly float[] BestLapTimes;
    public readonly int[] TotalLaps;

    public int Count { get; private set; }

    public F1DataStore(int capacity)
    {
        Ids = new int[capacity];
        Names = new string[capacity];
        Teams = new string[capacity];
        BestLapTimes = new float[capacity];
        TotalLaps = new int[capacity];
        Count = 0;
    }

    public void AddDriver(int id, string name, string team)
    {
        var i = Count++;
        Ids[i] = id;
        Names[i] = name;
        Teams[i] = team;
        BestLapTimes[i] = float.MaxValue;
        TotalLaps[i] = 0;
    }

    // 高速アクセス用 Span
    public Span<float> BestLapSpan => BestLapTimes.AsSpan(0, Count);
    public Span<int> LapsSpan => TotalLaps.AsSpan(0, Count);
}
