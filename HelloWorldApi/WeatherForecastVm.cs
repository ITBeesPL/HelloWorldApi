namespace HelloWorldApi
{
    public class WeatherForecastIm
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string? Summary { get; set; }
    }

    public class WeatherForecastVm
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        public string? Summary { get; set; }
    }

    public class WeatherForecastUm
    {
        public int Id { get; set; }
        public int TemperatureC { get; set; }
        public string? Summary { get; set; }
    }

    public class WeatherForecastDm
    {
        public int Id { get; set; }
    }
}
