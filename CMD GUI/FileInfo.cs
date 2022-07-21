namespace CMD_GUI;
public class FileInfo
{
    [XmlElement(ElementName = "Source File")] public string SourceFile { get; set; }

    [XmlElement(ElementName = "Options")] public List<string> Options { get; set; }

    [XmlElement(ElementName = "Working Directory")] public string WorkingDirectory { get; set; }

    [XmlElement(ElementName = "Target File")] public string TargetFile { get; set; }
}