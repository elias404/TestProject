using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;

namespace ClassLibraryWithEntities
{
    internal class ConnectionCredentials<TEntities>
       where TEntities : ObjectContext
    {
        private readonly string dataSource = "SOFTSRV";
        private readonly string initialCatalog = "Meerkat";
        private readonly string metaData = string.Format("res://*/{0}.csdl|res://*/{0}.ssdl|res://*/{0}.msl", typeof(TEntities).Name.Replace("Entities", "Model"));
        private readonly bool multipleActiveResultSets = true;
        private readonly string password;
        private readonly bool persistSecurityInfo = true;
        private readonly string providerName = "System.Data.SqlClient";
        private readonly string userID;

        #region Properties

        public bool PersistSecurityInfo
        {
            get
            {
                return persistSecurityInfo;
            }
        }

        public bool MultipleActiveResultSets
        {
            get
            {
                return multipleActiveResultSets;
            }
        }

        public string UserID
        {
            get
            {
                return userID;
            }
        }

        public string Pass
        {
            get
            {
                return password;
            }
        }

        public string InitialCatalog
        {
            get
            {
                return initialCatalog;
            }
        }

        public string DataSource
        {
            get
            {
                return dataSource;
            }
        }

        public string ProviderName
        {
            get
            {
                return providerName;
            }
        }

        public string MetaData
        {
            get
            {
                return metaData;
            }
        }

        #endregion

        public ConnectionCredentials()
            : this("gada08", "80adag")
        {
        }

        private ConnectionCredentials(string userID, string password)
        {
            this.userID = userID;
            this.password = password;
        }
    }
}
