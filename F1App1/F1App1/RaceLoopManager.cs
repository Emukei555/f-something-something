using System.Diagnostics;

public class RaceLoopManager
{
    private readonly LapSimulationSystem _sim;
    private readonly DisplaySystem       _disp;
    private readonly StatsSystem         _stats;

    public RaceLoopManager(
        LapSimulationSystem sim,
        DisplaySystem disp,
        StatsSystem stats)
    {
        _sim   = sim;
        _disp  = disp;
        _stats = stats;
    }

    public void Run(F1DataStore store, int totalLaps, int intervalMs = 500)
    {
        var sw = Stopwatch.StartNew();

        for (int lap = 1; lap <= totalLaps; lap++)
        {
            _sim.SimulateOneLap(store);
            _disp.RenderLap(store, lap);
            Thread.Sleep(intervalMs);
        }

        sw.Stop();
        Console.WriteLine($"\nFinished {totalLaps} laps in {sw.Elapsed:mm\\:ss\\.fff}");

        _stats.ShowBestLaps(store);
        float avg = _stats.CalculateAverageBestLap(store);
        Console.WriteLine($"\nAverage Best Lap: {avg:0.000}s");
    }
}
