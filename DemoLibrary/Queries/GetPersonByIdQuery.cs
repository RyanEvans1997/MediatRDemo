﻿using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Queries
{
    public record GetPersonByIdQuery(int id) : IRequest<PersonModel>;

    // Record -> Class
    //public class GetPersonIdQueryClass : IRequest<PersonModel>
    //{
    //    public int Id { get; set; }

    //    public GetPersonIdQueryClass(int id)
    //    {
    //        id = Id;
    //    }
    //}
}
