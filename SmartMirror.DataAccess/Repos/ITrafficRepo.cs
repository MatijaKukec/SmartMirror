using SmartMirror.DataAccess.Entities.Traffic;
using System.Threading.Tasks;

namespace SmartMirror.DataAccess.Repos
{
    interface ITrafficRepo
    {
        Task <TrafficEntity> GetTrafficInfoAsync(string start, string destination);
    }
}
