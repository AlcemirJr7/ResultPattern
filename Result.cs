﻿namespace ResultPattern
{
    public class Result<T>
    {
        public bool IsSuccess { get; }
        public T Value { get; }
        public string Error { get; }

        private Result(T value, bool isSuccess, string error)
        {
            IsSuccess = isSuccess;
            Value = value;
            Error = error;
        }

        public static Result<T> Success(T value) => new Result<T>(value, true, null);

        public static Result<T> Failure(string error) => new Result<T>(default, false, error);
    }
}
