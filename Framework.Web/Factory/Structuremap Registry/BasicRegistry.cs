using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace Framework.Web.Factory.Structuremap_Registry
{
    public class BasicRegistry : Registry
    {
        public BasicRegistry()
        {
            Scan( scanner =>
            {
                scanner.TheCallingAssembly();
                scanner.WithDefaultConventions();
            });
        }
    }
}