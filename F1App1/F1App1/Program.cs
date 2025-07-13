using System;


class Program
{
    static void Main()
    {
        // ドライバー登録
        var store = new F1DataStore(capacity: 10);
        store.AddDriver(1, "Lewis Hamilton",   "Mercedes");
        store.AddDriver(2, "Max Verstappen",   "Red Bull");
        store.AddDriver(3, "Charles Leclerc",  "Ferrari");
        store.AddDriver(4, "Lando Norris",     "McLaren");

        // システム初期化
        var sim   = new LapSimulationSystem();
        var disp  = new DisplaySystem();
        var stats = new StatsSystem();
        var manager = new RaceLoopManager(sim, disp, stats);

        // レース開始
        manager.Run(store, totalLaps: 20, intervalMs: 300);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
