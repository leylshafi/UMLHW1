using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLHW1.Prototype.Models;

public class ProfileSettings
{
    public bool IsPrivate { get; set; }
    public bool HideEmail { get; set; }
    public bool HideAge { get; set; }

    public ProfileSettings Clone()
    {
        return new ProfileSettings()
        {
            IsPrivate = IsPrivate,
            HideEmail = HideEmail,
            HideAge = HideAge
        };
    }
}
