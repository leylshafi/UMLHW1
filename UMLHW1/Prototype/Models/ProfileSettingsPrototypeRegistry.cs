using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLHW1.Prototype.Models
{
    public class ProfileSettingsPrototypeRegistry
    {
        private readonly ProfileSettings _defaultProfileSettings;
        private readonly ProfileSettings _secureProfileSettings;

        public ProfileSettingsPrototypeRegistry(ProfileSettings defaultProfileSettings, ProfileSettings secureProfileSettings)
        {
            _defaultProfileSettings = defaultProfileSettings;
            _secureProfileSettings = secureProfileSettings;
        }

        public ProfileSettings CreateDefaultProfileSettings()
        {
            return _defaultProfileSettings.Clone();
        }

        public ProfileSettings CreateSecureProfileSettings()
        {
            return _secureProfileSettings.Clone();
        }
    }
}
