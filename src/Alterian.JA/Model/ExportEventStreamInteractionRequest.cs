/*
 * Journey Analytics API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 6.35.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Alterian.JA.Client.OpenAPIDateConverter;

namespace Alterian.JA.Model
{
    /// <summary>
    /// ExportEventStreamInteractionRequest
    /// </summary>
    [DataContract(Name = "ExportEventStreamInteraction_request")]
    public partial class ExportEventStreamInteractionRequest : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Alignment
        /// </summary>
        [DataMember(Name = "Alignment", EmitDefaultValue = false)]
        public EventStreamAlignmentType? Alignment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportEventStreamInteractionRequest" /> class.
        /// </summary>
        /// <param name="alignment">alignment.</param>
        /// <param name="alignmentEventName">Optional event name to align to. Requires Alignment to be set.</param>
        /// <param name="alignmentSecondaryEventName">If Alignment is set to Left/Right, and a secondary event column is specified then this is the secondary event name that will be aligned to, with an empty string meaning alignment to NULL.</param>
        /// <param name="columnTransforms">Applies the specified transforms to base the result on the transformed discrete values.</param>
        /// <param name="conversationTimeoutInSeconds">Configures delay after which a new conversation is considered to have started - defaults to 1800s (30mins) when either StreamKey is set to Interaction or Timeout events are required.</param>
        /// <param name="cursor">cursor.</param>
        /// <param name="dataSourceId">Datasource ID.</param>
        /// <param name="eventDateTimeLower">Optionally filter by EventDateTime.</param>
        /// <param name="eventDateTimeUpper">Optionally filter by EventDateTime.</param>
        /// <param name="eventStreamId">Optionally invoke using an Event Stream ID instead of DataSourceId/TableNameEx. In this mode ColumnTransforms will be defaulted to those published against the columns of the Event Stream but can still be overridden if required.</param>
        /// <param name="eventTypes">List of event types to include (default to all).</param>
        /// <param name="filters">Additional columns to filter on.</param>
        /// <param name="includeMatchedEvents">Set to False to exclude all records that fall into specified match events (Defaults to True). Use this to get events in the &#39;other&#39; category by passing all the displayed events and setting match to false.</param>
        /// <param name="initiatives">List of initiatives to include (default to all).</param>
        /// <param name="interaction">Interaction start point.</param>
        /// <param name="isDeduplicationRequired">Indicates whether identical consecutive events in a stream are combined into a single event (default false).</param>
        /// <param name="isTimeoutEventsRequired">Optionally show Start/End conversation events.</param>
        /// <param name="matchEvents">Events to match in the specified interaction. Pass -1 to indicate the &#39;drop off&#39; event and -3 to specify the padded (&#39;no event&#39;) placeholder for right aligned streams.</param>
        /// <param name="pattern">pattern.</param>
        /// <param name="primaryEventColumnName">Optionally set the column name that contains the event names (defaults to Location).</param>
        /// <param name="secondaryEventColumnName">Optionally set a secondary column name that can be used to further partition the events e.g. Channel.</param>
        /// <param name="streamKey">Optionally specify the key to be used for the Sankey - Visitor, Interaction etc (defaults to using the Visitor ID).</param>
        /// <param name="streamQuery">Specify rules for stream inclusion using stream query patterns e.g. Offer/_*_/Checkout would require a stream to have an offer event followed by a checkout event.</param>
        /// <param name="tableNameEx">Event Stream table (standard two part name ex).</param>
        public ExportEventStreamInteractionRequest(EventStreamAlignmentType? alignment = default(EventStreamAlignmentType?), string alignmentEventName = default(string), string alignmentSecondaryEventName = default(string), List<EventStreamColumnTransform> columnTransforms = default(List<EventStreamColumnTransform>), int? conversationTimeoutInSeconds = default(int?), APILastModifiedCursor cursor = default(APILastModifiedCursor), int dataSourceId = default(int), DateTime? eventDateTimeLower = default(DateTime?), DateTime? eventDateTimeUpper = default(DateTime?), int? eventStreamId = default(int?), List<string> eventTypes = default(List<string>), List<ColumnMatchList> filters = default(List<ColumnMatchList>), bool? includeMatchedEvents = default(bool?), List<string> initiatives = default(List<string>), int interaction = default(int), bool isDeduplicationRequired = default(bool), bool? isTimeoutEventsRequired = default(bool?), List<string> matchEvents = default(List<string>), EventStreamPattern pattern = default(EventStreamPattern), string primaryEventColumnName = default(string), string secondaryEventColumnName = default(string), string streamKey = default(string), string streamQuery = default(string), string tableNameEx = default(string))
        {
            this.Alignment = alignment;
            this.AlignmentEventName = alignmentEventName;
            this.AlignmentSecondaryEventName = alignmentSecondaryEventName;
            this.ColumnTransforms = columnTransforms;
            this.ConversationTimeoutInSeconds = conversationTimeoutInSeconds;
            this.Cursor = cursor;
            this.DataSourceId = dataSourceId;
            this.EventDateTimeLower = eventDateTimeLower;
            this.EventDateTimeUpper = eventDateTimeUpper;
            this.EventStreamId = eventStreamId;
            this.EventTypes = eventTypes;
            this.Filters = filters;
            this.IncludeMatchedEvents = includeMatchedEvents;
            this.Initiatives = initiatives;
            this.Interaction = interaction;
            this.IsDeduplicationRequired = isDeduplicationRequired;
            this.IsTimeoutEventsRequired = isTimeoutEventsRequired;
            this.MatchEvents = matchEvents;
            this.Pattern = pattern;
            this.PrimaryEventColumnName = primaryEventColumnName;
            this.SecondaryEventColumnName = secondaryEventColumnName;
            this.StreamKey = streamKey;
            this.StreamQuery = streamQuery;
            this.TableNameEx = tableNameEx;
        }

        /// <summary>
        /// Optional event name to align to. Requires Alignment to be set
        /// </summary>
        /// <value>Optional event name to align to. Requires Alignment to be set</value>
        [DataMember(Name = "AlignmentEventName", EmitDefaultValue = false)]
        public string AlignmentEventName { get; set; }

        /// <summary>
        /// If Alignment is set to Left/Right, and a secondary event column is specified then this is the secondary event name that will be aligned to, with an empty string meaning alignment to NULL
        /// </summary>
        /// <value>If Alignment is set to Left/Right, and a secondary event column is specified then this is the secondary event name that will be aligned to, with an empty string meaning alignment to NULL</value>
        [DataMember(Name = "AlignmentSecondaryEventName", EmitDefaultValue = false)]
        public string AlignmentSecondaryEventName { get; set; }

        /// <summary>
        /// Applies the specified transforms to base the result on the transformed discrete values
        /// </summary>
        /// <value>Applies the specified transforms to base the result on the transformed discrete values</value>
        [DataMember(Name = "ColumnTransforms", EmitDefaultValue = false)]
        public List<EventStreamColumnTransform> ColumnTransforms { get; set; }

        /// <summary>
        /// Configures delay after which a new conversation is considered to have started - defaults to 1800s (30mins) when either StreamKey is set to Interaction or Timeout events are required
        /// </summary>
        /// <value>Configures delay after which a new conversation is considered to have started - defaults to 1800s (30mins) when either StreamKey is set to Interaction or Timeout events are required</value>
        [DataMember(Name = "ConversationTimeoutInSeconds", EmitDefaultValue = true)]
        public int? ConversationTimeoutInSeconds { get; set; }

        /// <summary>
        /// Gets or Sets Cursor
        /// </summary>
        [DataMember(Name = "Cursor", EmitDefaultValue = false)]
        public APILastModifiedCursor Cursor { get; set; }

        /// <summary>
        /// Datasource ID
        /// </summary>
        /// <value>Datasource ID</value>
        [DataMember(Name = "DataSourceId", EmitDefaultValue = false)]
        public int DataSourceId { get; set; }

        /// <summary>
        /// Optionally filter by EventDateTime
        /// </summary>
        /// <value>Optionally filter by EventDateTime</value>
        [DataMember(Name = "EventDateTimeLower", EmitDefaultValue = true)]
        public DateTime? EventDateTimeLower { get; set; }

        /// <summary>
        /// Optionally filter by EventDateTime
        /// </summary>
        /// <value>Optionally filter by EventDateTime</value>
        [DataMember(Name = "EventDateTimeUpper", EmitDefaultValue = true)]
        public DateTime? EventDateTimeUpper { get; set; }

        /// <summary>
        /// Optionally invoke using an Event Stream ID instead of DataSourceId/TableNameEx. In this mode ColumnTransforms will be defaulted to those published against the columns of the Event Stream but can still be overridden if required
        /// </summary>
        /// <value>Optionally invoke using an Event Stream ID instead of DataSourceId/TableNameEx. In this mode ColumnTransforms will be defaulted to those published against the columns of the Event Stream but can still be overridden if required</value>
        [DataMember(Name = "EventStreamId", EmitDefaultValue = true)]
        public int? EventStreamId { get; set; }

        /// <summary>
        /// List of event types to include (default to all)
        /// </summary>
        /// <value>List of event types to include (default to all)</value>
        [DataMember(Name = "EventTypes", EmitDefaultValue = false)]
        public List<string> EventTypes { get; set; }

        /// <summary>
        /// Additional columns to filter on
        /// </summary>
        /// <value>Additional columns to filter on</value>
        [DataMember(Name = "Filters", EmitDefaultValue = false)]
        public List<ColumnMatchList> Filters { get; set; }

        /// <summary>
        /// Set to False to exclude all records that fall into specified match events (Defaults to True). Use this to get events in the &#39;other&#39; category by passing all the displayed events and setting match to false
        /// </summary>
        /// <value>Set to False to exclude all records that fall into specified match events (Defaults to True). Use this to get events in the &#39;other&#39; category by passing all the displayed events and setting match to false</value>
        [DataMember(Name = "IncludeMatchedEvents", EmitDefaultValue = true)]
        public bool? IncludeMatchedEvents { get; set; }

        /// <summary>
        /// List of initiatives to include (default to all)
        /// </summary>
        /// <value>List of initiatives to include (default to all)</value>
        [DataMember(Name = "Initiatives", EmitDefaultValue = false)]
        public List<string> Initiatives { get; set; }

        /// <summary>
        /// Interaction start point
        /// </summary>
        /// <value>Interaction start point</value>
        [DataMember(Name = "Interaction", EmitDefaultValue = false)]
        public int Interaction { get; set; }

        /// <summary>
        /// Indicates whether identical consecutive events in a stream are combined into a single event (default false)
        /// </summary>
        /// <value>Indicates whether identical consecutive events in a stream are combined into a single event (default false)</value>
        [DataMember(Name = "IsDeduplicationRequired", EmitDefaultValue = true)]
        public bool IsDeduplicationRequired { get; set; }

        /// <summary>
        /// Optionally show Start/End conversation events
        /// </summary>
        /// <value>Optionally show Start/End conversation events</value>
        [DataMember(Name = "IsTimeoutEventsRequired", EmitDefaultValue = true)]
        public bool? IsTimeoutEventsRequired { get; set; }

        /// <summary>
        /// Events to match in the specified interaction. Pass -1 to indicate the &#39;drop off&#39; event and -3 to specify the padded (&#39;no event&#39;) placeholder for right aligned streams
        /// </summary>
        /// <value>Events to match in the specified interaction. Pass -1 to indicate the &#39;drop off&#39; event and -3 to specify the padded (&#39;no event&#39;) placeholder for right aligned streams</value>
        [DataMember(Name = "MatchEvents", EmitDefaultValue = false)]
        public List<string> MatchEvents { get; set; }

        /// <summary>
        /// Gets or Sets Pattern
        /// </summary>
        [DataMember(Name = "Pattern", EmitDefaultValue = false)]
        public EventStreamPattern Pattern { get; set; }

        /// <summary>
        /// Optionally set the column name that contains the event names (defaults to Location)
        /// </summary>
        /// <value>Optionally set the column name that contains the event names (defaults to Location)</value>
        [DataMember(Name = "PrimaryEventColumnName", EmitDefaultValue = false)]
        public string PrimaryEventColumnName { get; set; }

        /// <summary>
        /// Optionally set a secondary column name that can be used to further partition the events e.g. Channel
        /// </summary>
        /// <value>Optionally set a secondary column name that can be used to further partition the events e.g. Channel</value>
        [DataMember(Name = "SecondaryEventColumnName", EmitDefaultValue = false)]
        public string SecondaryEventColumnName { get; set; }

        /// <summary>
        /// Optionally specify the key to be used for the Sankey - Visitor, Interaction etc (defaults to using the Visitor ID)
        /// </summary>
        /// <value>Optionally specify the key to be used for the Sankey - Visitor, Interaction etc (defaults to using the Visitor ID)</value>
        [DataMember(Name = "StreamKey", EmitDefaultValue = false)]
        public string StreamKey { get; set; }

        /// <summary>
        /// Specify rules for stream inclusion using stream query patterns e.g. Offer/_*_/Checkout would require a stream to have an offer event followed by a checkout event
        /// </summary>
        /// <value>Specify rules for stream inclusion using stream query patterns e.g. Offer/_*_/Checkout would require a stream to have an offer event followed by a checkout event</value>
        [DataMember(Name = "StreamQuery", EmitDefaultValue = false)]
        public string StreamQuery { get; set; }

        /// <summary>
        /// Event Stream table (standard two part name ex)
        /// </summary>
        /// <value>Event Stream table (standard two part name ex)</value>
        [DataMember(Name = "TableNameEx", EmitDefaultValue = false)]
        public string TableNameEx { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExportEventStreamInteractionRequest {\n");
            sb.Append("  Alignment: ").Append(Alignment).Append("\n");
            sb.Append("  AlignmentEventName: ").Append(AlignmentEventName).Append("\n");
            sb.Append("  AlignmentSecondaryEventName: ").Append(AlignmentSecondaryEventName).Append("\n");
            sb.Append("  ColumnTransforms: ").Append(ColumnTransforms).Append("\n");
            sb.Append("  ConversationTimeoutInSeconds: ").Append(ConversationTimeoutInSeconds).Append("\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  DataSourceId: ").Append(DataSourceId).Append("\n");
            sb.Append("  EventDateTimeLower: ").Append(EventDateTimeLower).Append("\n");
            sb.Append("  EventDateTimeUpper: ").Append(EventDateTimeUpper).Append("\n");
            sb.Append("  EventStreamId: ").Append(EventStreamId).Append("\n");
            sb.Append("  EventTypes: ").Append(EventTypes).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  IncludeMatchedEvents: ").Append(IncludeMatchedEvents).Append("\n");
            sb.Append("  Initiatives: ").Append(Initiatives).Append("\n");
            sb.Append("  Interaction: ").Append(Interaction).Append("\n");
            sb.Append("  IsDeduplicationRequired: ").Append(IsDeduplicationRequired).Append("\n");
            sb.Append("  IsTimeoutEventsRequired: ").Append(IsTimeoutEventsRequired).Append("\n");
            sb.Append("  MatchEvents: ").Append(MatchEvents).Append("\n");
            sb.Append("  Pattern: ").Append(Pattern).Append("\n");
            sb.Append("  PrimaryEventColumnName: ").Append(PrimaryEventColumnName).Append("\n");
            sb.Append("  SecondaryEventColumnName: ").Append(SecondaryEventColumnName).Append("\n");
            sb.Append("  StreamKey: ").Append(StreamKey).Append("\n");
            sb.Append("  StreamQuery: ").Append(StreamQuery).Append("\n");
            sb.Append("  TableNameEx: ").Append(TableNameEx).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}