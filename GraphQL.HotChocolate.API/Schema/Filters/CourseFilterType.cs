using GraphQL.HotChocolate.API.Schema.Queries;
using HotChocolate.Data.Filters;

namespace GraphQL.HotChocolate.API.Schema.Filters
{
    public class CourseFilterType : FilterInputType<CourseType>
    {
        protected override void Configure(IFilterInputTypeDescriptor<CourseType> descriptor)
        {
            descriptor.Ignore(c => c.Students);

            base.Configure(descriptor);
        }
    }
}
