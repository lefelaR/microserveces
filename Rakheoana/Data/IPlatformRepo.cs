using Rakheoana.Models;
using System.Collections.Generic;

namespace Rakheoana.Data{
    public interface IPlatformRepo
    {
        
        bool SaveChanges();
        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformById(int Id);
        void CreatePlatform (Platform platform);
    }
}
