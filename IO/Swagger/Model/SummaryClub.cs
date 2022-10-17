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
  public class SummaryClub : MetaClub {
    /// <summary>
    /// URL to a 60x60 pixel profile picture.
    /// </summary>
    /// <value>URL to a 60x60 pixel profile picture.</value>
    [DataMember(Name="profile_medium", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "profile_medium")]
    public string ProfileMedium { get; set; }

    /// <summary>
    /// URL to a ~1185x580 pixel cover photo.
    /// </summary>
    /// <value>URL to a ~1185x580 pixel cover photo.</value>
    [DataMember(Name="cover_photo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cover_photo")]
    public string CoverPhoto { get; set; }

    /// <summary>
    /// URL to a ~360x176  pixel cover photo.
    /// </summary>
    /// <value>URL to a ~360x176  pixel cover photo.</value>
    [DataMember(Name="cover_photo_small", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cover_photo_small")]
    public string CoverPhotoSmall { get; set; }

    /// <summary>
    /// Deprecated. Prefer to use activity_types.
    /// </summary>
    /// <value>Deprecated. Prefer to use activity_types.</value>
    [DataMember(Name="sport_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sport_type")]
    public string SportType { get; set; }

    /// <summary>
    /// The activity types that count for a club. This takes precedence over sport_type.
    /// </summary>
    /// <value>The activity types that count for a club. This takes precedence over sport_type.</value>
    [DataMember(Name="activity_types", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "activity_types")]
    public List<ActivityType> ActivityTypes { get; set; }

    /// <summary>
    /// The club's city.
    /// </summary>
    /// <value>The club's city.</value>
    [DataMember(Name="city", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// The club's state or geographical region.
    /// </summary>
    /// <value>The club's state or geographical region.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// The club's country.
    /// </summary>
    /// <value>The club's country.</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// Whether the club is private.
    /// </summary>
    /// <value>Whether the club is private.</value>
    [DataMember(Name="private", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "private")]
    public bool? Private { get; set; }

    /// <summary>
    /// The club's member count.
    /// </summary>
    /// <value>The club's member count.</value>
    [DataMember(Name="member_count", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "member_count")]
    public int? MemberCount { get; set; }

    /// <summary>
    /// Whether the club is featured or not.
    /// </summary>
    /// <value>Whether the club is featured or not.</value>
    [DataMember(Name="featured", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "featured")]
    public bool? Featured { get; set; }

    /// <summary>
    /// Whether the club is verified or not.
    /// </summary>
    /// <value>Whether the club is verified or not.</value>
    [DataMember(Name="verified", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "verified")]
    public bool? Verified { get; set; }

    /// <summary>
    /// The club's vanity URL.
    /// </summary>
    /// <value>The club's vanity URL.</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SummaryClub {\n");
      sb.Append("  ProfileMedium: ").Append(ProfileMedium).Append("\n");
      sb.Append("  CoverPhoto: ").Append(CoverPhoto).Append("\n");
      sb.Append("  CoverPhotoSmall: ").Append(CoverPhotoSmall).Append("\n");
      sb.Append("  SportType: ").Append(SportType).Append("\n");
      sb.Append("  ActivityTypes: ").Append(ActivityTypes).Append("\n");
      sb.Append("  City: ").Append(City).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  Private: ").Append(Private).Append("\n");
      sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
      sb.Append("  Featured: ").Append(Featured).Append("\n");
      sb.Append("  Verified: ").Append(Verified).Append("\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
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
