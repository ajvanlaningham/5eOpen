using LocalizationResourceManager.Maui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5EOpen.Converters
{
    public class TranslateExtension
    {
        ILocalizationResourceManager _localizationResourceManager;
        
        public TranslateExtension(ILocalizationResourceManager localizationResourceManager)
        {
            _localizationResourceManager = localizationResourceManager;
        }

        public string GetValue(string key)
        {
            if (String.IsNullOrEmpty(key))
                return "";

            var translatedValue = getResx(key);
            
            if (String.IsNullOrEmpty(translatedValue))
                return key;
            else
                return translatedValue;
            
        }

        private string getResx(string key)
        {
            var resx = _localizationResourceManager[key];
            return resx;
        }
        
       
    }
}
