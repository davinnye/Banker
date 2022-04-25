using System;


namespace Banker.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
        //When an exception happen to be found on the entities, they are going to throw them here. By saving such exceptions, it will be possible to show them without crashing the main application as well as allowing the user to understand what went wrong.
    }
}
