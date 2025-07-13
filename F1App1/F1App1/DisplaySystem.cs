public class DisplaySystem
{
    // 各ラップごとのリアルタイム表示
    public void RenderLap(F1DataStore store, int lapNumber)
    {
        Console.Clear();
        Console.WriteLine($"=== Lap {lapNumber} ===");
        Console.WriteLine("ID | Name            | Team       | Best Lap | Laps");
        for (int i = 0; i < store.Count; i++)
        {
            Console.WriteLine(
                $"{store.Ids[i],2} | {store.Names[i],-15} | {store.Teams[i],-10} | {store.BestLapTimes[i],8:0.000} | {store.TotalLaps[i],4}");
        }
    }
}
