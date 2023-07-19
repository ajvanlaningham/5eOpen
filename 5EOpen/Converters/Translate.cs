using _5EOpen.Resources.ResX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5EOpen.Converters
{
    [ContentProperty("Text")]
    public class Translate : IMarkupExtension
    {
        public string Text { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null)
                return null;

            return AppResources.ResourceManager.GetString(Text, AppResources.Culture);
        }

    }
}
