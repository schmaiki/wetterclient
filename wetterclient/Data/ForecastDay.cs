using System.Reflection.Metadata;

namespace wetterclient.Data;

public class ForecastDay
{
    public DateTime date { get; set; }
    public Astro.Astro? astro{ get; set; }
}