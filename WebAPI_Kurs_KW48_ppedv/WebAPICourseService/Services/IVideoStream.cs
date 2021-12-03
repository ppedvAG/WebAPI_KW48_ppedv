using System.IO;
using System.Threading.Tasks;

namespace WebAPICourseService.Services
{
    public interface IVideoStream
    {
        Task<Stream> GetVideoByName(string name);
    }
}
