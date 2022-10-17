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
  public class DetailedActivity : SummaryActivity {
    /// <summary>
    /// The description of the activity
    /// </summary>
    /// <value>The description of the activity</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Photos
    /// </summary>
    [DataMember(Name="photos", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "photos")]
    public PhotosSummary Photos { get; set; }

    /// <summary>
    /// Gets or Sets Gear
    /// </summary>
    [DataMember(Name="gear", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gear")]
    public SummaryGear Gear { get; set; }

    /// <summary>
    /// The number of kilocalories consumed during this activity
    /// </summary>
    /// <value>The number of kilocalories consumed during this activity</value>
    [DataMember(Name="calories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "calories")]
    public float? Calories { get; set; }

    /// <summary>
    /// Gets or Sets SegmentEfforts
    /// </summary>
    [DataMember(Name="segment_efforts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "segment_efforts")]
    public List<DetailedSegmentEffort> SegmentEfforts { get; set; }

    /// <summary>
    /// The name of the device used to record the activity
    /// </summary>
    /// <value>The name of the device used to record the activity</value>
    [DataMember(Name="device_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "device_name")]
    public string DeviceName { get; set; }

    /// <summary>
    /// The token used to embed a Strava activity
    /// </summary>
    /// <value>The token used to embed a Strava activity</value>
    [DataMember(Name="embed_token", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "embed_token")]
    public string EmbedToken { get; set; }

    /// <summary>
    /// The splits of this activity in metric units (for runs)
    /// </summary>
    /// <value>The splits of this activity in metric units (for runs)</value>
    [DataMember(Name="splits_metric", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "splits_metric")]
    public List<Split> SplitsMetric { get; set; }

    /// <summary>
    /// The splits of this activity in imperial units (for runs)
    /// </summary>
    /// <value>The splits of this activity in imperial units (for runs)</value>
    [DataMember(Name="splits_standard", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "splits_standard")]
    public List<Split> SplitsStandard { get; set; }

    /// <summary>
    /// Gets or Sets Laps
    /// </summary>
    [DataMember(Name="laps", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "laps")]
    public List<Lap> Laps { get; set; }

    /// <summary>
    /// Gets or Sets BestEfforts
    /// </summary>
    [DataMember(Name="best_efforts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "best_efforts")]
    public List<DetailedSegmentEffort> BestEfforts { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DetailedActivity {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Photos: ").Append(Photos).Append("\n");
      sb.Append("  Gear: ").Append(Gear).Append("\n");
      sb.Append("  Calories: ").Append(Calories).Append("\n");
      sb.Append("  SegmentEfforts: ").Append(SegmentEfforts).Append("\n");
      sb.Append("  DeviceName: ").Append(DeviceName).Append("\n");
      sb.Append("  EmbedToken: ").Append(EmbedToken).Append("\n");
      sb.Append("  SplitsMetric: ").Append(SplitsMetric).Append("\n");
      sb.Append("  SplitsStandard: ").Append(SplitsStandard).Append("\n");
      sb.Append("  Laps: ").Append(Laps).Append("\n");
      sb.Append("  BestEfforts: ").Append(BestEfforts).Append("\n");
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
