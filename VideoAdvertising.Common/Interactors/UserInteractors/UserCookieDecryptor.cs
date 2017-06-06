using VideoAdvertising.Common.Objects.SecurityObjects;

namespace VideoAdvertising.Common.Interactors.UserInteractors
{
    public class UserCookieDecryptor
    {
        public LoginMemorizationModel DecryptValue(string loginString)
        {
            string[] splitString = loginString.Split('|');
            if (splitString.Length != 2)
            {
                return new LoginMemorizationModel();
            }
            return new LoginMemorizationModel { User = splitString[0], LoginToken = splitString[1]}; 
        }
    }
}
