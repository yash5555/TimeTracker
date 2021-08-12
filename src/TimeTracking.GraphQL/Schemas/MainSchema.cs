using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using TimeTracking.Queries.Container;
using System;

namespace TimeTracking.Schemas
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