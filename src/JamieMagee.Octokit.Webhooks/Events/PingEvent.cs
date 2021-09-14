namespace JamieMagee.Octokit.Webhooks.Events
{
    using System.Text.Json.Serialization;
    using JamieMagee.Octokit.Webhooks.Models.PingEvent;

    [WebhookEventType(WebhookEventType.Ping)]
    public sealed record PingEvent : WebhookEvent
    {
        [JsonPropertyName("zen")]
        public string Zen { get; init; }

        [JsonPropertyName("hook_id")]
        public int HookId { get; init; }

        [JsonPropertyName("hook")]
        public Hook Hook { get; init; }
    }
}
