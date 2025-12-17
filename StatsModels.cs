namespace RezidentiatViz
{
    public class StatisticsData
    {
        public List<CountyMetric> Averages { get; set; } = new();
        public List<CountyCount> Counts { get; set; } = new();
        public List<ScoreDist> Distribution { get; set; } = new();
    }

    public class CountyMetric
    {
        public string County { get; set; } = "";
        public double Score { get; set; }
        public int Year { get; set; }
    }

    public class CountyCount
    {
        public string County { get; set; } = "";
        public int Count { get; set; }
        public int Year { get; set; }
    }

    public class ScoreDist
    {
        public string Range { get; set; } = "";
        public int Count { get; set; }
        public int Year { get; set; }
    }

    public class AnonymityStat
    {
        public int Year { get; set; }
        public int Anonymous { get; set; }
        public int Named { get; set; }
        public int Total { get; set; }
    }


    public class AttendanceStat
    {
        public int Year { get; set; }
        public int Present { get; set; }
        public int Absent { get; set; }
        public int TotalRegistered { get; set; }
    }
}