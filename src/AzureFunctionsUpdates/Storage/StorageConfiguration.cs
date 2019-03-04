﻿namespace AzureFunctionsUpdates.Storage
{
    public class Configuration
    {
        public const string ConnectionName = "TableStorageConnection";

        public class Releases
        {
            public const string TableName = "Releases";
        }
       
        public class RepositoryConfigurations
        {
            public const string TableName = "RepositoryConfigurations";
            public const string PartitionKey = "Repositories";
        }
    }
}