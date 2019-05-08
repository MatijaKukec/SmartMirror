using SmartMirror.DataAccess.Configuration;
using SmartMirror.DataAccess.Entities.Weather;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SmartMirror.DataAccess.Repos
{
    public class WeatherRepo : Repository<WeatherEntity>, IWeatherRepo
    {
        private string _city;

        public async Task<WeatherEntity> GetWeatherEntityByCityAsync(string city)
        {
            FillInputData(city);
            HttpResponseMessage message = await GetHttpResponseMessageAsync();
            WeatherEntity entity = await GetEntityFromJsonAsync(message);

            return entity;
        }
        
        private void FillInputData(string city)
        {


            _apiId = DataAccessConfig.OpenWeatherMapId;
            _apiUrl = DataAccessConfig.OpenWeatherMapUrl;
            _city = city;

            ValidateInput();

            _url = $"{_apiUrl}/weather?q={_city}&appId={_apiId}";
        }

        protected override void ValidateInput()
        {
            base.ValidateInput();
            
            if (string.IsNullOrEmpty(_apiUrl))
            {
                throw new ArgumentNullException("An api url has to be provided!");
            }
        }
        
    }
}
