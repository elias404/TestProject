using System;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.SqlClient;

namespace ClassLibraryWithEntities
{
    internal static class EntityConnectionContainer<TEntities>
        where TEntities : ObjectContext
    {
        private static readonly Lazy<EntityConnection> entityConnection = new Lazy<EntityConnection>(buildEntityConnection);

        public static EntityConnection getEntityConnection()
        {
            return entityConnection.Value;
        }

        private static EntityConnection buildEntityConnection()
        {
            ConnectionCredentials<TEntities> credentials = new ConnectionCredentials<TEntities>();
            return buildEntityConnection(credentials);
        }

        private static EntityConnection buildEntityConnection(ConnectionCredentials<TEntities> aConnectionCredentials)
        {
            EntityConnectionStringBuilder connBuilderEntity = new EntityConnectionStringBuilder();

            connBuilderEntity.ProviderConnectionString = buildSqlConnection(aConnectionCredentials);
            connBuilderEntity.Provider = aConnectionCredentials.ProviderName;
            connBuilderEntity.Metadata = aConnectionCredentials.MetaData;

            EntityConnection connection = new EntityConnection(connBuilderEntity.ConnectionString);
            return connection;
        }

        private static string buildSqlConnection(ConnectionCredentials<TEntities> aConnectionCredentials)
        {
            SqlConnectionStringBuilder connBuilderSql = new SqlConnectionStringBuilder();

            connBuilderSql.InitialCatalog = aConnectionCredentials.InitialCatalog;
            connBuilderSql.UserID = aConnectionCredentials.UserID;
            connBuilderSql.Password = aConnectionCredentials.Pass;
            connBuilderSql.PersistSecurityInfo = aConnectionCredentials.PersistSecurityInfo;
            connBuilderSql.MultipleActiveResultSets = aConnectionCredentials.MultipleActiveResultSets;
            connBuilderSql.DataSource = aConnectionCredentials.DataSource;

            return connBuilderSql.ConnectionString;
        }
    }
}