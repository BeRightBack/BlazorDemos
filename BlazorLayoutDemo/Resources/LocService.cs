using Microsoft.Extensions.Localization;
using System.Reflection;

namespace Resources
{
    public class LocService
    {
        private readonly IStringLocalizer _localizer;

        public LocService(IStringLocalizerFactory factory)
        {
            Type type = typeof(SharedResource);
            AssemblyName assemblyName = new(type.GetTypeInfo().Assembly.FullName!); // Add null-forgiving operator
            _localizer = factory.Create("SharedResource", assemblyName.Name!); // Add null-forgiving operator
        }

        public LocalizedString GetLocalizedHtmlString(string key)
        {
            return _localizer[key];
        }
        public LocalizedString GetLocalizedHtmlStringAllowNull(string key)
        {
            if (!string.IsNullOrWhiteSpace(key))
            {
                return _localizer[key];
            }

            return new LocalizedString(key, string.Empty);
        }

        public LocalizedString GetLocalizedHtmlString(string key, string parameter)
        {
            return _localizer[key, parameter];
        }

    }
}
