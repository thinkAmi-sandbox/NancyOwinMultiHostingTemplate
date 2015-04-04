using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NancyApp
{
    public class RazorConfig : Nancy.ViewEngines.Razor.IRazorConfiguration
    {
        public IEnumerable<string> GetAssemblyNames()
        {
            yield return "NancyApp";
        }

        public IEnumerable<string> GetDefaultNamespaces()
        {
            yield return "NancyApp";
        }

        public bool AutoIncludeModelNamespace
        {
            get { return true; }
        }
    }
}
