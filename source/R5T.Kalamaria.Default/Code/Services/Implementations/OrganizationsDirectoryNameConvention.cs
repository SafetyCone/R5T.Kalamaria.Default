using System;


namespace R5T.Kalamaria.Default
{
    public class OrganizationsDirectoryNameConvention : IOrganizationsDirectoryNameConvention
    {
        public const string OrganizationsDirectoryName = "Organizations";


        public string GetOrganizationsDirectoryName()
        {
            return OrganizationsDirectoryNameConvention.OrganizationsDirectoryName;
        }
    }
}
