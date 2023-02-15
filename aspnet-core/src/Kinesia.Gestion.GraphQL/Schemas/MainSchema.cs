using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using Kinesia.Gestion.Queries.Container;
using System;

namespace Kinesia.Gestion.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IServiceProvider provider) :
            base(provider)
        {
            Query = provider.GetRequiredService<QueryContainer>();
        }
    }
}