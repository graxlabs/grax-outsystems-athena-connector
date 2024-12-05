using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Athena;
using Amazon.Athena.Model;
using System.IO;
using Amazon;
using Amazon.Runtime;

namespace OutSystems.NssAmazonAthenaConnector
{
    public sealed class AmazonAthena
    {
        #region Private Elements

        private static AmazonAthena _amazonAthena = null;
        private static AmazonAthenaCredentials _amazonAthenaCredentials = null;

        #endregion

        #region Singleton

        private AmazonAthena() { }

        public static AmazonAthena Instance
        {
            get
            {
                if (_amazonAthena == null)
                {
                    _amazonAthena = new AmazonAthena();
                }
                return _amazonAthena;
            }
        }

        #endregion

        #region Public Methods
        
        public void Login(string pInAwsAccessKeyId, string pInAwsSecretAccessKey, string region)
        {
            //Create credential object
            _amazonAthenaCredentials = new AmazonAthenaCredentials();
            _amazonAthenaCredentials.AwsAccessKeyId = pInAwsAccessKeyId;
            _amazonAthenaCredentials.AwsSecretAccessKey = pInAwsSecretAccessKey;

            try
            {
                _amazonAthenaCredentials.AwsRegion = (RegionEndpoint)typeof(RegionEndpoint).GetField(region).GetValue(null); ;
            }
            catch (Exception)
            {
                throw new ArgumentException(string.Format("Invalid region {0}", region));
            }
        }

        public NamedQuery GetNamedQuery(string namedQueryId)
        {
            //Validate configuration
            AmazonAthenaClient amazonAthenaClient = GetClient();

            //Build request
            GetNamedQueryRequest getNamedQueryRequest = new GetNamedQueryRequest()
            {
                NamedQueryId = namedQueryId
            };

            //Call amazon sdk
            GetNamedQueryResponse getNamedQueryResponse = amazonAthenaClient.GetNamedQuery(getNamedQueryRequest);

            //Parse result
            ParseResponse(getNamedQueryResponse);

            //Return result
            return getNamedQueryResponse.NamedQuery;
        }

        public List<string> ListNamedQueries(string workgroup, string inNextToken, int maxResults, out string outNextToken)
        {
            //Validate configuration
            AmazonAthenaClient amazonAthenaClient = GetClient();

            //Build request
            ListNamedQueriesRequest listNamedQueriesRequest = new ListNamedQueriesRequest()
            {
                WorkGroup = !string.IsNullOrEmpty(workgroup) ?  workgroup : null,
                NextToken = !string.IsNullOrEmpty(inNextToken) ? inNextToken : null,
                MaxResults = maxResults
            };

            //Call amazon sdk
            ListNamedQueriesResponse listNamedQueriesResponse = amazonAthenaClient.ListNamedQueries(listNamedQueriesRequest);

            //Parse result
            ParseResponse(listNamedQueriesResponse);

            outNextToken = listNamedQueriesResponse.NextToken;

            //Return result
            return listNamedQueriesResponse.NamedQueryIds;
        }

        public string StartQueryExecution(string clientRequestToken, string queryString, string workGroup, QueryExecutionContext queryExecutionContext = null, ResultConfiguration resultConfiguration = null)
        {
            //Validate configuration
            AmazonAthenaClient amazonAthenaClient = GetClient();

            //Build request
            StartQueryExecutionRequest startQueryExecutionRequest = new StartQueryExecutionRequest()
            {
                ClientRequestToken = !string.IsNullOrEmpty(clientRequestToken) ? clientRequestToken : null,
                QueryString = queryString,
                WorkGroup = !string.IsNullOrEmpty(workGroup) ? workGroup : null,
                QueryExecutionContext = queryExecutionContext,
                ResultConfiguration = resultConfiguration,
            };

            //Call amazon sdk
            StartQueryExecutionResponse startQueryExecutionResponse = amazonAthenaClient.StartQueryExecution(startQueryExecutionRequest);

            //Parse result
            ParseResponse(startQueryExecutionResponse);

            //Return result
            return startQueryExecutionResponse.QueryExecutionId;
        }

        public List<Row> GetQueryResults(string queryExecutionId, string inNextToken, int maxResults, out string outNextToken, out int updateCount)
        {
            //Validate configuration
            AmazonAthenaClient amazonAthenaClient = GetClient();

            //Build request
            GetQueryResultsRequest getQueryResultsRequest = new GetQueryResultsRequest()
            {
                QueryExecutionId = queryExecutionId,
                MaxResults = maxResults,
                NextToken = !string.IsNullOrEmpty(inNextToken) ? inNextToken : null
            };

            //Call amazon sdk
            GetQueryResultsResponse getQueryExecutionResponse = amazonAthenaClient.GetQueryResults(getQueryResultsRequest);

            //Parse result
            ParseResponse(getQueryExecutionResponse);

            outNextToken = getQueryExecutionResponse.NextToken;
            updateCount = (int)getQueryExecutionResponse.UpdateCount;

            //Return result
            return getQueryExecutionResponse.ResultSet.Rows;
        }

        public QueryExecution GetQueryExecution(string queryExecutionId)
        {
            //Validate configuration
            AmazonAthenaClient amazonAthenaClient = GetClient();

            //Build request
            GetQueryExecutionRequest getQueryExecutionRequest = new GetQueryExecutionRequest()
            {
                QueryExecutionId = queryExecutionId
            };

            //Call amazon sdk
            GetQueryExecutionResponse getQueryExecutionResponse = amazonAthenaClient.GetQueryExecution(getQueryExecutionRequest);

            //Parse result
            ParseResponse(getQueryExecutionResponse);

            //Return result
            return getQueryExecutionResponse.QueryExecution;
        }

        #endregion

        #region Private Methods

        private AmazonAthenaClient GetClient()
        {
            //Check c
            if (_amazonAthenaCredentials == null)
            {
                throw (new ArgumentException("Amazon Athena credentials are not properly defined."));
            }

            //Create amazon client
            AmazonAthenaConfig amazonAthenaConfig = new AmazonAthenaConfig();
            amazonAthenaConfig.ServiceURL = _amazonAthenaCredentials.AwsServiceUrl;
            amazonAthenaConfig.RegionEndpoint = _amazonAthenaCredentials.AwsRegion;

            return (new AmazonAthenaClient(_amazonAthenaCredentials.AwsAccessKeyId, _amazonAthenaCredentials.AwsSecretAccessKey, amazonAthenaConfig));
        }

        private void ParseResponse(AmazonWebServiceResponse pInAmazonWebServiceResponse)
        {
            //Check for http error
            if (!(pInAmazonWebServiceResponse.HttpStatusCode.Equals(System.Net.HttpStatusCode.OK) || pInAmazonWebServiceResponse.HttpStatusCode.Equals(System.Net.HttpStatusCode.NoContent)))
            {
                throw (new ArgumentException(string.Format("Error in operation ({0}).", pInAmazonWebServiceResponse.HttpStatusCode)));
            }
        }

        #endregion
    }
}
