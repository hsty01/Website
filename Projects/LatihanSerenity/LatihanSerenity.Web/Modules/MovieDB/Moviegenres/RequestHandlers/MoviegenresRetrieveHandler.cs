﻿using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<LatihanSerenity.MovieDB.MovieGenresRow>;
using MyRow = LatihanSerenity.MovieDB.MovieGenresRow;

namespace LatihanSerenity.MovieDB
{
    public interface IMovieGenresRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class MovieGenresRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IMovieGenresRetrieveHandler
    {
        public MovieGenresRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}