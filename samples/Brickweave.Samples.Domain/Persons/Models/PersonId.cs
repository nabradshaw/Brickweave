﻿using System;
using Brickweave.Domain;

namespace Brickweave.Samples.Domain.Persons.Models
{
    public class PersonId : Id<Guid>
    {
        public PersonId(Guid value) : base(value)
        {
        }

        public static PersonId NewId()
        {
            return new PersonId(Guid.NewGuid());
        }
    }
}
