using System;

namespace MyCompany.Crm.TechnicalStuff
{
    public class DesignError : Exception
    {
        public DesignError(string message) : base(message) { }
        public DesignError(string message, Exception innerException) : base(message, innerException) { }
    }
}