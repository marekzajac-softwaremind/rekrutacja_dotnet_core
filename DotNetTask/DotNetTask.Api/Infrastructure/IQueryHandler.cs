﻿namespace DotNetTask.Api.Infrastructure
{
    public interface IQueryHandler<in TQuery, out TResult>
        where TQuery: IQuery
    {
        TResult Handle(TQuery query);
    }
}
