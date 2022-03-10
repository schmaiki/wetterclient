using System.Collections.Generic;

namespace wetterclient.Data;

public class WeatherMapRespone
{
    public Location? location { get; set; }
    public Current? current { get; set; }
    public Forecast? forecast { get; set; }
}