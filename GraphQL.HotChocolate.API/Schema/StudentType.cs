﻿namespace GraphQL.HotChocolate.API.Schema
{
    public class StudentType
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double GPA { get; set; }
    }
}
