using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using XF.CustomFonts.Constants;

namespace XF.CustomFonts.ViewModels
{
    class FontIconPageViewModel
    {
        public string AndroidIcon => FontIcons.Android;
        public string AppleIcon => FontIcons.Apple;
        public string TwitchIcon => FontIcons.Twitch;

        public IEnumerable<string> Icons { get; }

        public FontIconPageViewModel()
        {
            Icons = typeof(FontIcons).GetFields(BindingFlags.Static | BindingFlags.Public)
                .Select(x => x.GetValue(null) as string);
        }
    }
}
