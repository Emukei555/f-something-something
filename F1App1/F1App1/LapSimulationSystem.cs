public class LapSimulationSystem
{
    private readonly Random _rand = Random.Shared;

    // 1周分のラップ更新
    public void SimulateOneLap(F1DataStore store)
    {
        var laps  = store.LapsSpan;
        var times = store.BestLapSpan;

        for (int i = 0; i < store.Count; i++)
        {
            float lap = _rand.NextSingle() * 90f + 60f;
            laps[i]++;
            if (lap < times[i])
                times[i] = lap;
        }
    }
}
