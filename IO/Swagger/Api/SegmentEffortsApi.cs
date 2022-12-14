using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISegmentEffortsApi
    {
        /// <summary>
        /// List Segment Efforts Returns a set of the authenticated athlete&#39;s segment efforts for a given segment.  Requires subscription.
        /// </summary>
        /// <param name="segmentId">The identifier of the segment.</param>
        /// <param name="startDateLocal">ISO 8601 formatted date time.</param>
        /// <param name="endDateLocal">ISO 8601 formatted date time.</param>
        /// <param name="perPage">Number of items per page. Defaults to 30.</param>
        /// <returns>List&lt;DetailedSegmentEffort&gt;</returns>
        List<DetailedSegmentEffort> GetEffortsBySegmentId (int? segmentId, DateTime? startDateLocal, DateTime? endDateLocal, int? perPage);
        /// <summary>
        /// Get Segment Effort Returns a segment effort from an activity that is owned by the authenticated athlete. Requires subscription.
        /// </summary>
        /// <param name="id">The identifier of the segment effort.</param>
        /// <returns>DetailedSegmentEffort</returns>
        DetailedSegmentEffort GetSegmentEffortById (long? id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SegmentEffortsApi : ISegmentEffortsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentEffortsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SegmentEffortsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentEffortsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SegmentEffortsApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// List Segment Efforts Returns a set of the authenticated athlete&#39;s segment efforts for a given segment.  Requires subscription.
        /// </summary>
        /// <param name="segmentId">The identifier of the segment.</param> 
        /// <param name="startDateLocal">ISO 8601 formatted date time.</param> 
        /// <param name="endDateLocal">ISO 8601 formatted date time.</param> 
        /// <param name="perPage">Number of items per page. Defaults to 30.</param> 
        /// <returns>List&lt;DetailedSegmentEffort&gt;</returns>            
        public List<DetailedSegmentEffort> GetEffortsBySegmentId (int? segmentId, DateTime? startDateLocal, DateTime? endDateLocal, int? perPage)
        {
            
            // verify the required parameter 'segmentId' is set
            if (segmentId == null) throw new ApiException(400, "Missing required parameter 'segmentId' when calling GetEffortsBySegmentId");
            
    
            var path = "/segment_efforts";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (segmentId != null) queryParams.Add("segment_id", ApiClient.ParameterToString(segmentId)); // query parameter
 if (startDateLocal != null) queryParams.Add("start_date_local", ApiClient.ParameterToString(startDateLocal)); // query parameter
 if (endDateLocal != null) queryParams.Add("end_date_local", ApiClient.ParameterToString(endDateLocal)); // query parameter
 if (perPage != null) queryParams.Add("per_page", ApiClient.ParameterToString(perPage)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "strava_oauth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEffortsBySegmentId: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetEffortsBySegmentId: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<DetailedSegmentEffort>) ApiClient.Deserialize(response.Content, typeof(List<DetailedSegmentEffort>), response.Headers);
        }
    
        /// <summary>
        /// Get Segment Effort Returns a segment effort from an activity that is owned by the authenticated athlete. Requires subscription.
        /// </summary>
        /// <param name="id">The identifier of the segment effort.</param> 
        /// <returns>DetailedSegmentEffort</returns>            
        public DetailedSegmentEffort GetSegmentEffortById (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetSegmentEffortById");
            
    
            var path = "/segment_efforts/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "strava_oauth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSegmentEffortById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSegmentEffortById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DetailedSegmentEffort) ApiClient.Deserialize(response.Content, typeof(DetailedSegmentEffort), response.Headers);
        }
    
    }
}
