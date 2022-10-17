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
  public class DetailedSegment : SummarySegment {
    /// <summary>
    /// The time at which the segment was created.
    /// </summary>
    /// <value>The time at which the segment was created.</value>
    [DataMember(Name="created_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The time at which the segment was last updated.
    /// </summary>
    /// <value>The time at which the segment was last updated.</value>
    [DataMember(Name="updated_at", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updated_at")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// The segment's total elevation gain.
    /// </summary>
    /// <value>The segment's total elevation gain.</value>
    [DataMember(Name="total_elevation_gain", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total_elevation_gain")]
    public float? TotalElevationGain { get; set; }

    /// <summary>
    /// Gets or Sets Map
    /// </summary>
    [DataMember(Name="map", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "map")]
    public PolylineMap Map { get; set; }

    /// <summary>
    /// The total number of efforts for this segment
    /// </summary>
    /// <value>The total number of efforts for this segment</value>
    [DataMember(Name="effort_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effort_count")]
    public int? EffortCount { get; set; }

    /// <summary>
    /// The number of unique athletes who have an effort for this segment
    /// </summary>
    /// <value>The number of unique athletes who have an effort for this segment</value>
    [DataMember(Name="athlete_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "athlete_count")]
    public int? AthleteCount { get; set; }

    /// <summary>
    /// Whether this segment is considered hazardous
    /// </summary>
    /// <value>Whether this segment is considered hazardous</value>
    [DataMember(Name="hazardous", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hazardous")]
    public bool? Hazardous { get; set; }

    /// <summary>
    /// The number of stars for this segment
    /// </summary>
    /// <value>The number of stars for this segment</value>
    [DataMember(Name="star_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "star_count")]
    public int? StarCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DetailedSegment {\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  TotalElevationGain: ").Append(TotalElevationGain).Append("\n");
      sb.Append("  Map: ").Append(Map).Append("\n");
      sb.Append("  EffortCount: ").Append(EffortCount).Append("\n");
      sb.Append("  AthleteCount: ").Append(AthleteCount).Append("\n");
      sb.Append("  Hazardous: ").Append(Hazardous).Append("\n");
      sb.Append("  StarCount: ").Append(StarCount).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
