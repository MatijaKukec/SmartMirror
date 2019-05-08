using System;
using System.Net.Http;
using System.Threading.Tasks;
using SmartMirror.DataAccess.Configuration;
using SmartMirror.DataAccess.Entities.Traffic;

namespace SmartMirror.DataAccess.Repos
{
    public class TrafficRepo : Repository<TrafficEntity>, ITrafficRepo
    {
        private string _start;
        private string _destination;

        public async Task<TrafficEntity> GetTrafficInfoAsync(string start, string destination)
        {
            FillInputData(start, destination);
            HttpResponseMessage message = await GetHttpResponseMessageAsync();
            TrafficEntity entity = await GetEntityFromJsonAsync(message);


            return entity;
        }


        private void FillInputData(string start, string destination)
        {
            _apiId = DataAccessConfig.TrafficApiId;
            _apiUrl = DataAccessConfig.TrafficApiUrl;
            _start = start;
            _destination = destination;


            ValidateInput();


            _url = $"{_apiUrl}?origins={start}&destinations={destination}&key={_apiId}";
        }


        protected override void ValidateInput()
        {
            base.ValidateInput();

            if (string.IsNullOrWhiteSpace(_start)) { throw new ArgumentNullException("A start location has to be provided"); }
            if (string.IsNullOrWhiteSpace(_destination)) { throw new ArgumentNullException("A destination has to be provided"); }
        }
        

    }
} 
