public class StatsSystem
{
    // ドライバーごとのベストラップ一覧
    public void ShowBestLaps(F1DataStore store)
    {
        Console.WriteLine("\n🏆 Best Lap Times:");
        for (int i = 0; i < store.Count; i++)
        {
            Console.WriteLine(
                $"{store.Ids[i],2} | {store.Names[i],-15} | {store.Teams[i],-10} | {store.BestLapTimes[i]:0.000}s");
        }
    }

    // 全ドライバーの平均ベストラップ
    public float CalculateAverageBestLap(F1DataStore store)
    {
        var times = store.BestLapSpan;
        float sum = 0;
        for (int i = 0; i < store.Count; i++)
            sum += times[i];
        return store.Count > 0 ? sum / store.Count : 0;
    }
}
