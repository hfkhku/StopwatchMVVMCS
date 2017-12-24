namespace MStopwatch.Models
{
    public static class Constants
    {
        public static string TimeSpanFormat { get; } = @"hh\:mm\:ss\""fff";

        public static string TimeSpanFormatNoMillsecond { get; } = @"hh\:mm\:ss\""";

        public static string DateTimeFormat { get; } = "yyyy/MM/dd HH:mm:ss";
    }
}