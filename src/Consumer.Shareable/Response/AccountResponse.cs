namespace Consumer.Shareable.Response
{
    public record AccountResponse (string path, string AccountId, string Name, bool ShareData, string Fingerprint,  string TagManagerUrl, Features features);

    public record Features(bool SupportUserPermissions, bool SupportMultipleContainers);

}
