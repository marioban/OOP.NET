using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class GetLanguageTranslation
    {
        public static string GetTranslation(string translationKey)
        {
            var resourceManger = new ResourceManager("WindowsFormsApp.Resources",
               Assembly.GetExecutingAssembly());

            return resourceManger.GetString(translationKey);
        }
    }
}
