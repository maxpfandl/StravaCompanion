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
  public class DetailedSegmentEffort : SummarySegmentEffort {
    /// <summary>
    /// The name of the segment on which this effort was performed
    /// </summary>
    /// <value>The name of the segment on which this effort was performed</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Activity
    /// </summary>
    [DataMember(Name="activity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activity")]
    public MetaActivity Activity { get; set; }

    /// <summary>
    /// Gets or Sets Athlete
    /// </summary>
    [DataMember(Name="athlete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "athlete")]
    public MetaAthlete Athlete { get; set; }

    /// <summary>
    /// The effort's moving time
    /// </summary>
    /// <value>The effort's moving time</value>
    [DataMember(Name="moving_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "moving_time")]
    public int? MovingTime { get; set; }

    /// <summary>
    /// The start index of this effort in its activity's stream
    /// </summary>
    /// <value>The start index of this effort in its activity's stream</value>
    [DataMember(Name="start_index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_index")]
    public int? StartIndex { get; set; }

    /// <summary>
    /// The end index of this effort in its activity's stream
    /// </summary>
    /// <value>The end index of this effort in its activity's stream</value>
    [DataMember(Name="end_index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end_index")]
    public int? EndIndex { get; set; }

    /// <summary>
    /// The effort's average cadence
    /// </summary>
    /// <value>The effort's average cadence</value>
    [DataMember(Name="average_cadence", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "average_cadence")]
    public float? AverageCadence { get; set; }

    /// <summary>
    /// The average wattage of this effort
    /// </summary>
    /// <value>The average wattage of this effort</value>
    [DataMember(Name="average_watts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "average_watts")]
    public float? AverageWatts { get; set; }

    /// <summary>
    /// For riding efforts, whether the wattage was reported by a dedicated recording device
    /// </summary>
    /// <value>For riding efforts, whether the wattage was reported by a dedicated recording device</value>
    [DataMember(Name="device_watts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "device_watts")]
    public bool? DeviceWatts { get; set; }

    /// <summary>
    /// The heart heart rate of the athlete during this effort
    /// </summary>
    /// <value>The heart heart rate of the athlete during this effort</value>
    [DataMember(Name="average_heartrate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "average_heartrate")]
    public float? AverageHeartrate { get; set; }

    /// <summary>
    /// The maximum heart rate of the athlete during this effort
    /// </summary>
    /// <value>The maximum heart rate of the athlete during this effort</value>
    [DataMember(Name="max_heartrate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "max_heartrate")]
    public float? MaxHeartrate { get; set; }

    /// <summary>
    /// Gets or Sets Segment
    /// </summary>
    [DataMember(Name="segment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "segment")]
    public SummarySegment Segment { get; set; }

    /// <summary>
    /// The rank of the effort on the global leaderboard if it belongs in the top 10 at the time of upload
    /// </summary>
    /// <value>The rank of the effort on the global leaderboard if it belongs in the top 10 at the time of upload</value>
    [DataMember(Name="kom_rank", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "kom_rank")]
    public int? KomRank { get; set; }

    /// <summary>
    /// The rank of the effort on the athlete's leaderboard if it belongs in the top 3 at the time of upload
    /// </summary>
    /// <value>The rank of the effort on the athlete's leaderboard if it belongs in the top 3 at the time of upload</value>
    [DataMember(Name="pr_rank", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pr_rank")]
    public int? PrRank { get; set; }

    /// <summary>
    /// Whether this effort should be hidden when viewed within an activity
    /// </summary>
    /// <value>Whether this effort should be hidden when viewed within an activity</value>
    [DataMember(Name="hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hidden")]
    public bool? Hidden { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DetailedSegmentEffort {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Activity: ").Append(Activity).Append("\n");
      sb.Append("  Athlete: ").Append(Athlete).Append("\n");
      sb.Append("  MovingTime: ").Append(MovingTime).Append("\n");
      sb.Append("  StartIndex: ").Append(StartIndex).Append("\n");
      sb.Append("  EndIndex: ").Append(EndIndex).Append("\n");
      sb.Append("  AverageCadence: ").Append(AverageCadence).Append("\n");
      sb.Append("  AverageWatts: ").Append(AverageWatts).Append("\n");
      sb.Append("  DeviceWatts: ").Append(DeviceWatts).Append("\n");
      sb.Append("  AverageHeartrate: ").Append(AverageHeartrate).Append("\n");
      sb.Append("  MaxHeartrate: ").Append(MaxHeartrate).Append("\n");
      sb.Append("  Segment: ").Append(Segment).Append("\n");
      sb.Append("  KomRank: ").Append(KomRank).Append("\n");
      sb.Append("  PrRank: ").Append(PrRank).Append("\n");
      sb.Append("  Hidden: ").Append(Hidden).Append("\n");
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
