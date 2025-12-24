using System;

namespace ExceptionAssignment;


internal class InvalidFlavourException : Exception
{
    public InvalidFlavourException()
    {
    }

    public InvalidFlavourException(string? message) : base(message)
    {
    }

    public InvalidFlavourException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}