using System.Threading.Tasks;
using SmartMirror.DataAccess.Entities.Weather;

namespace SmartMirror.DataAccess.Repos
{
    public interface IWeatherRepo
    {
        Task<WeatherEntity> GetWeatherEntityByCityAsync(string city);
    }
}