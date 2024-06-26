﻿namespace MatchBuddy.Core.Utilities.Results
{
    public class Result : IResult
    {
        //
        public Result(bool success, string mesage): this(success)
        {
            Message = mesage;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message {  get; }
    }
}
