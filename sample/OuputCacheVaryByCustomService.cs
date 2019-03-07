using WebEssentials.AspNetCore.OutputCaching;

namespace Sample
{
    public class OuputCacheVaryByCustomService : IOutputCacheVaryByCustomService
    {
        public string GetVaryByCustomString(string arg)
        {
            if (arg == "foo")
            {
                return "bar";
            }
            else
            {
                return string.Empty;
            }
        }
    }
}