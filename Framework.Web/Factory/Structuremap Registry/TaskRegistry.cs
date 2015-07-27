using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Framework.Web.Factory.Task;
using StructureMap.Configuration.DSL;

namespace Framework.Web.Factory.Structuremap_Registry
{
    public class TaskRegistry : Registry
    {
        public TaskRegistry()
        {
            Scan(scanner =>
            {
                scanner.AddAllTypesOf<IRunOnInit>();
                scanner.AddAllTypesOf<IRunOnEachRequest>();
            });
        }
    }
}