using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace Framework.Web.Factory.Structuremap_Registry
{
    public class ControllerRegistry : Registry
    {
        public ControllerRegistry()
        {
            Scan(scanner =>
            {
                scanner.TheCallingAssembly();
                scanner.With(new ControllerConvention());
            });
        }
    }
}