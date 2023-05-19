namespace ServiceContracts.Models
{
    public class CityWeather
    {
        public string CityUniqueCode { get; set; }
        public string CityName { get; set; }
        public DateTime DateAndTime { get; set; }
        public int TemperatureFahrenheit { get; set; }

        public string GetTime()
        {
            string dayPart = DateAndTime.Hour < 12 ? "AM" : "PM";
            return $"{DateAndTime:hh}:{DateAndTime:mm} {dayPart}";
        }

        public string GetDayMonthYear()
        {
            return $"{DateAndTime:dd} {DateAndTime:MMM} {DateAndTime:yyyy}";
        }

    }
}
