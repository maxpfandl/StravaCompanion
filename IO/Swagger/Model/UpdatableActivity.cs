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
  public class UpdatableActivity {
    /// <summary>
    /// Whether this activity is a commute
    /// </summary>
    /// <value>Whether this activity is a commute</value>
    [DataMember(Name="commute", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commute")]
    public bool? Commute { get; set; }

    /// <summary>
    /// Whether this activity was recorded on a training machine
    /// </summary>
    /// <value>Whether this activity was recorded on a training machine</value>
    [DataMember(Name="trainer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trainer")]
    public bool? Trainer { get; set; }

    /// <summary>
    /// Whether this activity is muted
    /// </summary>
    /// <value>Whether this activity is muted</value>
    [DataMember(Name="hide_from_home", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hide_from_home")]
    public bool? HideFromHome { get; set; }

    /// <summary>
    /// The description of the activity
    /// </summary>
    /// <value>The description of the activity</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The name of the activity
    /// </summary>
    /// <value>The name of the activity</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Deprecated. Prefer to use sport_type. In a request where both type and sport_type are present, this field will be ignored
    /// </summary>
    /// <value>Deprecated. Prefer to use sport_type. In a request where both type and sport_type are present, this field will be ignored</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public ActivityType Type { get; set; }

    /// <summary>
    /// Gets or Sets SportType
    /// </summary>
    [DataMember(Name="sport_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sport_type")]
    public SportType SportType { get; set; }

    /// <summary>
    /// Identifier for the gear associated with the activity. ???none??? clears gear from activity
    /// </summary>
    /// <value>Identifier for the gear associated with the activity. ???none??? clears gear from activity</value>
    [DataMember(Name="gear_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gear_id")]
    public string GearId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UpdatableActivity {\n");
      sb.Append("  Commute: ").Append(Commute).Append("\n");
      sb.Append("  Trainer: ").Append(Trainer).Append("\n");
      sb.Append("  HideFromHome: ").Append(HideFromHome).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  SportType: ").Append(SportType).Append("\n");
      sb.Append("  GearId: ").Append(GearId).Append("\n");
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
