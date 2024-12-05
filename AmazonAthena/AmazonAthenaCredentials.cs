
using Amazon;

namespace OutSystems.NssAmazonAthenaConnector
{
    public class AmazonAthenaCredentials
    {
        #region Properties

        public RegionEndpoint AwsRegion { get; set; }
        public string AwsServiceUrl { get; set; }
        public string AwsAccessKeyId { get; set; }
        public string AwsSecretAccessKey { get; set; }

        #endregion
    }
}