using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Route {
    /// <summary>
    /// Gets or Sets Athlete
    /// </summary>
    [DataMember(Name="athlete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "athlete")]
    public SummaryAthlete Athlete { get; set; }

    /// <summary>
    /// The description of the route
    /// </summary>
    /// <value>The description of the route</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The route's distance, in meters
    /// </summary>
    /// <value>The route's distance, in meters</value>
    [DataMember(Name="distance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distance")]
    public float? Distance { get; set; }

    /// <summary>
    /// The route's elevation gain.
    /// </summary>
    /// <value>The route's elevation gain.</value>
    [DataMember(Name="elevation_gain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elevation_gain")]
    public float? ElevationGain { get; set; }

    /// <summary>
    /// The unique identifier of this route
    /// </summary>
    /// <value>The unique identifier of this route</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public long? Id { get; set; }

    /// <summary>
    /// The unique identifier of the route in string format
    /// </summary>
    /// <value>The unique identifier of the route in string format</value>
    [DataMember(Name="id_str", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id_str")]
    public string IdStr { get; set; }

    /// <summary>
    /// Gets or Sets Map
    /// </summary>
    [DataMember(Name="map", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "map")]
    public PolylineMap Map { get; set; }

    /// <summary>
    /// The name of this route
    /// </summary>
    /// <value>The name of this route</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Whether this route is private
    /// </summary>
    /// <value>Whether this route is private</value>
    [DataMember(Name="private", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "private")]
    public bool? Private { get; set; }

    /// <summary>
    /// Whether this route is starred by the logged-in athlete
    /// </summary>
    /// <value>Whether this route is starred by the logged-in athlete</value>
    [DataMember(Name="starred", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "starred")]
    public bool? Starred { get; set; }

    /// <summary>
    /// An epoch timestamp of when the route was created
    /// </summary>
    /// <value>An epoch timestamp of when the route was created</value>
    [DataMember(Name="timestamp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "timestamp")]
    public int? Timestamp { get; set; }

    /// <summary>
    /// This route's type (1 for ride, 2 for runs)
    /// </summary>
    /// <value>This route's type (1 for ride, 2 for runs)</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public int? Type { get; set; }

    /// <summary>
    /// This route's sub-type (1 for road, 2 for mountain bike, 3 for cross, 4 for trail, 5 for mixed)
    /// </summary>
    /// <value>This route's sub-type (1 for road, 2 for mountain bike, 3 for cross, 4 for trail, 5 for mixed)</value>
    [DataMember(Name="sub_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sub_type")]
    public int? SubType { get; set; }

    /// <summary>
    /// The time at which the route was created
    /// </summary>
    /// <value>The time at which the route was created</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The time at which the route was last updated
    /// </summary>
    /// <value>The time at which the route was last updated</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Estimated time in seconds for the authenticated athlete to complete route
    /// </summary>
    /// <value>Estimated time in seconds for the authenticated athlete to complete route</value>
    [DataMember(Name="estimated_moving_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "estimated_moving_time")]
    public int? EstimatedMovingTime { get; set; }

    /// <summary>
    /// The segments traversed by this route
    /// </summary>
    /// <value>The segments traversed by this route</value>
    [DataMember(Name="segments", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "segments")]
    public List<SummarySegment> Segments { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Route {\n");
      sb.Append("  Athlete: ").Append(Athlete).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Distance: ").Append(Distance).Append("\n");
      sb.Append("  ElevationGain: ").Append(ElevationGain).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  IdStr: ").Append(IdStr).Append("\n");
      sb.Append("  Map: ").Append(Map).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Private: ").Append(Private).Append("\n");
      sb.Append("  Starred: ").Append(Starred).Append("\n");
      sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  SubType: ").Append(SubType).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  EstimatedMovingTime: ").Append(EstimatedMovingTime).Append("\n");
      sb.Append("  Segments: ").Append(Segments).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
