using System;

namespace CommunityHospitalApi.Shared
{
    public static class Helper
    {

        public static bool IsApiKeyValid(string apiKey)      
        {
                if (string.IsNullOrEmpty(apiKey))
                {
                    return false;
                }

                if(!apiKey.Equals(Constants.Constants.ApiKey, StringComparison.CurrentCultureIgnoreCase))
                {
                    return false;   
                }

                return true;
        }
    }
}
