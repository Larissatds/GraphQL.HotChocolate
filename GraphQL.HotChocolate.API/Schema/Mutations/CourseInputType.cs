﻿using GraphQL.HotChocolate.API.Schema.Queries;

namespace GraphQL.HotChocolate.API.Schema.Mutations
{
    public class CourseInputType
    {
        public string Name { get; set; }

        public Subject Subject { get; set; }

        public Guid InstructorId { get; set; }

    }
}
