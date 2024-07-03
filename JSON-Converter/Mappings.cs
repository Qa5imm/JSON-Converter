using System.Text.Json.Serialization;

namespace JSON_Converter
{
    // Defining the classes in the JSON file
    public class Artifact
    {
        public Location location { get; set; }
        public int length { get; set; }
    }

    public class ArtifactLocation
    {
        public string uri { get; set; }
        public int index { get; set; }
    }

    public class AutomationDetails
    {
        public string correlationGuid { get; set; }
    }

    public class Driver
    {
        public string name { get; set; }
        public string organization { get; set; }
        public string product { get; set; }
        public string productSuite { get; set; }
        public string informationUri { get; set; }
        public List<Rule> rules { get; set; }
        public string language { get; set; }
    }

    public class Invocation
    {
        public DateTime startTimeUtc { get; set; }
        public DateTime endTimeUtc { get; set; }
        public bool executionSuccessful { get; set; }
    }

    public class Location
    {
        public string uri { get; set; }
    }

    public class Location2
    {
        public PhysicalLocation physicalLocation { get; set; }
        public List<LogicalLocation> logicalLocations { get; set; }
        public Properties properties { get; set; }
    }

    public class LogicalLocation
    {
        public string fullyQualifiedName { get; set; }
    }

    public class Message
    {
        public string text { get; set; }
        public string id { get; set; }
        public List<string> arguments { get; set; }
    }

    public class Message1
    {
        public string text { get; set; }
    }

    public class Message2
    {
        public string text { get; set; }
    }

    public class MessageStrings
    {
        public Message1 message1 { get; set; }
        public Message2 message2 { get; set; }
    }

    public class PhysicalLocation
    {
        public Region region { get; set; }
        public ArtifactLocation artifactLocation { get; set; }
    }

    public class Properties
    {
        public string componentType { get; set; }
        public string primaryCategory { get; set; }
        public string originalSeverity { get; set; }
        public string severity { get; set; }
        public string caLevel { get; set; }
        public string module { get; set; }
        public string member { get; set; }
        public string type { get; set; }
    }

    public class Region
    {
        public Snippet snippet { get; set; }
        public int? startLine { get; set; }
        public int? startColumn { get; set; }
    }

    public class Result
    {
        public string ruleId { get; set; }
        public int ruleIndex { get; set; }
        public Message message { get; set; }
        public List<Location2> locations { get; set; }
        public Properties properties { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("$schema")]
        public string schema { get; set; }
        public string version { get; set; }
        public List<Run> runs { get; set; }
    }

    public class Rule
    {
        public string id { get; set; }
        public string helpUri { get; set; }
        public Properties properties { get; set; }
        public MessageStrings messageStrings { get; set; }
    }

    public class Run
    {
        public Tool tool { get; set; }
        public List<Invocation> invocations { get; set; }
        public string language { get; set; }
        public List<Artifact> artifacts { get; set; }
        public List<Result> results { get; set; }
        public AutomationDetails automationDetails { get; set; }
        public string columnKind { get; set; }
        public List<Translation> translations { get; set; }
    }

    public class Snippet
    {
        public string text { get; set; }
    }

    public class Tool
    {
        public Driver driver { get; set; }
    }

    public class Translation
    {
        public string name { get; set; }
        public List<Rule> rules { get; set; }
        public string language { get; set; }
    }
}
