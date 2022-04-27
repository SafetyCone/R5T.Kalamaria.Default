using System;using R5T.T0064;


namespace R5T.Kalamaria.Default
{[ServiceImplementationMarker]
    public class OrganizationsDirectoryNameConvention : IOrganizationsDirectoryNameConvention,IServiceImplementation
    {
        public const string OrganizationsDirectoryName = "Organizations";


        public string GetOrganizationsDirectoryName()
        {
            return OrganizationsDirectoryNameConvention.OrganizationsDirectoryName;
        }
    }
}
