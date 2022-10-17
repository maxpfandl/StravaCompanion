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
  public class SummaryPRSegmentEffort {
    /// <summary>
    /// The unique identifier of the activity related to the PR effort.
    /// </summary>
    /// <value>The unique identifier of the activity related to the PR effort.</value>
    [DataMember(Name="pr_activity_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pr_activity_id")]
    public long? PrActivityId { get; set; }

    /// <summary>
    /// The elapsed time ot the PR effort.
    /// </summary>
    /// <value>The elapsed time ot the PR effort.</value>
    [DataMember(Name="pr_elapsed_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pr_elapsed_time")]
    public int? PrElapsedTime { get; set; }

    /// <summary>
    /// The time at which the PR effort was started.
    /// </summary>
    /// <value>The time at which the PR effort was started.</value>
    [DataMember(Name="pr_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pr_date")]
    public DateTime? PrDate { get; set; }

    /// <summary>
    /// Number of efforts by the authenticated athlete on this segment.
    /// </summary>
    /// <value>Number of efforts by the authenticated athlete on this segment.</value>
    [DataMember(Name="effort_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "effort_count")]
    public int? EffortCount { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SummaryPRSegmentEffort {\n");
      sb.Append("  PrActivityId: ").Append(PrActivityId).Append("\n");
      sb.Append("  PrElapsedTime: ").Append(PrElapsedTime).Append("\n");
      sb.Append("  PrDate: ").Append(PrDate).Append("\n");
      sb.Append("  EffortCount: ").Append(EffortCount).Append("\n");
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
