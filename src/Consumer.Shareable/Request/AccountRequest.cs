namespace Consumer.Shareable.Request
{

    public record  AccountRequest (string path, string AccountId, string Name, bool ShareData, string Fingerprint, string TagManagerUrl, Features features);
}
